using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment1_Apu.Serializers
{
    /// <summary>
    ///     A class that holds methods for reading and writing to and from Binary files.
    /// </summary>
    public class Binary
    {
        /// <summary>
        ///     Method that writes object data to a binary file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="objectToWrite"></param>
        /// <param name="append"></param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        ///     Method that reads from a binary file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                return (T) binaryFormatter.Deserialize(stream);
            }
        }
    }
}