using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemoo
{
    public class FIleOpration
    {
        public void ReadFromStremReader(string path)
        {
            using(StreamReader sr =File.OpenText(path))
            {
                string s = "";
                while((s= sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
