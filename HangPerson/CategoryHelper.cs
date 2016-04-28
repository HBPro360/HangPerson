using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangPerson
{
    public class CategoryHelper
    {

        #region Private Members
        private List<FileInfo> _List;
        private int index = 0;
        #endregion

        #region Public Properties
        public List<FileInfo> List
        {
            get { return _List; }
        }
        #endregion

        #region  Private Methods 
        private void getCategories()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo("WordBank");
                FileInfo[] files = di.GetFiles("*.txt");
                foreach (FileInfo fi in files)
                {
                    _List.Add(fi);
                }
            }
            catch
            {
                //Throw the error back to the caller
                throw;
            }

        }
        #endregion

        #region  Public Methods 
        
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public CategoryHelper()
        {
            _List = new List<FileInfo>();
            getCategories();
        }
        #endregion

    }
}
