using Demo_07_OCP.Shape;

namespace Demo_07_OCP.ShapeProvider;

internal class CircleProvider : IShapeProvider
{
    public string ShapeType => "CIRCLE";

    public IShape CreateShape()
    {
        return new Circle();
    }
}