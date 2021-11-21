using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class ACoder : IСoder
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
                        if ((char)((c)) == 'а')
                        {
                            resutl[i] = (char)((c - 1 + 32));
                        }
                        else resutl[i] = (char)((c - 1));
                    }
                    else
                    {
                        if ((char)((c)) == 'А')
                        {
                            resutl[i] = (char)((c - 1 + 32));
                        }
                        else resutl[i] = (char)((c - 1));
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
                        if ((char)((c)) == 'a')
                        {
                            resutl[i] = (char)((c - 1 + 26));
                        }
                        else resutl[i] = (char)((c - 1));
                    }
                    else
                    {
                        if ((char)((c)) == 'A')
                        {
                            resutl[i] = (char)((c - 1 + 26));
                        }
                        else resutl[i] = (char)((c - 1));
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
                        if ((char)((c + 1)) >= 'а'+32)
                        {
                            resutl[i] = (char)((c + 1-32));
                        }
                        else resutl[i] = (char)((c + 1));
                    }
                    else
                    {
                        if ((char)((c + 1)) >= 'А' + 32)
                        {
                            resutl[i] = (char)((c + 1 - 32));
                        }
                        else resutl[i] = (char)((c + 1));
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
                        if ((char)((c + 1)) >= 'a' + 26)
                        {
                            resutl[i] = (char)((c + 1 - 26));
                        }
                        else resutl[i] = (char)((c + 1));
                    }
                    else
                    {
                        if ((char)((c + 1)) >= 'A' + 26)
                        {
                            resutl[i] = (char)((c + 1 - 26));
                        }
                        else resutl[i] = (char)((c + 1));
                    }
                }
            }
            string res = new string(resutl);
            return res;
        }
    }
}
