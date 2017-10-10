using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment1_Apu.HelperMethods
{
    /// <summary>
    ///     Class that holds methods for assisting in creating, saving and opening files from C:\ paths.
    /// </summary>
    public class FileHelper
    {
        #region Helper methods for getting filepaths, and setting filenames correctly.

        /// <summary>
        ///     Method for getting the path to temp and creating a filename.
        /// </summary>
        /// <returns></returns>
        public string GetPath()
        {
            var path = Path.GetPathRoot(Environment.SystemDirectory);
            var fileName = $@"{path}temp\test.dat";

            return fileName;
        }

        /// <summary>
        ///     Method for getting the path to the logical drive where windows is installed.
        /// </summary>
        /// <returns></returns>
        public string GetFilePath()
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Binary Files (*.dat*)|*.dat*",
                FilterIndex = 1,
                InitialDirectory = Path.GetPathRoot(Environment.SystemDirectory)
            };

            if (fileDialog.ShowDialog() != DialogResult.OK) return null;
            var sFileName = fileDialog.FileName;
            return sFileName;
        }

        /// <summary>
        ///     Allows users to save files wherever they'd like.
        /// </summary>
        /// <returns></returns>
        public string SaveFilePath()
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "Binary Files (*.dat*)|*.dat*",
                FilterIndex = 1,
                InitialDirectory = Path.GetPathRoot(Environment.SystemDirectory)
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return null;
            var sFileName = saveDialog.FileName;
            return sFileName;
        }

        #endregion
    }
}