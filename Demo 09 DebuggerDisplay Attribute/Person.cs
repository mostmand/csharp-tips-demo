using System.Diagnostics;

namespace Demo_09_DebuggerDisplay_Attribute;

[DebuggerDisplay("{Name}-{LastName}")]
internal class Person
{
    public string Name { get; init; }
    public string LastName { get; init; }
}