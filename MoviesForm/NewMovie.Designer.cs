using System;

namespace MoviesForm
{
    partial class NewMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTitle = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtTime = new System.Windows.Forms.TextBox();
            this._txtOwn = new System.Windows.Forms.CheckBox();
            this._txtSaved = new System.Windows.Forms.Button();
            this._txtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // _txtTitle
            // 
            this._txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtTitle.Location = new System.Drawing.Point(215, 49);
            this._txtTitle.Name = "_txtTitle";
            this._txtTitle.Size = new System.Drawing.Size(183, 35);
            this._txtTitle.TabIndex = 3;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(215, 111);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(183, 35);
            this._txtDescription.TabIndex = 4;
            // 
            // _txtTime
            // 
            this._txtTime.Location = new System.Drawing.Point(215, 180);
            this._txtTime.Name = "_txtTime";
            this._txtTime.Size = new System.Drawing.Size(183, 35);
            this._txtTime.TabIndex = 5;
            // 
            // _txtOwn
            // 
            this._txtOwn.AutoSize = true;
            this._txtOwn.Location = new System.Drawing.Point(215, 258);
            this._txtOwn.Name = "_txtOwn";
            this._txtOwn.Size = new System.Drawing.Size(107, 33);
            this._txtOwn.TabIndex = 6;
            this._txtOwn.Text = "Own?";
            this._txtOwn.UseVisualStyleBackColor = true;
            // 
            // _txtSaved
            // 
            this._txtSaved.Location = new System.Drawing.Point(432, 371);
            this._txtSaved.Name = "_txtSaved";
            this._txtSaved.Size = new System.Drawing.Size(140, 47);
            this._txtSaved.TabIndex = 7;
            this._txtSaved.Text = "Saved";
            this._txtSaved.UseVisualStyleBackColor = true;
            this._txtSaved.Click += new System.EventHandler(this.OnSave);
            // 
            // _txtCancel
            // 
            this._txtCancel.Location = new System.Drawing.Point(215, 371);
            this._txtCancel.Name = "_txtCancel";
            this._txtCancel.Size = new System.Drawing.Size(152, 46);
            this._txtCancel.TabIndex = 8;
            this._txtCancel.Text = "cancel";
            this._txtCancel.UseVisualStyleBackColor = true;
            this._txtCancel.Click += new System.EventHandler(this._txtCancel_Click_1);
            // 
            // NewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 439);
            this.Controls.Add(this._txtCancel);
            this.Controls.Add(this._txtSaved);
            this.Controls.Add(this._txtOwn);
            this.Controls.Add(this._txtTime);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMovie";
            this.Text = "NewMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OnCancel(object sender, EventArgs e)
        {

        }

        private void _txtTitle_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtTitle;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtTime;
        private System.Windows.Forms.CheckBox _txtOwn;
        private System.Windows.Forms.Button _txtSaved;
        private System.Windows.Forms.Button _txtCancel;
    }
}