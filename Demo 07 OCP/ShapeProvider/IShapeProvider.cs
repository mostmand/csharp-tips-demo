namespace Demo_07_OCP.ShapeProvider;

internal interface IShapeProvider
{
    string ShapeType { get; }
    IShape CreateShape();
}