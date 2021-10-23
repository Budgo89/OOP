using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class TaskFour
    {
        private static int buildingNumber = 1;
        private double buildingHeight;
        private int numberOfFloors;
        private int numberOfApartments;
        private int numberOfEntrances;
        private double heightOfOneFloor;
        private int numberOfApartmentsInTheEntrance;
        private int numberOfApartmentsPerFloor;

        #region constructors
        public TaskFour()
        {

        }
        public TaskFour(int floors, int apartments, int entrances, double height)
        {
            numberOfFloors = floors;
            numberOfApartments = apartments;
            numberOfEntrances = entrances;
            buildingHeight = height;
            heightOfOneFloor = HeightOfOneFloor();
            numberOfApartmentsInTheEntrance = NumberOfApartmentsInTheEntrance();
            numberOfApartmentsPerFloor = NumberOfApartmentsPerFloor();
        }


        #endregion

        #region filling
        public void NumberOfFloors(int floors)
        {
            numberOfFloors = floors;
        }

        public void NumberOfApartments(int apertments)
        {
            numberOfApartments = apertments;
        }

        public void NumberOfEntrances (int entrances)
        {
            numberOfEntrances = entrances;
        }

        public void BuildingHeight(double height)
        {
            buildingHeight = height;
        }
        #endregion

        #region return
        public int ReturnNumberOfFloors()
        {
            return numberOfFloors;
        }

        public int ReturnNumberOfEntrances()
        {
            return numberOfEntrances;
        }

        public int ReturnNumberOfApartments()
        {
            return numberOfApartments;
        }

        public double ReturnBuildingHeight()
        {
            return buildingHeight;
        }

        public int ReturnBuildingNumber()
        {
            return buildingNumber;
        }
        public double ReturnheightOfOneFloor()
        {
            return heightOfOneFloor;
        }
        public int ReturnNumberOfApartmentsInTheEntrance()
        {
            return numberOfApartmentsInTheEntrance;
        }
        public int ReturnNumberOfApartmentsPerFloor()
        {
            return numberOfApartmentsPerFloor;
        }
        #endregion

        #region print
        public void PrintNumberOfFloors()
        {
            Console.WriteLine($"Количество этажей: {numberOfFloors}");
        }

        public void PrintNumberOfEntrances()
        {
            Console.WriteLine($"Количесто подъездов: {numberOfEntrances} ");
        }

        public void PrintNumberOfApartments()
        {
            Console.WriteLine($"Количество квартир: {numberOfApartments}");
        }

        public void PrintBuildingHeight()
        {
            Console.WriteLine($"Высота здания: {buildingHeight}");
        }

        public void PrintBuildingNumber()
        {
            Console.WriteLine($"Номер здания: {buildingNumber}");
        }

        public void PrintHeightOfOneFloor() 
        {
            Console.WriteLine($"Bысоты этажа: {heightOfOneFloor}");
        }
        public void PrintNumberOfApartmentsInTheEntrance()
        {
            Console.WriteLine($"Количество квартир в подъезде {numberOfApartmentsInTheEntrance}");
        }

        public void PrintNumberOfApartmentsPerFloor()
        {
            Console.WriteLine($"Количество квартир на этаже: {numberOfApartmentsPerFloor}");
        }

        public void PrintBuilding()
        {
            PrintBuildingNumber();
            PrintBuildingHeight();
            PrintNumberOfFloors();
            PrintNumberOfApartments();
            PrintNumberOfEntrances();
            PrintHeightOfOneFloor();
            PrintNumberOfApartmentsInTheEntrance();
            PrintNumberOfApartmentsPerFloor();
        }
        #endregion

        #region calculations

        private double HeightOfOneFloor()
        {
            return buildingHeight / numberOfFloors;
        }

        private int NumberOfApartmentsInTheEntrance()
        {
            return numberOfApartments / numberOfEntrances;
        }

        private int NumberOfApartmentsPerFloor()
        {
            return numberOfApartmentsInTheEntrance / numberOfFloors;
        }

        #endregion
    }
}
