using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Item
    {
        public string Key { get; set; }
        public TaskFour Value { get; set; }
        
        public Item(string key, TaskFour value)
        {
            Key = key;
            Value = value;
        }
    }
}
