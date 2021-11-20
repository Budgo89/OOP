using System;
using System.Collections.Generic;

namespace DZ6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Armor helmetCloth = new HelmetCloth(100);
            Armor chestCloth = new ChestCloth(100);
            Armor pantsCloth = new PantsCloth(100);
            Armor helmetLeather = new HelmetLeather(150);
            Armor chestLeather = new ChestLeather(150);
            Armor pantsLeather = new PantsLeather(150);
            Armor helmetPlate = new HelmetPlate(200);
            Armor chestPlate = new ChestPlate(200);
            Armor pantsPlate = new PantsPlate(200);
            List<Armor> clothArmorSet = new List<Armor>();
            clothArmorSet.Add(helmetCloth);
            clothArmorSet.Add(chestCloth);
            clothArmorSet.Add(pantsCloth);
            List<Armor> leatherArmorSet = new List<Armor>();
            leatherArmorSet.Add(helmetLeather);
            leatherArmorSet.Add(chestLeather);
            leatherArmorSet.Add(pantsLeather);
            List<Armor> plateArmorSet = new List<Armor>();
            plateArmorSet.Add(helmetPlate);
            plateArmorSet.Add(chestPlate);
            plateArmorSet.Add(pantsPlate);


            Player playerCloth = new Player(1000, clothArmorSet);
            Player playerLeather = new Player(1000, leatherArmorSet);
            Player playerPlate = new Player(1000, plateArmorSet);
            Console.WriteLine($"Игрок в первом типе брони {playerCloth}");
            Console.WriteLine($"Игрок в втором типе брони {playerLeather}");
            Console.WriteLine($"Игрок в третьем типе брони {playerPlate}");
            Console.WriteLine("Нанесём всем игрокам по 160 единиц урона и посмотрим на результат");

            playerCloth.TakingDamage(160);
            playerLeather.TakingDamage(160);
            playerPlate.TakingDamage(160);
            Console.WriteLine($"Игрок в первом типе брони {playerCloth}");
            Console.WriteLine($"Игрок в втором типе брони {playerLeather}");
            Console.WriteLine($"Игрок в третьем типе брони {playerPlate}");

        }  
    }
}
