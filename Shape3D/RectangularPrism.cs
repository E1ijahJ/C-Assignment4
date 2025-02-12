using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{

  public class RectangularPrism : Shape{

    public double Length{get; set;}
    public double Width{get; set;}
    public double Height{get; set;}
    public RectangularPrism(double length,double width,double height){
      
      Length = length;
      Width = width;
      Height= height;

    }
        public override double GetVolume()
        {
            return Length* Width*Height;
        }
        public override double GetSurfaceArea()
        {
            return 2*((Length*Width)+(Length * Height)+(Width*Height));
        }

    }
}