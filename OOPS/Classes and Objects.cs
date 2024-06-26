﻿using System.Drawing;

namespace OOPS
{
    internal class Classes_and_Objects
    {
        // private Member variable / fields
        private string _name; // private field typically used for storing data
        private int _hp;
        private string _color;

        // the public Properties
        public string Name { 
            get { return _name; } // get accessor
            set { if(value == "")
                { _name = "DefaultName is Audi V3"; }
                else { _name = value; } } // set accessor
        } 

        /*  public string GetName() // getter
          {
              return _name;
          }
          public void SetName(string name) // setter
          {
              if(name == "")
              {
                  _name = "DefaultName";
              }
              else
              {
                  _name = name;
              }
          }
        */
        /// <summary>
        /// Different type of constructors
        /// </summary>
        // 1. Default constructor
        public Classes_and_Objects()
        {
            _name = "Car";
            _hp = 0;
            _color = "black";
            Drive();
        }
        // 2. Partial specification constructor
        public Classes_and_Objects(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + "was created");
            _hp = hp;
            _color = "black";
        }
        // 3. Full Specification constructor
        public Classes_and_Objects(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
        }

        // Member methods
        public void Drive()
        {
            Console.WriteLine(_name + " is moving");
        }
        public void stop()
        {
            Console.WriteLine(_name + " has stopped");
        }
        public void Details()
        {
            Console.WriteLine("The " + _color + " car " + _name + "has" + _hp + " Horse power");
        }
    }
}
