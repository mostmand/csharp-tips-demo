namespace Demo_07_OCP;

internal class PolymorphicShapePrinter : IShapePrinter
{
    private readonly IShapeFactory _shapeFactory;
    
    public PolymorphicShapePrinter(IShapeFactory shapeFactory)
    {
        _shapeFactory = shapeFactory ?? throw new ArgumentNullException(nameof(shapeFactory));
    }

    public void Print(string shapeType)
    {
        var shape = _shapeFactory.CreateShape(shapeType);
        shape.Print();
    }
}