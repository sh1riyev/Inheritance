using System;
namespace Class_Inheritance_Classwork
{
	public class Animal
	{
		public int id;
		public string name;
       
        public void Sound()
        {
            Console.WriteLine("Animal Sound");
        }

        public Animal(string text)
        {
            Console.WriteLine(text);
        }
    }

	
}

