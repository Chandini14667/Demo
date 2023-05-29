using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice
{
    public class FileReader : IFileReader
    {
        public string ReadText()
        {
            return File.ReadAllText("C:\\Users\\cshaik5\\OneDrive - DXC Production\\Desktop\\DTraining\\File");
        }
    }
}
