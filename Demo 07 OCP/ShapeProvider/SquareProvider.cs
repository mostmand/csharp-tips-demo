using Demo_07_OCP.Shape;

namespace Demo_07_OCP.ShapeProvider;

public class SquareProvider : IShapeProvider
{
    public string ShapeType => "RECTANGLE";

    public IShape CreateShape()
    {
        return new Square();
    }
}