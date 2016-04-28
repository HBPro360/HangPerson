using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace HangPerson
{
    public class HangTenImage
    {

        #region Private Members
        private List<Bitmap> _List;
        private int _index = 0;
        private bool _gameover = false;
        #endregion

        #region Public Properties
        public bool GameOver
        {
            get
            {
                return _gameover;
            }
        }
        #endregion

        #region  Private Methods 
        private void GetImages()
        {
            DirectoryInfo di = new DirectoryInfo("Images");
            FileInfo[] files = di.GetFiles("*.jpg");
            foreach (FileInfo fi in files)
            {
                Bitmap bmp = new Bitmap(fi.FullName);
                _List.Add(bmp);

            }
        }
        #endregion

        #region  Public Methods 
        public Bitmap GetNext()
        {
            if (_index == _List.Count)
            {
                _index = 0;
                _gameover = true;
            }
            return _List[_index++];
        }
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public HangTenImage()
        {
            _List = new List<Bitmap>();
            GetImages();
        }
        #endregion

    }
}
