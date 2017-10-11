
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
    public partial class NewMovie : Form
    {
        #region Construction 
        public NewMovie()
        {
            InitializeComponent();
        }
        public NewMovie(string title) : this()
        {
            Text = title; 
        }

        public NewMovie (string title, Details details) : this(title)
        {
            Details = details; 
        }
        #endregion
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

                if  (Details != null) 
                 {
                   _txtTitle.Text = Details.Title;
                   _txtDescription.Text = Details.Description;
                 _txtTime.Text = Details.Time.ToString();
                 _txtOwn.Checked = Details.Own; 
                 }
        }
        ///<summary>Gets or sets the Details being shown </summary>
        public Details Details { get; set; }
        private void showError(string message, string title)
        {
            MessageBox.Show(this, message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave(object sender, EventArgs e)
        {
            var details = new Details();
            details.Title = _txtTitle.Text;
            details.Description = _txtDescription.Text;
            details.Time = GetTime();
            details.Own = _txtOwn.Checked;
            Close();

            // Adding Validation of items 
            var error = details.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                //Show the error
                MessageBox.Show(error, "Validation Error");
                return;
            }

            Details = details;
            this.DialogResult = DialogResult.OK;
        }


        private decimal GetTime()
        {
            if (Decimal.TryParse(_txtTime.Text, out decimal Time))
                return Time;


            return 0;
        }
        private void NewMovie_FormCanceling(object sender, FormClosingEventArgs e)
        {
            var form = sender as Form;

            if (sender is int)
            {
                var intValue2 = (int)sender;
            }
            if (sender is int intValue)
            {

            }

            if (MessageBox.Show(this, "Are you sure?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true; 
        }
        private void _txtCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close(); 
        }
    }
  }   
