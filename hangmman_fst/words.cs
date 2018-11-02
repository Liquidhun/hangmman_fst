using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmman_fst
{
    class Words
    {
        public Words() { }

        static void readFile()
        {
            using (StreamReader wordFile = new StreamReader("wordList.txt"))
            {
                while (!wordFile.EndOfStream)
                {
                    string line = wordFile.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        
    }
}
