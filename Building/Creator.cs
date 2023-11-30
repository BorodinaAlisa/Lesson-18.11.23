using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Creator
    {
        static public Hashtable building_table = new Hashtable(999);
        static public Hashtable Building_table
        {
            get
            {
                return building_table;
            }
        }
        private Creator()
        {

        }
        static public Building CreateBuilding()
        {
            Building building = new Building();
            building_table.Add(building.Id, building);
            return (Building)building_table[building.Id];
        }
        static public void DeleteBuilding(uint id)
        {
            building_table.Remove(id);
        }
        static public Building GetBuilding(uint id)
        {
            return (Building)building_table[id];
        }
    }
}
