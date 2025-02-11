public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        int value = MyProperty * 2;
        Console.WriteLine(value);
    }
}
//Alternative solution:
public class ExampleClass
{
    private int? _myProperty; //Use nullable type

    public int? MyProperty
    {
        get => _myProperty;
        set => _myProperty = value;
    }
    public void MyMethod()
    {
        int value = _myProperty.HasValue ? _myProperty.Value * 2 : 0; //Handle null case
        Console.WriteLine(value);
    }
}