using Demo_07_OCP.ShapeProvider;

namespace Demo_07_OCP;

internal class EnhancedShapeFactory : IShapeFactory
{
    private readonly IReadOnlyDictionary<string, IShapeProvider> _providerByType = FindProviders();

    private static IReadOnlyDictionary<string, IShapeProvider> FindProviders()
    {
        return typeof(IAssemblyMarkerInterface).Assembly
            .DefinedTypes
            .Where(type => !type.IsAbstract &&
                           !type.IsInterface &&
                           typeof(IShapeProvider).IsAssignableFrom(type))
            .Select(Activator.CreateInstance)
            .Cast<IShapeProvider>()
            .ToDictionary(shapeProvider => shapeProvider.ShapeType);
    }

    public IShape CreateShape(string shapeType)
    {
        if (!_providerByType.TryGetValue(shapeType, out var shapeProvider))
        {
            throw new NotSupportedException();
        }

        return shapeProvider.CreateShape();
    }
}