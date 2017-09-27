using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Apu.HelperMethods
{
    public class FileHelper
    {
        /// <summary>
        /// Method for getting the path to C:\temp\...
        /// </summary>
        /// <returns></returns>
        public string GetPath()
        {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            string fileName = $@"{path}temp\test.dat";

            return fileName;

        }

        public string GetFilePath()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.InitialDirectory = Path.GetPathRoot(Environment.SystemDirectory);

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = fileDialog.FileName;
                return sFileName;
            }

            return null;

        }
    }
}
