namespace Demo_07_OCP;

internal interface IShapeFactory
{
    IShape CreateShape(string shapeType);
}