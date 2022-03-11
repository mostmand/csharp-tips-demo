using Demo_07_OCP.Shape;

namespace Demo_07_OCP.ShapeProvider;

internal class RectangleProvider : IShapeProvider
{
    public string ShapeType => "RECTANGLE";

    public IShape CreateShape()
    {
        return new Rectangle();
    }
}