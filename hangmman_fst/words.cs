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
            string textFile = "wordList.txt";

            if (File.Exists(textFile))
            {
                using (StreamReader wordFile = new StreamReader(textFile))
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
}
