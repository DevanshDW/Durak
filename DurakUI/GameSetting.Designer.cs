namespace DurakUI
{
    partial class frmGameSetting
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
            this.rdo52Cards = new System.Windows.Forms.RadioButton();
            this.rdo36Cards = new System.Windows.Forms.RadioButton();
            this.groupBoxDeckButton = new System.Windows.Forms.GroupBox();
            this.lblDeckSize = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdo20Cards = new System.Windows.Forms.RadioButton();
            this.groupBoxDeckButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo52Cards
            // 
            this.rdo52Cards.AutoSize = true;
            this.rdo52Cards.Location = new System.Drawing.Point(153, 14);
            this.rdo52Cards.Margin = new System.Windows.Forms.Padding(2);
            this.rdo52Cards.Name = "rdo52Cards";
            this.rdo52Cards.Size = new System.Drawing.Size(66, 17);
            this.rdo52Cards.TabIndex = 18;
            this.rdo52Cards.TabStop = true;
            this.rdo52Cards.Text = "52 Deck";
            this.rdo52Cards.UseVisualStyleBackColor = true;
            // 
            // rdo36Cards
            // 
            this.rdo36Cards.AutoSize = true;
            this.rdo36Cards.Location = new System.Drawing.Point(83, 14);
            this.rdo36Cards.Margin = new System.Windows.Forms.Padding(2);
            this.rdo36Cards.Name = "rdo36Cards";
            this.rdo36Cards.Size = new System.Drawing.Size(67, 17);
            this.rdo36Cards.TabIndex = 17;
            this.rdo36Cards.TabStop = true;
            this.rdo36Cards.Text = "36 Cards";
            this.rdo36Cards.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeckButton
            // 
            this.groupBoxDeckButton.Controls.Add(this.rdo20Cards);
            this.groupBoxDeckButton.Controls.Add(this.rdo52Cards);
            this.groupBoxDeckButton.Controls.Add(this.rdo36Cards);
            this.groupBoxDeckButton.Location = new System.Drawing.Point(267, 93);
            this.groupBoxDeckButton.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDeckButton.Name = "groupBoxDeckButton";
            this.groupBoxDeckButton.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDeckButton.Size = new System.Drawing.Size(223, 39);
            this.groupBoxDeckButton.TabIndex = 29;
            this.groupBoxDeckButton.TabStop = false;
            // 
            // lblDeckSize
            // 
            this.lblDeckSize.AutoSize = true;
            this.lblDeckSize.Font = new System.Drawing.Font("Showcard Gothic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSize.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDeckSize.Location = new System.Drawing.Point(24, 100);
            this.lblDeckSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeckSize.Name = "lblDeckSize";
            this.lblDeckSize.Size = new System.Drawing.Size(225, 29);
            this.lblDeckSize.TabIndex = 21;
            this.lblDeckSize.Text = "Select Deck Size";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnBack.Location = new System.Drawing.Point(267, 158);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack.Size = new System.Drawing.Size(163, 52);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Location = new System.Drawing.Point(197, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 46);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Game Settings";
            // 
            // rdo20Cards
            // 
            this.rdo20Cards.AutoSize = true;
            this.rdo20Cards.Location = new System.Drawing.Point(8, 14);
            this.rdo20Cards.Margin = new System.Windows.Forms.Padding(2);
            this.rdo20Cards.Name = "rdo20Cards";
            this.rdo20Cards.Size = new System.Drawing.Size(67, 17);
            this.rdo20Cards.TabIndex = 19;
            this.rdo20Cards.TabStop = true;
            this.rdo20Cards.Text = "20 Cards";
            this.rdo20Cards.UseVisualStyleBackColor = true;
            // 
            // frmGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 229);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxDeckButton);
            this.Controls.Add(this.lblDeckSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGameSetting";
            this.Text = "GameSetting";
            this.groupBoxDeckButton.ResumeLayout(false);
            this.groupBoxDeckButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdo52Cards;
        private System.Windows.Forms.RadioButton rdo36Cards;
        private System.Windows.Forms.GroupBox groupBoxDeckButton;
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdo20Cards;
    }
}