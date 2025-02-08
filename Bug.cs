public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized will result in a default value (0 for int)
        Console.WriteLine(MyProperty); 

        //However, if you try to use the property in a calculation before initialization it might cause unexpected behavior
        int result = MyProperty * 2; // result will be 0 * 2 = 0 
        Console.WriteLine(result);
    }
}