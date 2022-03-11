namespace Demo_07_OCP;

internal class SimpleShapePrinter : IShapePrinter
{
    public void Print(string shapeType)
    {
        switch (shapeType)
        {
            case "CIRCLE":
                Console.WriteLine("Circle");
                return;
            case "RECTANGLE":
                Console.WriteLine("Rectangle");
                return;
            case "SQUARE":
                Console.WriteLine("Square");
                return;
            default:
                throw new NotSupportedException();
        }
    }
}