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
    public partial class Promotions : UserControl
    {
        public string UserName;
        Controller controller = new Controller();
        public Promotions()
        {
            InitializeComponent();
            ReloadData();
        }
        public void ReloadData()
        {
            DataTable dataTable = new DataTable();
            dataTable = controller.GetGenre(UserName);
            Genres.DataSource = dataTable;
            Genres.DisplayMember = "Genre";
            Genres.Refresh();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ApplyDiscount_Click(object sender, EventArgs e)
        {
            string genre = Genres.Text;
            int per;
            if (!Validations.Isinteger(DiscountAmount.Text, out per))
            {
                MessageBox.Show("Please enter an integer");
                return;
            }
            else
            {
                if (!Validations.Isinrange(DiscountAmount.Text, 0, 100))
                {
                    MessageBox.Show("Discount Percentage must be between 0 and 100");
                    return;
                }
                else
                {
                    per = Convert.ToInt32(DiscountAmount.Text);
                }
            }
            int result=controller.ApplyPromotion(UserName,genre,per);
            if (result == 0)
            {
                MessageBox.Show("Promotion Failed");
                return;
            }
            else
            {
                MessageBox.Show("Promotion Done");
                return;
            }
        }
    }
}
