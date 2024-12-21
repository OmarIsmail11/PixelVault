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
    public partial class Add_Tournament : Form
    {
        public string UserName;
        Controller controller = new Controller();
        public Add_Tournament(string userName)
        {
            InitializeComponent();
            UserName = userName;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            Region.DataSource = controller.Regions();
            Region.DisplayMember = "Region";
            Type.DataSource = controller.Types();
            Type.DisplayMember = "TournamentType";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StoreMain storeMain = new StoreMain(UserName);
            storeMain.Show();
        }

        private void Add_Tournament_val_Click_1(object sender, EventArgs e)
        {
            if (TName.Text == "") MessageBox.Show("Please Enter Tournament Name");
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
            int result;
            if (Prize != 0)
            {
                if (dateTimePicker1.Text != "")
                    result = controller.InsertNewTournament(tname, capacity, type, region, StartDate, organizer, Prize);
                else
                    result = controller.InsertNewTournamentWithoutDate(tname, capacity, type, region, organizer, Prize);

            }
            else
            {
                if (dateTimePicker1.Text != "")
                    result = controller.InsertNewTournamentWithoutMoney(tname, capacity, type, region, StartDate, organizer);
                else
                    result = controller.InsertNewTournamentWithoutMoneyAndDate(tname, capacity, type, region, organizer);
            }
            if (result == 0)
            {
                MessageBox.Show("Tournament not added");
                return;
            }
            else
            {
                MessageBox.Show("Tournament added succesfuly");
                return;
            }
        }

        private void PMoney_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Tournament_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
