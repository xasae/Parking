using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ver_1._1
{
    [Serializable()]
    [XmlInclude(typeof(Bus)), XmlInclude(typeof(Sedan))]
    /// <summary>
    /// Represents one vehicle
    /// </summary>
    public abstract class Vehicle
    {
        public string RegNumber { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public abstract string VehicleType { get; }

        public Vehicle() { }

        public Vehicle(string regNumber, string company, string model, int year)
        {
            RegNumber = regNumber;
            Company = company;
            Model = model;
            Year = year;
        }
    }

    [Serializable()]
    public class Bus : Vehicle
    {       
        public override string VehicleType => "Bus";
        public Bus() { }
        

    }

    [Serializable()]
    public class Sedan : Vehicle
    {        
        public override string VehicleType => "Sedan";
        public Sedan() { }

    }
}
