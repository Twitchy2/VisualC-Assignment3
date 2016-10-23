using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualC_Assignment3
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;

            SharpMovies Movies = new SharpMovies();
            Movies.Show();
            this.Hide();
        }
    }
}
