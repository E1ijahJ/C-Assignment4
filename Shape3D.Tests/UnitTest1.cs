using Shape3D.Shapes;

namespace Shape3D.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldCreateASphereObject()
    {
        Sphere sphere = new Sphere(3);
        Console.WriteLine(sphere.GetSurfaceArea()+"and the"+ sphere.GetVolume());
    }
}
