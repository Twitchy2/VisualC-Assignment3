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

    public partial class OrderForm : Form
    {
        double cost;
        double subTotal;
        double SalesTax;
        double FinalPrice;
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load everything important on this form and make it calculate stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            //do first group box
            TitleTextBox.Text = Program.movie.MovieName;
            CatagoryTextBox.Text = Program.movie.Catagory;
            //Finds the name of hte string and compares it to hte name of the image, sets if same
            String imageString = Regex.Replace(TitleTextBox.Text, @"\+", "");

            MoviePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);

            //do second now

            CostTextBox.Text = Program.movie.FirstCost;

            cost = Convert.ToDouble(Program.movie.FirstCost);

            subTotal = cost;

            SubtotalTextBox.Text = subTotal.ToString("C2");

            SalesTax = (subTotal * 0.13);

            SalesTaxTextBox.Text = SalesTax.ToString("C2");

            FinalPrice = subTotal + SalesTax;

            TotalTextBox.Text = FinalPrice.ToString("C2");

            





        }
        /// <summary>
        /// Adds 10 if checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double dvd = 10;
            if (DVDCheckBox.Checked == true)
            {
                subTotal = subTotal + dvd;
                SalesTax = subTotal * 0.13;
                FinalPrice = subTotal + SalesTax;
                
                DVDTextBox.Enabled = true;
                DVDLabel.Enabled = true;
                DVDTextBox.Visible = true;
                DVDLabel.Visible = true;
            } else if (DVDCheckBox.Checked == false) 
            {
                subTotal = subTotal - dvd;
                SalesTax = subTotal * 0.13;
                FinalPrice = subTotal + SalesTax;
                DVDTextBox.Enabled = false;
                DVDLabel.Enabled = false;
                DVDTextBox.Enabled = false;
                DVDLabel.Enabled = false;
            }
            SubtotalTextBox.Text = subTotal.ToString("C2");
            SalesTaxTextBox.Text = SalesTax.ToString("C2");
            TotalTextBox.Text = FinalPrice.ToString("C2");
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            BeginStream();
        }
        /// <summary>
        /// Method to move on
        /// </summary>
        private void BeginStream()
        {
            Program.movie.FinalCost = TotalTextBox.Text;

            this.Hide();
            StreamForm streamForm = new StreamForm();

            streamForm.Show();
        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginStream();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        /// <summary>
        /// CLoses the form
        /// </summary>
        private void CloseForm()
        {
            this.Close();
            Application.Exit();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        //Go back around
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SharpMovies movies = new SharpMovies();
            movies.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your current movie is " + Program.movie.MovieName + ", and your cost is: " + FinalPrice, "Preview of Order");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();

            aboutBox.Show();
        }
    }
}
