namespace csharp_vscode_test
{
  class Program
  {
    static void Main()
    {
      LocalClass.Print();
      OtherClass.Print();
    }
  }

  class LocalClass
  {
    public static void Print()
    {
      System.Console.WriteLine("LocalClass.Print()");
    }
  }
}
