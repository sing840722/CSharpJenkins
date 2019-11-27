using System;

namespace CSharpJenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAppllication app = new MyAppllication();
            app.Print();
        }
    }

    class MyAppllication 
    {
        public MyAppllication() 
        {
            
        }

        public void Print() 
        {
            Console.WriteLine("Hello World!");
        }
    }
}
