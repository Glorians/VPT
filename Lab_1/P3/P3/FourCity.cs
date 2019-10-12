using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FourCity
    {

        // Данные GPS

        //KIEV
        private const Double kievLatitude = 50.45;
        private const Double kievLongitude = 30.52;

        //ODESA
        private const Double odesaLatitude = 46.48;
        private const Double odesaLongitude = 30.73;

        //LVIV
        private const Double lvivLatitude = 49.84;
        private const Double lvivLongitude = 24.03;

        //KHARKIV
        private const Double kharkivLatitude = 49.99;
        private const Double kharkivLongitude = 36.23;

        

        static void Main(string[] args)
        {
            City kiev = new City(kievLatitude, kievLongitude, "Киев"); // Киев
            City odesa = new City(odesaLatitude, odesaLongitude, "Одесса"); // Одесса
            City lviv = new City(lvivLatitude, lvivLongitude, "Львов");    // Львов
            City kharkiv = new City(kharkivLatitude, kharkivLongitude, "Харьков"); // Харьков

            double s1, s2, s3, s4, s5; // Дистанция между городами

            s1 = distanceTwoCities(kiev, lviv); // Сторона №1
            s2 = distanceTwoCities(lviv, odesa); // Сторона №2
            s3 = distanceTwoCities(odesa, kharkiv); // Сторонна №3
            s4 = distanceTwoCities(kharkiv, kiev); // Сторона №4
            s5 = distanceTwoCities(kiev, odesa); // Сторона №5 (посередине)

            double triangle1 = spaceTriangle(s1, s2, s5); // площядь 1 треугольника
            double tirangle2 = spaceTriangle(s3, s4, s5); // площядь 2 треугольника

            double result = Math.Round(triangle1 + tirangle2); //    РЕЗУЛЬТАТ

            Console.WriteLine($"Площя чотирикутника: {result}км^2");
            Console.ReadKey();
            

        }


        // Метод для нахождения расстояния между городами
        public static double distanceTwoCities (City city1, City city2)
        {
            double R = 6371.01; // Радиус Земли

            double x1 = city1.getLatitude() * (3.14 / 180); // Широта 1 города в радианах
            double x2 = city2.getLatitude() * (3.14 / 180); // Широта 2 города в радианах

            double y1 = city1.getLongitude() * (3.14 / 180); // Долгота 1 города в радианах
            double y2 = city2.getLongitude() * (3.14 / 180); // Долгота 2 города в радианах

            // Результат по формуле
            double result = (int) R * Math.Acos( 
                
                (Math.Sin(x1) * Math.Sin(x2)) +
                (Math.Cos(x1) * Math.Cos(x2)) *
                Math.Cos(y1 - y2)
                
                );
            result = Math.Round(result, 2);
            Console.WriteLine("от " + city1.getName() + " до " + city2.getName() + $" {result}км");
            return result; // Возвращаем результат
        }

        
        public static double spaceTriangle (double a, double b, double c)
        {
            double p = (a + b + c) / 2; //  Полупериметр треугольника 

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Площя треульника
            S = Math.Round(S, 2);
            return S; // Возвращаем площю
        }
    }
}
