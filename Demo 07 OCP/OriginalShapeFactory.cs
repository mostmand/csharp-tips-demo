using Demo_07_OCP.Shape;

namespace Demo_07_OCP;

internal class OriginalShapeFactory : IShapeFactory
{
    public IShape CreateShape(string shapeType)
    {
        return shapeType switch
        {
            "CIRCLE" => new Circle(),
            "RECTANGLE" => new Rectangle(),
            "SQUARE" => new Square(),
            _ => throw new NotSupportedException()
        };
    }
}