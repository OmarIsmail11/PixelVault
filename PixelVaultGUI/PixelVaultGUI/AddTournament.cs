using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;

namespace PixelVaultGUI
{
    public partial class AddTournament : UserControl
    {
        public string UserName;
        Controller controller = new Controller();
        public AddTournament()
        {
            InitializeComponent();
            ReloadData();
        }
        public void ReloadData()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            Region.DataSource = controller.Regions();
            Region.DisplayMember = "Region";
            Type.DataSource = controller.Types();
            Type.DisplayMember = "TournamentType";
            GameName.DataSource = controller.GameNameInventory(UserName);
            GameName.DisplayMember = "GameName";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Tournament_val_Click(object sender, EventArgs e)
        {
            if (TName.Text == "")
            {
                MessageBox.Show("Please Enter Tournament Name");
                return;
            }
            string tname = TName.Text;
            int capacity;
            if (!(Capacity.Text == ""))
            {
                if (Validations.Isinteger(Capacity.Text, out capacity))
                {
                    if (Validations.IsPositive(Capacity.Text))
                    {
                        capacity = Convert.ToInt32(Capacity.Text);
                    }
                    else
                    {
                        MessageBox.Show("Capacity must be positive");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Capacity must be an integer");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Tournament's Capacity");
                return;
            }
            float Prize = 0;
            if (!(PMoney.Text == ""))
            {
                if (Validations.Isfloat(PMoney.Text, out Prize))
                {
                    if (Validations.IsPositive(PMoney.Text))
                    {
                        Prize = float.Parse(PMoney.Text);
                    }
                    else
                    {
                        MessageBox.Show("Prize Money must be positive");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Prize must be a number");
                    return;
                }
            }
            DateTime selectedDate = dateTimePicker1.Value;
            string StartDate = selectedDate.ToString("yyyy-MM-dd");
            string type = Type.Text;
            string region = Region.Text;
            string organizer = UserName;
            string gamename = GameName.Text;
            int result;
            if (Prize != 0)
            {
                result = controller.InsertNewTournament(tname, capacity, gamename, type, region, StartDate, organizer, Prize);
            }
            else
            {
                result = controller.InsertNewTournamentWithoutMoney(tname, capacity, gamename, type, region, StartDate, organizer);
            }
            if (result == 0)
            {
                MessageBox.Show("Tournament not added");
                return;
            }
            else
            {
                ReloadData();
                
                MessageBox.Show("Tournament added succesfuly");
                TName.Text = "";
                Capacity.Text = "";
                PMoney.Text = "";
                return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Add_Tournament_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
