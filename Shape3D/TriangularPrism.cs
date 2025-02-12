using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{

  public class TriangularPrism : Shape{

    public double Base{get; set;}
    public double Height{get; set;}
    public double Depth{get; set;}
    public TriangularPrism(double tribase,double height,double depth){
      
      Base= tribase;
      Height=height;
      Depth =depth;
    }
        public override double GetVolume()
        {
            return .5 * Base*Height*Depth;
        }
        public override double GetSurfaceArea()
        {
          double Hypothnuse = Math.Sqrt(Math.Pow(Base,2)+Math.Pow(Height,2));
            return Base* Height + (Base*Depth)+(Height * Depth)+(Hypothnuse*Depth);
        }

    }
}