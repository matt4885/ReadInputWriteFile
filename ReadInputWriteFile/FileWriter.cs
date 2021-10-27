using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInputWriteFile
{
    public static class FileWriter
    {
        /// <summary>
        /// Writes user input to a file location. It will create the file if
        /// the file does not exist.
        /// </summary>
        /// <param name="input">User Input that will be written to the file</param>
        /// <param name="path">Path of the file</param>
        public static async void WriteToFile(string input, string path)
        {
            // Check if file already exists
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    // Write the user input to the file
                    await sw.WriteLineAsync(input);
                }
            }
            else
            {
                // Update an existing file
                using (StreamWriter sw = File.AppendText(path))
                {
                    // Write the user input to the file
                    await sw.WriteLineAsync(input);
                }
            }
        }
    }
}
