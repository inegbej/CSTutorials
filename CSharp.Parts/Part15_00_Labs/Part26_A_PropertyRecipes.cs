using System;

namespace CSharp.Parts.Part15_00_Labs
{
    public class Student26_A
    {
        // Here we have control as to what gets into and out of this field because we are using private access modifiers
        private int _id;
        private string _name;
        private int _passMark = 35;


        public int GetPassMark()    // readonly Getter
        {
            return this._passMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = Name;
        }
        public string GetName()
        {
            // Ternary operator demo
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;

            // if else demo
            //if (string.IsNullOrEmpty(this._name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._name;
            //}
        }

        public void SetId(int Id)
        {
            if(Id <= 0)
            {
                throw new Exception("Student Id should be greater than zero");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return _id;
        }
    }

    class Part26_A_PropertyRecipes
    {
        public static void Part26_A_Lab()
        {
            Console.WriteLine($"\nUsing Getter and Setter Methods\n==============");

            // 
            Student26_A C1 = new Student26_A();
            C1.SetId(101);
            //C1.SetName("Mark");

            Console.WriteLine($"Student Id = {C1.GetId() } ");
            Console.WriteLine($"Student Name = {C1.GetName() } ");
            Console.WriteLine($"Student PassMark = {C1.GetPassMark() } ");
        }
    }
}
