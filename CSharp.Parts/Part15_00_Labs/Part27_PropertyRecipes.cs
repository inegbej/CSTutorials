using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Student27
    {
        private int _id;
        private string _name;
        private int _passMark = 35;


        public int PassMark    
        {
            get { return this._passMark;  }            
        }

        public string Name    
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
            
        }
        
        public int Id
        {
            set
            {
                if (value <= 0)         // "value" is a built in keyword that will receive the value from the caller
                {
                    throw new Exception("Student Id should be greater than zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
           
        }
        
    }


    class Part27_PropertyRecipes
    {
        public static void Part27_Lab()
        {
            Console.WriteLine($"\nProperties Demo\n==============");

            // 
            Student27 C1 = new Student27();
            C1.Id = 101;
            C1.Name = "Mark";

            Console.WriteLine($"Student Id = {C1.Id } ");
            Console.WriteLine($"Student Name = {C1.Name } ");
            Console.WriteLine($"Student PassMark = {C1.PassMark } ");
        }
    }
}
