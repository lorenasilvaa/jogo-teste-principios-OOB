using DIO.src.Entities;

namespace DIO
{
    class Program{
        static void Main(string[] args){

            Knight hero = new Knight("Arus", 2 , "knight");
            Wizard wizard = new Wizard("Jennica", 24 , "White Wizard");
        

            Console.WriteLine(wizard.Attack());
        }
    }

}

