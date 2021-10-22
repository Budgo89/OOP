using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class TaskThree
    {
        public void TaskThreeStart(string filename)
        {
            string[] fileLines = File.ReadAllLines(filename);
            foreach (var item in fileLines)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < fileLines.Length; i++)
            {
                SearchMail(ref fileLines[i]);
            }
            foreach (var item in fileLines)
            {
                Console.WriteLine(item);
            }
            File.WriteAllLines("Lesson3Task2Email.txt", fileLines);
        }

        private void SearchMail(ref string s)
        {
            string[] subs = s.Split('&');
            for (int i = 0; i < subs.Length; i++)
            {
                foreach (var item in subs[i])
                {
                    if(item == '@')
                    {
                        s = subs[i];
                    }
                }
            }
        }
    }
}
