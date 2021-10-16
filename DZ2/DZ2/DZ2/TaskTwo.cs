using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class TaskTwo
    {
        public string Flipper(string _string)
        {
            char[] arr = _string.ToCharArray();
            // Уверен что это не то, что вы хотели увидеть
            //Array.Reverse(arr);
            //return new string(arr);

            string n = "";
            for (int i = arr.Length-1; i >=0; i--)
            {
                n += arr[i];
            }
            return n;
        }
    }
}
