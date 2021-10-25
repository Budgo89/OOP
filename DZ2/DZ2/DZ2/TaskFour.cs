using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class TaskFour
    {
        private static int buildingNumber = 1;
        private int numberBuilding;
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
            buildingNumber++;
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
            numberBuilding = buildingNumber;
            buildingNumber++;
        }


        #endregion

        #region filling
        protected void NumberOfFloors(int floors)
        {
            numberOfFloors = floors;
        }

        protected void NumberOfApartments(int apertments)
        {
            numberOfApartments = apertments;
        }

        protected void NumberOfEntrances (int entrances)
        {
            numberOfEntrances = entrances;
        }

        protected void BuildingHeight(double height)
        {
            buildingHeight = height;
        }
        #endregion

        #region return
        protected int ReturnNumberOfFloors()
        {
            return numberOfFloors;
        }

        protected int ReturnNumberOfEntrances()
        {
            return numberOfEntrances;
        }

        protected int ReturnNumberOfApartments()
        {
            return numberOfApartments;
        }

        protected double ReturnBuildingHeight()
        {
            return buildingHeight;
        }

        protected int ReturnBuildingNumber()
        {
            return numberBuilding;
        }
        protected double ReturnheightOfOneFloor()
        {
            return heightOfOneFloor;
        }
        protected int ReturnNumberOfApartmentsInTheEntrance()
        {
            return numberOfApartmentsInTheEntrance;
        }
        protected int ReturnNumberOfApartmentsPerFloor()
        {
            return numberOfApartmentsPerFloor;
        }
        #endregion

        #region print
        protected void PrintNumberOfFloors()
        {
            Console.WriteLine($"Количество этажей: {numberOfFloors}");
        }

        protected void PrintNumberOfEntrances()
        {
            Console.WriteLine($"Количесто подъездов: {numberOfEntrances} ");
        }

        protected void PrintNumberOfApartments()
        {
            Console.WriteLine($"Количество квартир: {numberOfApartments}");
        }

        protected void PrintBuildingHeight()
        {
            Console.WriteLine($"Высота здания: {buildingHeight}");
        }

        protected void PrintBuildingNumber()
        {
            Console.WriteLine($"Номер здания: {numberBuilding}");
        }

        protected void PrintHeightOfOneFloor() 
        {
            Console.WriteLine($"Bысоты этажа: {heightOfOneFloor}");
        }
        protected void PrintNumberOfApartmentsInTheEntrance()
        {
            Console.WriteLine($"Количество квартир в подъезде {numberOfApartmentsInTheEntrance}");
        }

        protected void PrintNumberOfApartmentsPerFloor()
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
