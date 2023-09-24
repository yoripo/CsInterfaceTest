using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsInterfaceTest
{
    public class Motorcycle : IVehicle
    {
        private string name;

        public Motorcycle(string name)
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
            System.Console.WriteLine($"{GetName()} is moving on 2 wheels with an engine.");
        }
    }
}
