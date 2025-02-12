using Shape3D.Shapes;

namespace Shape3D.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldTestSphereVolume()
    {
        Sphere sphere = new Sphere(3);
        double expectedVol =  (4.0 / 3.0) * Math.PI * Math.Pow(3, 3);
        Assert.Equal(expectedVol,sphere.GetVolume(),2);
    }

    [Fact]
    public void ShouldTestSphereSurfaceArea()
    {
        Sphere sphere = new Sphere(3);
        double expected =  4 * Math.PI * Math.Pow(3, 2);
        Assert.Equal(expected,sphere.GetSurfaceArea(),2);
    }
    [Fact]
    public void ShouldTestRectangleVolume()
    {
        RectangularPrism rectangular = new RectangularPrism(1,2,3);
        double expectedVol =  (1*2*3);
        Assert.Equal(expectedVol,rectangular.GetVolume(),2);
    }

    [Fact]
    public void ShouldTestRectangleSurfaceArea()
    {
        RectangularPrism rectangular = new RectangularPrism(1,2,3);
        double expected =  2*((1*2)+(1*3)+(2*3));
        Assert.Equal(expected,rectangular.GetSurfaceArea(),2);
    }
}

