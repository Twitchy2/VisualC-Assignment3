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
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load everything important on this
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Program.movie.MovieName;
            CatagoryTextBox.Text = Program.movie.Catagory;
            //Finds the name of hte string and compares it to hte name of the image, sets if same
            String imageString = Regex.Replace(TitleTextBox.Text, @"\+", "");

            MoviePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }
    }
}
