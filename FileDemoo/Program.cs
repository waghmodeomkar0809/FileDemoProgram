using System;

namespace FileDemoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\91762\bridgelabz\FileDemoo\FileDemoo\Demo.txt";
          FIleOpration fIleOpration = new FIleOpration();
            fIleOpration.ReadFromStremReader(path);
        //}
    }
}
