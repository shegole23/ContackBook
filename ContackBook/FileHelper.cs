using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace ContackBook
{
    class FileHelper
    {
        // Write a text file to the app's local folder.
        public async static void WriteTextFileAsync(string filename, string content)
        {
            var storagefolder = ApplicationData.Current.LocalFolder;
            StorageFile textFile = await storagefolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);
            File.AppendAllLines(textFile.Path, new string[] { content });
            
        }
        // Read the contents of a text file from the app's local folder.
        public async static Task<string> ReadTextFileAsync(string filename)
        {
            //string content;
            var storageFolder = ApplicationData.Current.LocalFolder;
            var textFile = await storageFolder.GetFileAsync(filename);
            var textStream = await textFile.OpenReadAsync();

            var textReader = new DataReader(textStream);
            var textLength = textStream.Size;
            await textReader.LoadAsync((uint)textLength);
            return textReader.ReadString((uint)textLength);
        }
    }
}
