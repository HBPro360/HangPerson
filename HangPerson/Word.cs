using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangPerson
{
    public class Word
    {

        #region Private Members
        private List<string> _List;
        private Random _rng;
        private string _mask;
        #endregion

        #region Public Properties
        public string Mask
        {
            get
            {
                return _mask;
            }
        }
        #endregion

        #region  Private Methods 
        private void GetWords(string filepathname)
        {
            try
            {
                if (File.Exists(filepathname))
                {
                    using (StreamReader sr = new StreamReader(filepathname))
                    {
                        string line = string.Empty;
                        while (sr.Peek() >= 0)
                        {
                            line = sr.ReadLine();
                            _List.Add(line);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void BuildMask(string word)
        {
            _mask = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                _mask += "-";
            }
        }
        #endregion

        #region  Public Methods 
        public string GetWord()
        {
            int index = _rng.Next(0, _List.Count);
            BuildMask(_List[index]);
            return _List[index];
        }
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public Word(string filepathname, Random rng)
        {
            _List = new List<string>();
            GetWords(filepathname);
            _rng = rng;
        }
        #endregion

    }
}
