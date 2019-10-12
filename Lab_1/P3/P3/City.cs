using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class City
    {
        private string name;
        private double latitude; // Долгота
        private double longitude; // Широта

        // Геттер долготы
        public double getLatitude ()
        {
            return latitude;
        }

        //Геттер широты
        public double getLongitude ()
        {
            return longitude;
        }

        public string getName ()
        {
            return name;
        }
        
        // Конструктор
        public City (double latitude, double longitude, string name)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.name = name;
        }
        
    }
}
