namespace DurakUI
{
    partial class frmPlayTime
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
            this.pnlMachine = new System.Windows.Forms.Panel();
            this.pnlHuman = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.pbTrump = new System.Windows.Forms.PictureBox();
            this.pbDiscard = new System.Windows.Forms.PictureBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblHumanName = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeckCounter = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMachine
            // 
            this.pnlMachine.Location = new System.Drawing.Point(467, 9);
            this.pnlMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMachine.Name = "pnlMachine";
            this.pnlMachine.Size = new System.Drawing.Size(713, 234);
            this.pnlMachine.TabIndex = 2;
            // 
            // pnlHuman
            // 
            this.pnlHuman.Location = new System.Drawing.Point(467, 569);
            this.pnlHuman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHuman.Name = "pnlHuman";
            this.pnlHuman.Size = new System.Drawing.Size(713, 234);
            this.pnlHuman.TabIndex = 3;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(293, 258);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1067, 295);
            this.pnlTable.TabIndex = 4;
            // 
            // pbDeck
            // 
            this.pbDeck.Location = new System.Drawing.Point(32, 272);
            this.pbDeck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(152, 217);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeck.TabIndex = 26;
            this.pbDeck.TabStop = false;
            // 
            // pbTrump
            // 
            this.pbTrump.Location = new System.Drawing.Point(56, 313);
            this.pbTrump.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTrump.Name = "pbTrump";
            this.pbTrump.Size = new System.Drawing.Size(216, 153);
            this.pbTrump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrump.TabIndex = 27;
            this.pbTrump.TabStop = false;
            // 
            // pbDiscard
            // 
            this.pbDiscard.Location = new System.Drawing.Point(1392, 272);
            this.pbDiscard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDiscard.Name = "pbDiscard";
            this.pbDiscard.Size = new System.Drawing.Size(152, 217);
            this.pbDiscard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiscard.TabIndex = 28;
            this.pbDiscard.TabStop = false;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.Crimson;
            this.btnEndTurn.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEndTurn.Location = new System.Drawing.Point(273, 743);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(188, 52);
            this.btnEndTurn.TabIndex = 29;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblHumanName
            // 
            this.lblHumanName.AutoSize = true;
            this.lblHumanName.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumanName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHumanName.Location = new System.Drawing.Point(1185, 752);
            this.lblHumanName.Name = "lblHumanName";
            this.lblHumanName.Size = new System.Drawing.Size(240, 35);
            this.lblHumanName.TabIndex = 30;
            this.lblHumanName.Text = "lblHumanName";
            this.lblHumanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblComputerName.Location = new System.Drawing.Point(1192, 197);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblComputerName.Size = new System.Drawing.Size(278, 33);
            this.lblComputerName.TabIndex = 31;
            this.lblComputerName.Text = "lblComputerName";
            this.lblComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.Location = new System.Drawing.Point(1428, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 64);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Menu";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDeckCounter
            // 
            this.lblDeckCounter.AutoSize = true;
            this.lblDeckCounter.BackColor = System.Drawing.Color.FloralWhite;
            this.lblDeckCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckCounter.ForeColor = System.Drawing.Color.Crimson;
            this.lblDeckCounter.Location = new System.Drawing.Point(75, 222);
            this.lblDeckCounter.Name = "lblDeckCounter";
            this.lblDeckCounter.Size = new System.Drawing.Size(53, 38);
            this.lblDeckCounter.TabIndex = 33;
            this.lblDeckCounter.Text = "24";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.BackColor = System.Drawing.Color.FloralWhite;
            this.lblCardNum.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.ForeColor = System.Drawing.Color.Crimson;
            this.lblCardNum.Location = new System.Drawing.Point(52, 181);
            this.lblCardNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(103, 35);
            this.lblCardNum.TabIndex = 34;
            this.lblCardNum.Text = "Cards";
            // 
            // frmPlayTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.ControlBox = false;
            this.Controls.Add(this.lblCardNum);
            this.Controls.Add(this.lblDeckCounter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.lblHumanName);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.pbTrump);
            this.Controls.Add(this.pbDiscard);
            this.Controls.Add(this.pnlHuman);
            this.Controls.Add(this.pnlMachine);
            this.Controls.Add(this.pnlTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlayTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Time";
            this.Load += new System.EventHandler(this.frmPlayTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMachine;
        private System.Windows.Forms.Panel pnlHuman;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.PictureBox pbTrump;
        private System.Windows.Forms.PictureBox pbDiscard;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblHumanName;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeckCounter;
        private System.Windows.Forms.Label lblCardNum;
    }
}