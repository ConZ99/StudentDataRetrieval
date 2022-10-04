class ReadFromFile
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText(@"C:\Users\stefan_lica\OneDrive - Dell Technologies\Desktop\FSD\InitSetup\HelloWorld.txt");

        System.Console.WriteLine(text);

        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}