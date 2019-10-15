using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class text
    {
       // private Stream filePath;

        public bool fileExist(string filePath) {
            return File.Exists(filePath);
        }
        public bool createFile(string filePath) {
            if (fileExist(filePath))
            {
                return false;
            }
            else
                File.Create(filePath);
            return true;
        }
        public bool writeFile(string valid, string filepath, bool returnValue = true) {
            try {
                using (StreamWriter writer = new StreamWriter(filepath, false)) {
                    writer.WriteLine(valid);
                    writer.Flush();
                    writer.Close();
                }
                returnValue = false;
            }
            catch(Exception e) {
                throw e;
            }
            return returnValue;
        }
    }
}
