using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Creator : TaskFour
    {
        private static HashTable hashTable = new HashTable();
        private static int key = 1;

        internal Creator()
        {

        }

        public static void CreateBuild()
        {
            TaskFour building = new TaskFour();
            hashTable.Insert(Convert.ToString(key), building);
            key++;
        }

        public static void CreateBuild(int floors, int apartments, int entrances, double height)
        {
            TaskFour building = new TaskFour(floors, apartments, entrances, height);
            hashTable.Insert(Convert.ToString(key), building);
            key++;
        }

        public static void Print(int i)
        {
            var building = hashTable.Search(Convert.ToString(i));
                building.PrintBuilding();
        }

        public static void Delete(int i)
        {
            hashTable.Delete(Convert.ToString(i));
        }

    }
}
