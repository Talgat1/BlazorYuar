using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorYuar.Data
{
    public class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int YeaarRelease { get; set; }
        public string Country { get; set; }

        public Car(string name, string brand, int yeaarrelease, string country)
        {
            name = Name;
            brand = Brand;
            yeaarrelease = YeaarRelease;
            country = Country;
        }
        public Car()
        {
        }
        public static List<Car> AddCar()
        {
            List<Car> c = new List<Car>();
            c.Add(new Car() {Name = "Pontiac Aztec", Brand = "Pontiac", YeaarRelease = 1999, Country = "Канада" });
            c.Add(new Car() {Name =  "Lada (ВАЗ), Vesta I", Brand = "Lada", YeaarRelease = 2005, Country = "Россия" });
            c.Add(new Car() {Name = "Audi A8 (D5)", Brand = "Audi", YeaarRelease = 2013, Country = "Германия"});
            c.Add(new Car() {Name ="BMW M8 I (F91/F92/F93)", Brand ="BMW", YeaarRelease = 2001,Country = "Германия"});
            return c;
        }
    }
}
