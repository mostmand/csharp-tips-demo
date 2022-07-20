using Demo_15_OneOf;

var sample = new Sample();

try
{
    var result = sample.DoAndThrowExceptionOnError();
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

sample.DoAndReturnResultOrError().Switch(result => { Console.WriteLine(result); },
    ex => { Console.WriteLine(ex); });