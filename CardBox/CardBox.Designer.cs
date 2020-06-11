/**
 * CardBox.cs - The CardBox Designer
 * 
 * @author      Thom MacDonald
 *              Devansh Patel
 * @version     1.0
 * @since       2019-02-22  
 * @see         <videolink>
 * @see:        <http://en.wikipedia.org/wiki/Playing_card#French_design>
 *  
 */


using DurakClassLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TheCardBox
{
    partial class CardBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pbMyPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMyPictureBox
            // 
            this.pbMyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMyPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pbMyPictureBox.Name = "pbMyPictureBox";
            this.pbMyPictureBox.Size = new System.Drawing.Size(152, 216);
            this.pbMyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyPictureBox.TabIndex = 0;
            this.pbMyPictureBox.TabStop = false;
            this.pbMyPictureBox.Click += new System.EventHandler(this.pbMyPictureBox_Click);
            this.pbMyPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMyPictureBox_MouseDown);
            this.pbMyPictureBox.MouseEnter += new System.EventHandler(this.pbMyPictureBox_MouseEnter);
            this.pbMyPictureBox.MouseLeave += new System.EventHandler(this.pbMyPictureBox_MouseLeave);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbMyPictureBox);
            this.Name = "CardBox";
            this.Size = new System.Drawing.Size(152, 216);
            this.Load += new System.EventHandler(this.CardBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMyPictureBox;
    }
}
