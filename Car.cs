using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsInterfaceTest
{
    public class Car : IVehicle
    {
        private string name;

        public Car(string name)
        {
            SetName(name);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            if (name == null || name.Length == 0)
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            this.name = name;
        }

        public void Move()
        {
            System.Console.WriteLine($"{GetName()} is moving on 4 wheels.");
        }
    }
}
