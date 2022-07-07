using DesignPattern_BuilderExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_BuilderExample
{
    public class DriveCar
    {
        public void DriveaCar(CarBuilder car)
        {
            car.CreateBrandName();
            car.CreateModelName();
            car.CreateColor();
        }
    }
}
