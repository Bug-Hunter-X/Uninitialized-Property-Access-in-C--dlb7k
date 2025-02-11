public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized yet
        int value = MyProperty * 2; // potential null reference exception
        Console.WriteLine(value);
    }
}