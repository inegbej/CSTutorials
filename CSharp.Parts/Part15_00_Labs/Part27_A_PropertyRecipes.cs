using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Student27_A
    {
        // Here we have control as to what gets into and out of this field because we are using private access modifiers
        private int _id;
        private string _name;
        private int _passMark = 35;
        

        public string Email { get; set; }    // auto implemented properties demo - with fields automatically created for us by the compiler        

        public string City { get; set; }    // auto implemented properties demo
        

        public int PassMark    // readonly Getter
        {
            get { return this._passMark; }
        }

        public string Name    // read write properties
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
                // Ternary operator demo
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }

        }

        public int Id
        {
            set
            {
                if (value <= 0)
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

    class Part27_A_PropertyRecipes
    {
        public static void Part27_A_Lab()
        {
            Console.WriteLine($"\nAuto Implemented Properties Demo\n==============");

            // 
            Student27_A C1 = new Student27_A();
            C1.Id = 101;
            C1.Name = "Mark";

            Console.WriteLine($"Student Id = {C1.Id } ");
            Console.WriteLine($"Student Name = {C1.Name } ");
            Console.WriteLine($"Student PassMark = {C1.PassMark } ");
        }
    }
}
