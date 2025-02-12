using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{

  public class Cube : RectangularPrism{

    public double Side{get;}
    public Cube(double side): base(side,side,side){
      
      Side = side;
    }
        public override double GetVolume()
        {
            return Math.Pow(Side,3);
        }
        public override double GetSurfaceArea()
        {
            return 6* Math.Pow(Side,2);
        }

    }
}