using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangPerson
{
    public partial class frmHangTen : Form
    {
        CategoryHelper categories;
        Random random;
        Word word;
        HangTenImage images;
        public frmHangTen()
        {
            InitializeComponent();
        }

        private void frmHangTen_Load(object sender, EventArgs e)
        {
            MakeButtons();
            ToggleLetters(false);
            images = new HangTenImage();
            btnNextImage.PerformClick();
            btnGetWord.Enabled = false;
            random = new Random();
            categories = new CategoryHelper();
            foreach(FileInfo fi in categories.List)
            {
                string filename = Path.GetFileNameWithoutExtension(fi.FullName);
                ToolStripItem tsi = mnuCategory.DropDownItems.Add(filename);
                tsi.Click += Tsi_Click;
            }
            
        }

        private void Tsi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender; /* Alternate Way: sender as ToolStripMenuItem;*/
            if (item != null)
            {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)item.OwnerItem;
                int index = tsmi.DropDownItems.IndexOf(item);
                string filepathname = categories.List[index].FullName;
                word = new Word(filepathname, random);
            }
            btnGetWord_Click(sender, e);
            btnGetWord.Enabled = true;
            lblCText.Text = item.Text;
            
        }

        private void btnGetWord_Click(object sender, EventArgs e)
        {
            ToggleLetters(true);
            lblWord.Text = word.GetWord();
            mnuCategory.Enabled = false;
            lblMask.Text = word.Mask;
            lblReveal.Visible = false;

            images.Reset();
            btnNextImage.PerformClick();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            pbHangTen.Image = images.GetNext();
        }

        private void MakeButtons()
        {
            for(int i = 65; i <=90; i++)
            {
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Width = 20;
                btn.Height = 20;
                btn.Text = Convert.ToChar(i).ToString();
                flpLetters.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int wins = 0;// Corect This and losses
            int losses = 0;
            Button btn = sender as Button;
            btn.Enabled = false;
            //btn.Visible = false;
            string letter = btn.Text;
            bool found = false;
            int index = -1;
            do
            {
                
                index = Search(letter, this.lblWord.Text.ToUpper(), index + 1);

                if (index > -1)
                {
                    found = true;
                    lblMask.Text = lblMask.Text.Remove(index, 1);
                    lblMask.Text = lblMask.Text.Insert(index, lblWord.Text[index].ToString());
                }
            } while (index >= 0);
            if (found == false)
            {
                btnNextImage.PerformClick();
                if ( images.GameOver == true)
                {
                    
                    ToggleLetters(false);
                    lblReveal.Visible = true;
                    lblReveal.Text = lblWord.Text;
                    losses++;
                    lblLosses.Text = losses.ToString();
                    MessageBox.Show("Loser!", "You Lose");
                    mnuCategory.Enabled = true;
                    
                }
            }
            else
            {
                if (lblWord.Text == lblMask.Text)
                {
                    
                    ToggleLetters(false);
                    wins++;
                    lblWin.Text = wins.ToString();
                    MessageBox.Show("Winner!", "You Win!");
                    mnuCategory.Enabled = true;
                }
            }
        }

        private int Search(string letter, string word, int startat)
        {
            int index = word.IndexOf(letter,startat);
            return index;
        }

        private void ToggleLetters(bool toggle)
        {
            foreach(Button btn in this.flpLetters.Controls)
            {
                btn.Enabled = toggle;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
