using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{

  public class Sphere : Shape{

    public double Radius{get; set;}
    public Sphere(double radius){
      
      Radius = radius;
    }
        public override double GetVolume()
        {
            return(4/3)* Math.PI*Math.Pow(Radius,3);
        }
        public override double GetSurfaceArea()
        {
            return 4 * Math.PI*Math.Pow(Radius,2);
        }

    }
}