using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ver_1._1
{
    [Serializable()]
    /// <summary>
    /// Represents one person
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthYear { get; set; }
        public string PhoneNumber { get; set; }        

        public BindingList<Vehicle> TakenCar { get; init; } = new BindingList<Vehicle>();

        public Person() { }

        public Person(string name, string surname, int birthYear, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            BirthYear = birthYear;
            PhoneNumber = phoneNumber;
        }


    }
}
