using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Apu.Serializers
{
    /// <summary>
    /// A class that holds methods for reading and writing to and from Binary files.
    /// </summary>
    public class Binary
    {
        public static string WriteToBinaryFile(Object obj, string filePath)
        {
            FileStream fileStream = null;
            string errorMsg = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fileStream, obj);
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            return errorMsg; 
        }

        public static T ReadFromBinaryFile<T>(string filePath, out string errorMessage)
        {
            FileStream fileStream = null;
            errorMessage = null;
            Object obj = null;
            try
            {
                if (!File.Exists(filePath))
                {
                    errorMessage = $"The file {filePath} was not found.";
                    throw (new FileNotFoundException(errorMessage));
                }

                fileStream = new FileStream(filePath, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                obj = bf.Deserialize(fileStream);
            }
            catch (Exception e)
            {
                if (errorMessage != null)
                    errorMessage = e.Message;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            return (T)obj;
        }
    }
}