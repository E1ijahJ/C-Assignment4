using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D.Shapes{
/// <summary>
/// This is the Util class  with 3 mehtods that one give detaisl of a shape, two get the digognal woht calculation and 3 be able to create a smlaler new variant based off the orignal cubes side
/// </summary>
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