public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before using it in calculations
        MyProperty = 10; 

        Console.WriteLine(MyProperty); // Output: 10

        int result = MyProperty * 2; // result will be 10 * 2 = 20
        Console.WriteLine(result); // Output: 20
    }
}