namespace Demo_11_Empty_Collections;

public class Samples
{
    public List<int> NewList()
    {
        return new List<int>();
    }
    
    public IEnumerable<int> EnumerableEmpty()
    {
        return Enumerable.Empty<int>();
    }
    
    public int[] NewArray()
    {
        return new int[] { };
    }
    
    public int[] ArrayEmpty()
    {
        return Array.Empty<int>();
    }
}