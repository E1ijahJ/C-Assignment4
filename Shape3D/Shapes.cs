namespace Shape3D;
/// <summary>
/// This is the Parent class which all the other classes derive from wuth two abstract methods
/// </summary>
public abstract class Shape
{
public string Name{get; set;} = "3D Shape";

public abstract double GetSurfaceArea();


public abstract double GetVolume();

}


