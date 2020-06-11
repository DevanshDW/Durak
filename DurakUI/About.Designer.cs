namespace DurakUI
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnThankYou = new System.Windows.Forms.Button();
            this.rtbContact = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnThankYou
            // 
            this.btnThankYou.BackColor = System.Drawing.Color.MintCream;
            this.btnThankYou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThankYou.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThankYou.FlatAppearance.BorderSize = 0;
            this.btnThankYou.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThankYou.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThankYou.Location = new System.Drawing.Point(0, 344);
            this.btnThankYou.Name = "btnThankYou";
            this.btnThankYou.Size = new System.Drawing.Size(806, 46);
            this.btnThankYou.TabIndex = 1;
            this.btnThankYou.Text = "Thank You";
            this.btnThankYou.UseVisualStyleBackColor = false;
            this.btnThankYou.Click += new System.EventHandler(this.btnThankYou_Click);
            // 
            // rtbContact
            // 
            this.rtbContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContact.BackColor = System.Drawing.Color.MintCream;
            this.rtbContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContact.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContact.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rtbContact.Location = new System.Drawing.Point(0, 12);
            this.rtbContact.Name = "rtbContact";
            this.rtbContact.Size = new System.Drawing.Size(806, 339);
            this.rtbContact.TabIndex = 0;
            this.rtbContact.Text = resources.GetString("rtbContact.Text");
            this.rtbContact.TextChanged += new System.EventHandler(this.rtbContact_TextChanged);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(806, 390);
            this.Controls.Add(this.btnThankYou);
            this.Controls.Add(this.rtbContact);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frmAbout";
            this.Text = "About Windows Form Durak Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThankYou;
        private System.Windows.Forms.RichTextBox rtbContact;
    }
}