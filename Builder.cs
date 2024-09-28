using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ITools//Interface to create a method for the 2 dependencies
    {
        void Work();
    }

    public class Hammer:ITools//Dependency class that inherits from interface the method Work();
    {
        public void Work(){
            Console.WriteLine("This Dependency is a Hammer function");
        }
    }

    public class Bricl : ITools
    {
        public void Work()
        {
            Console.WriteLine("This Dependency is a Brick function");
        }
    }
    internal class Builder//
    {
        private Hammer _hammer;//Private Fields from Class Hammer that stores the dependnecy
        private Bricl _bricl;

        public Builder() { 
            _hammer=new Hammer();//Dependency is initiated in constructor
            _bricl=new Bricl();
        }

        public void ToolsUse()//Method to call both dependencies Methods
        {
            _hammer.Work();
            _bricl.Work();
        }

    }
}
