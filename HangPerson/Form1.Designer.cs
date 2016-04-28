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
            // 
            // btnGetWord
            // 
            this.btnGetWord.Location = new System.Drawing.Point(256, 331);
            this.btnGetWord.Name = "btnGetWord";
            this.btnGetWord.Size = new System.Drawing.Size(75, 23);
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
            this.label1.Location = new System.Drawing.Point(124, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category:";
            // 
            // lblCText
            // 
            this.lblCText.AutoSize = true;
            this.lblCText.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCText.Location = new System.Drawing.Point(261, 357);
            this.lblCText.Name = "lblCText";
            this.lblCText.Size = new System.Drawing.Size(0, 27);
            this.lblCText.TabIndex = 3;
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask.Location = new System.Drawing.Point(32, 261);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(0, 50);
            this.lblMask.TabIndex = 4;
            this.lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHangTen
            // 
            this.pbHangTen.Location = new System.Drawing.Point(194, 62);
            this.pbHangTen.Name = "pbHangTen";
            this.pbHangTen.Size = new System.Drawing.Size(210, 236);
            this.pbHangTen.TabIndex = 5;
            this.pbHangTen.TabStop = false;
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(366, 331);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 23);
            this.btnNextImage.TabIndex = 6;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // flpLetters
            // 
            this.flpLetters.Location = new System.Drawing.Point(454, 62);
            this.flpLetters.Name = "flpLetters";
            this.flpLetters.Size = new System.Drawing.Size(234, 236);
            this.flpLetters.TabIndex = 7;
            // 
            // frmHangTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 424);
            this.Controls.Add(this.flpLetters);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.pbHangTen);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblCText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGetWord);
            this.Controls.Add(this.mnuHangTen);
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
    }
}

