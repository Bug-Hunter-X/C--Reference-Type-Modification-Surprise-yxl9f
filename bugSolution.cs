public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public ExampleClass Clone() //Added Clone Method
    {
        return new ExampleClass(this.MyProperty);
    }

    public static void Main(string[] args)
    {
        ExampleClass instance1 = new ExampleClass(10);
        ExampleClass instance2 = instance1.Clone(); // Create a copy instead of a reference

        instance2.MyProperty = 20;

        Console.WriteLine(instance1.MyProperty); // Output: 10
        Console.WriteLine(instance2.MyProperty); // Output: 20
    }
}