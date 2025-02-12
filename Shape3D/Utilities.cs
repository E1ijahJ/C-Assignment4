using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{

public class Utilities{

public static string Details(Shape shape){

return("My"+shape+"surface area is"+shape.GetSurfaceArea()+"and its volume is "+shape.GetVolume());
}

public static double Diagonal(RectangularPrism rectangular){

  return Math.Sqrt(Math.Pow(rectangular.Length,2)+Math.Pow(rectangular.Height,2)+Math.Pow(rectangular.Width,2));
}

public static Cube NewCube(Cube cube){

  double newside= Math.Sqrt((cube.Side*cube.Side)/6);
  Cube BrandnewCube = new Cube(newside);


  return BrandnewCube;
}
}





}