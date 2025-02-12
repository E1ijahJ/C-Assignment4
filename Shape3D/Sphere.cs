using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{
/// <summary>
/// This is the sphere  class with has two functions that have specifc formulas to calculate their volume and surface area
/// </summary>
  public class Sphere : Shape{

    public double Radius{get; set;}
    public Sphere(double radius){
      
      Radius = radius;
    }
        public override double GetVolume()
        {
            return(4.0/3.0) * Math.PI* Math.Pow(Radius,3);
        }
        public override double GetSurfaceArea()
        {
            return 4 * Math.PI*Math.Pow(Radius,2);
        }

    }
}