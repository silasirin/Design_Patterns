using DesignPattern_BuilderExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_BuilderExample.Concrete
{
    public class BMWConcrete : CarBuilder
    {
        public BMWConcrete()
        {
            car = new Car();
        }
        public override void CreateBrandName()
        {
            car.BrandName="BMW";
        }

        public override void CreateModelName()
        {
            car.ModelName= "Gran Coupé";
        }

        public override void CreateColor()
        {
            car.Color="White";
        }
    }
}
