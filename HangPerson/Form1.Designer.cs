namespace HangPerson
{
    partial class frmHangTen
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
            this.mnuHangTen = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetWord = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCText = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.pbHangTen = new System.Windows.Forms.PictureBox();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.flpLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReveal = new System.Windows.Forms.Label();
            this.lblWinName = new System.Windows.Forms.Label();
            this.lblLossesName = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.mnuHangTen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangTen)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuHangTen
            // 
            this.mnuHangTen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuHangTen.Location = new System.Drawing.Point(0, 0);
            this.mnuHangTen.Name = "mnuHangTen";
            this.mnuHangTen.Size = new System.Drawing.Size(746, 24);
            this.mnuHangTen.TabIndex = 0;
            this.mnuHangTen.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategory,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(122, 22);
            this.mnuCategory.Text = "Category";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(122, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnGetWord
            // 
            this.btnGetWord.Location = new System.Drawing.Point(331, 459);
            this.btnGetWord.Name = "btnGetWord";
            this.btnGetWord.Size = new System.Drawing.Size(102, 40);
            this.btnGetWord.TabIndex = 1;
            this.btnGetWord.Text = "Get Word";
            this.btnGetWord.UseVisualStyleBackColor = true;
            this.btnGetWord.Click += new System.EventHandler(this.btnGetWord_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWord.Location = new System.Drawing.Point(12, 390);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 13);
            this.lblWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category:";
            // 
            // lblCText
            // 
            this.lblCText.AutoSize = true;
            this.lblCText.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCText.Location = new System.Drawing.Point(262, 376);
            this.lblCText.Name = "lblCText";
            this.lblCText.Size = new System.Drawing.Size(0, 27);
            this.lblCText.TabIndex = 3;
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask.Location = new System.Drawing.Point(278, 310);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(0, 40);
            this.lblMask.TabIndex = 4;
            this.lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHangTen
            // 
            this.pbHangTen.Location = new System.Drawing.Point(130, 59);
            this.pbHangTen.Name = "pbHangTen";
            this.pbHangTen.Size = new System.Drawing.Size(210, 236);
            this.pbHangTen.TabIndex = 5;
            this.pbHangTen.TabStop = false;
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(774, 331);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 23);
            this.btnNextImage.TabIndex = 6;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // flpLetters
            // 
            this.flpLetters.Location = new System.Drawing.Point(433, 123);
            this.flpLetters.Name = "flpLetters";
            this.flpLetters.Size = new System.Drawing.Size(234, 172);
            this.flpLetters.TabIndex = 7;
            // 
            // lblReveal
            // 
            this.lblReveal.AutoSize = true;
            this.lblReveal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReveal.ForeColor = System.Drawing.Color.Blue;
            this.lblReveal.Location = new System.Drawing.Point(384, 59);
            this.lblReveal.Name = "lblReveal";
            this.lblReveal.Size = new System.Drawing.Size(0, 33);
            this.lblReveal.TabIndex = 8;
            // 
            // lblWinName
            // 
            this.lblWinName.AutoSize = true;
            this.lblWinName.BackColor = System.Drawing.Color.Transparent;
            this.lblWinName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinName.Location = new System.Drawing.Point(0, 59);
            this.lblWinName.Name = "lblWinName";
            this.lblWinName.Size = new System.Drawing.Size(53, 19);
            this.lblWinName.TabIndex = 9;
            this.lblWinName.Text = "Wins:";
            // 
            // lblLossesName
            // 
            this.lblLossesName.AutoSize = true;
            this.lblLossesName.BackColor = System.Drawing.Color.Transparent;
            this.lblLossesName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesName.Location = new System.Drawing.Point(0, 100);
            this.lblLossesName.Name = "lblLossesName";
            this.lblLossesName.Size = new System.Drawing.Size(65, 19);
            this.lblLossesName.TabIndex = 10;
            this.lblLossesName.Text = "Losses:";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(15, 78);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(20, 19);
            this.lblWin.TabIndex = 11;
            this.lblWin.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblLosses.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(15, 119);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(20, 19);
            this.lblLosses.TabIndex = 12;
            this.lblLosses.Text = "0";
            // 
            // frmHangTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 424);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblLossesName);
            this.Controls.Add(this.lblWinName);
            this.Controls.Add(this.lblReveal);
            this.Controls.Add(this.flpLetters);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.pbHangTen);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblCText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGetWord);
            this.Controls.Add(this.mnuHangTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuHangTen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHangTen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hang Ten";
            this.Load += new System.EventHandler(this.frmHangTen_Load);
            this.mnuHangTen.ResumeLayout(false);
            this.mnuHangTen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuHangTen;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnGetWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCText;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.PictureBox pbHangTen;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.FlowLayoutPanel flpLetters;
        private System.Windows.Forms.Label lblReveal;
        private System.Windows.Forms.Label lblWinName;
        private System.Windows.Forms.Label lblLossesName;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLosses;
    }
}

