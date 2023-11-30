using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Building
    {
        private static uint id_counter = 1;
        private uint id;
        public uint Id
        {
            get
            {
                return id;
            }
        }
        private double Height;
        private int Floors;
        private int Apartments;
        private int Entrances;

        internal Building(double height, int floors, int apartments, int entrances)
        {
            id = id_counter;
            id_counter++;
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;

        }

        internal Building()
        {
            id = id_counter;
            id_counter++;
        }
        public double GetHeight()
        {
            return Height;
        }
        public int GetFloors()
        {
            return Floors;
        }
        public int GetApartments()
        {
            return Apartments;
        }
        public int GetEntrances()
        {
            return Entrances;
        }
        public int GetApartmentsOnFloor()
        {
            return Apartments / Floors;
        }
        public int GetApartmentsInEntrance()
        {
            return Apartments / Entrances;
        }
        public double GetFloorHeight()
        {
            return Height / Floors;
        }

        public override string ToString()
        {
            return ($"Номер здания:{id}, высота:{Height}, этажность:{Floors}, количество квартир:{Apartments}, количество подъездов:{Entrances}");
        }
    }
}
