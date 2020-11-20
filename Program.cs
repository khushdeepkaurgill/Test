using System;
using System.Collections.Generic;

namespace Demo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Human[] humanList = new Human[] { new Adult(), new Child() };

            foreach (Human h in humanList)
            {
                Console.WriteLine(h.FirstName + h.LastName);
            }
        }
    }

    public class Human
    {
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
    }

    public class Adult : Human
    {
        public override String FirstName { get; set; }
        public override String LastName { get; set; }

       public Adult()
        {
            FirstName = "Tom";
            LastName = "Doe";
        }
    }

    public class Child : Human
    {
        public override String FirstName { get; set; }
        public override String LastName { get; set; }

        public Child() {
            FirstName = "Jerry";
            LastName = "Craig";
        }
    }
}
