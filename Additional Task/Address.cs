using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_
{
    class Address
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;
        //------------------------------------

        public Address() { }

        public Address(int index, string country, string city, 
            string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }
        //-----------------------------------------------------------

        public int Index
        {
            get { return index; }
            set { this.index = value; }
        
        }
        //-----------------------------------------------------------

        public string Country
        {
            get { return country; }
            set { this.country = value; }
        }
        //-----------------------------------------------------------

        public string City
        {
            get { return city; }
            set { this.city = value; }
        }
        //-----------------------------------------------------------

        public string Street
        {
            get { return street; }
            set { this.street = value; }
        }
        //-----------------------------------------------------------

        public int House
        {
            get { return house; }
            set { this.house = value; }
        }
        //-----------------------------------------------------------

        public int Apartment
        {
            get { return apartment; }
            set { this.apartment = value; }
        }
        //-----------------------------------------------------------

        public void ShowAddress()
        {
            Console.WriteLine(Index);
            Console.WriteLine(Country);
            Console.WriteLine(City);
            Console.WriteLine(Street);
            Console.WriteLine(House);
            Console.WriteLine(Apartment);
        }
    }
}
