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
            btnGetWord.Enabled = true;
            lblCText.Text = item.Text;
            
        }

        private void btnGetWord_Click(object sender, EventArgs e)
        {
            lblWord.Text = word.GetWord();
            mnuCategory.Enabled = false;
            lblMask.Text = word.Mask;
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
            Button btn = sender as Button;
            btn.Enabled = false;
            btn.Visible = false;
        }
    }
}
