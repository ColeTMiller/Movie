//Cole Miller
// 10/09/2017
//Lab 2
using MovieDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Close(); 
        }

        private void EditMovie(object sender, EventArgs e)
        {
            var child = new NewMovie("Movie Detail");
            child.Details = _details;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save product
            _details = child.Details; 
        }

        private void AddMovie(object sender, EventArgs e)
        {
            var child = new NewMovie("NewMovie");
            if (child.ShowDialog(this) != DialogResult.OK)
                return; 

            // TODO: Save Movie
            _details = child.Details; 
        }

        private void DeleteMovie(object sender, EventArgs e)
        {
            if (_details == null)
                return;

            // confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete {_details.Title }'?",
                                            "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Delete product
            _details = null; 
        }
        private  Details _details;

        private void About(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.ShowDialog(this); 
        }
        
    }
}
