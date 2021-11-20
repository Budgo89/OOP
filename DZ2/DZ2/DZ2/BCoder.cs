using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class BCoder : IСoder
    {
        public string Decode(string s)
        {
            char[] code = s.ToCharArray();
            char[] resutl = new char[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = code[i];

                if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                {
                    if (!Char.IsLetter(c))
                    {
                        resutl[i] = c;
                    }
                    else if (Char.IsLower(c))
                    {
                        int j = c - 'а';
                        resutl[i] = (char)(('а' + j));
                    }
                    else
                    {
                        int j = c - 'А';
                        resutl[i] = (char)(('А' + j));
                    }
                }
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (!Char.IsLetter(c))
                    {
                        resutl[i] = c;
                    }
                    else if (Char.IsLower(c))
                    {
                        int j = c - 'a';
                        resutl[i] = (char)(('a' + j));
                    }
                    else
                    {
                        int j = c - 'A';
                        resutl[i] = (char)(('A' + j));
                    }
                }
            }
            string res = new string(resutl);
            return res;
        }

        public string Encode(string s)
        {
            char[] code = s.ToCharArray();
            char[] resutl = new char[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = code[i];

                if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                {
                    if (!Char.IsLetter(c))
                    {
                        resutl[i] = c;
                    }
                    else if (Char.IsLower(c))
                    {
                        int j = c - 'а';
                        resutl[i] = (char)(('я' - j));
                    }
                    else
                    {
                        int j = c - 'А';
                        resutl[i] = (char)(('Я' - j));
                    }
                }
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (!Char.IsLetter(c))
                    {
                        resutl[i] = c;
                    }
                    else if (Char.IsLower(c))
                    {
                        int j = c - 'a';
                        resutl[i] = (char)(('z' - j));
                    }
                    else
                    {
                        int j = c - 'A';
                        resutl[i] = (char)(('Z' - j));
                    }
                }
            }
            string res = new string(resutl);
            return res;
        }
    }
}
