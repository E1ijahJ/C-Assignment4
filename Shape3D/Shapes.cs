namespace Shape3D;

public abstract class Shape
{
public string Name{get; set;} = "3D Shape";

public abstract double GetSurfaceArea();


public abstract double GetVolume();

}


