using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class Publish_Game : Form
    {
        Controller Controllerobj = new Controller();
        public string Publisherusername;
        public Publish_Game(string PubisherUsername)
        {
            InitializeComponent();
            Publisherusername = PubisherUsername;
        }

        private void Publish_Game_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GameName = GameNameText.Text;
            string Genre = GenreCombo.Text;
            DateTime selectedDate = dateTimePicker1.Value;
            string ReleaseDate = selectedDate.ToString("yyyy-MM-dd");
            string ConsoleName = ConsoleNameText.Text;
            string EngineName = EngineNameText.Text;
            bool isint = Int32.TryParse(RatingText.Text, out int rating);
            string Reviewer =ReviewerText.Text;
            if (GameName == "")
            {
                MessageBox.Show("Please Enter a Game Name");
                return;
            }

            if(Genre =="")
            {
                MessageBox.Show("Please choose a Genre");
                return;
            }

            if(ReleaseDate == "")
            {
                MessageBox.Show("Please enter a release date");
                return;
            }

            if(ConsoleName == "")
            {
                MessageBox.Show("Please enter a Console Name");
                return;
            }

            if(EngineName == "")
            {
                MessageBox.Show("Please Enter a Engine Name");
                return;
            }

            if (!isint)
            {
                MessageBox.Show("Please Enter a Number in the Rating field");
                return;
            }

            if(rating <0)
            {
                MessageBox.Show("Please Enter a positive number in the Rating field");
                return;
            }

            if(rating > 5)
            {
                MessageBox.Show("Please Enter a number below 5 in the Rating field");
                return;
            }

            int res = Controllerobj.Add_Game(GameName,Genre,ReleaseDate,ConsoleName,EngineName,Reviewer,Publisherusername,rating);

            if (res == 0)
            {
                MessageBox.Show("The Game Failed To be Published");
            }
            else
            {
                MessageBox.Show("The Game Published Successfully");
            }


            
        }
    }
}
