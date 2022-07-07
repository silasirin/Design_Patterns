using DesignPattern_BuilderExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_BuilderExample.Concrete
{
    public class MercedesConcrete : CarBuilder
    {
        public MercedesConcrete()
        {
            car = new Car();
        }
        public override void CreateBrandName()
        {
            car.BrandName="Mercedes";
        }

        public override void CreateModelName()
        {
            car.ModelName="Sedan";
        }

        public override void CreateColor()
        {
            car.Color="Red";
        }
    }
}
