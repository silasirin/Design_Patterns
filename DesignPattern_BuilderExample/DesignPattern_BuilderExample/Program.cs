using DesignPattern_BuilderExample.Abstract;
using DesignPattern_BuilderExample.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_BuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Islem Sirasi:
            1- kredi karti nesnesi
            2- kredi karti builder
            3- 3 adet kredi karti tanimlandi
            4- kartKullan isminde yeni bir nesne tanimlandi.
            */

            CarBuilder theCar = new MercedesConcrete(); //Liskov Subsistution Principle

            DriveCar drive = new DriveCar();

            theCar = new AudiConcrete();
            drive.DriveaCar(theCar);

            Console.WriteLine(theCar.Car.ToString());

            Console.Read();
        }
    }
}
