using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualC_Assignment3.Properties;

namespace VisualC_Assignment3
{
    /// <summary>
    /// Mdae by Logan Sikora beder
    /// 200312188
    /// Assignment 3 Visual C#
    /// Nov 3rd, 2016
    /// </summary>
    public partial class SharpMovies : Form
    {
        public SharpMovies()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Will define the movie lists and send thme where they need to be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add and store
            SelectedMovieTextBox.Text = MoviesListBox.SelectedItem.ToString();

            //This will define all of the catagories and costs
            String Catagory = "";

            if (MoviesListBox.SelectedIndex == 0 || MoviesListBox.SelectedIndex == 8 || MoviesListBox.SelectedIndex == 9)
            {
                Catagory = "Action";
            }
            else if (MoviesListBox.SelectedIndex == 1 || MoviesListBox.SelectedIndex == 2 || MoviesListBox.SelectedIndex == 3 || MoviesListBox.SelectedIndex == 5 || MoviesListBox.SelectedIndex == 7)
            {
                Catagory = "New Release";
            }
            else if (MoviesListBox.SelectedIndex == 3 || MoviesListBox.SelectedIndex == 4 || MoviesListBox.SelectedIndex == 10)
            {
                Catagory = "Horror";
            }
            else if (MoviesListBox.SelectedIndex == 6)
            {
                Catagory = "Sci-Fi";
            }

            CatagoryTextBox.Text = Catagory;
            //Now choose price
            double Price = 0;

            if (Catagory == "Action")
            {
                Price = 2.99;
            }
            else if (Catagory == "Horror")
            {
                Price = 2.99;
            }
            else if (Catagory == "New Release")
            {
                Price = 4.99;
            }
            else if (Catagory == "Sci-Fi")
            {
                Price = 2.99;
            }

            CostTextBox.Text = Price.ToString();
            //set button to yes
            NextButton.Enabled = true;

            //also put in those images
            //Finds the name of hte string and compares it to hte name of the image, sets if same
            String imageString = Regex.Replace(SelectedMovieTextBox.Text, @"\+", "");

            MoviePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);

            //Set things where they need to be

            Program.movie.MovieName = SelectedMovieTextBox.Text;
            Program.movie.Catagory = CatagoryTextBox.Text;
            Program.movie.FirstCost = CostTextBox.Text;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Close();

            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
