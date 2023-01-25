using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ver_1._1
{
    public static class Parking
    {
        public static BindingList<Person> Drivers { get; private set; } = new BindingList<Person>();
        public static BindingList<Vehicle> ParkedCars { get; private set; } = new BindingList<Vehicle>();

        static Parking()
        {            
            Drivers = DeserializeList<Person>("drivers.xml");
            ParkedCars = DeserializeList<Vehicle>("parkedCars.xml");
        }


        private static void SerializeList<T>(BindingList<T> list, string filename)
        {
            using (Stream s = File.Open(filename, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(s, list);
            }
        }

        private static BindingList<T> DeserializeList<T>(string filename)
        {
            using (Stream s = File.Open(filename, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(BindingList<T>));
                return x.Deserialize(s) as BindingList<T>;
            }
        }
        public static void Serializer()
        {
            SerializeList(Drivers, "drivers.xml");
            SerializeList(ParkedCars, "parkedCars.xml");
        }

        public static void DriveOut(object driverObj, object vehicleObj)
        {
            Person per = driverObj as Person;
            Vehicle veh = vehicleObj as Vehicle;

            per.TakenCar.Add(veh);
            ParkedCars.Remove(veh);
        }

        public static void ParkIn(object driverObj, object vehicleObj)
        {
            Person per = driverObj as Person;
            Vehicle veh = vehicleObj as Vehicle;

            ParkedCars.Add(veh);
            per.TakenCar.Remove(veh);
        }
    }
}
