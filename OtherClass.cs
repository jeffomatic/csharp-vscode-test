namespace csharp_vscode_test
{
  public class OtherClass
  {
    // With Program.cs open in another tab, try modifying this function in any
    // manner that will invalidate the callsite in Program.cs. You can rename
    // it, change it to private, or just delete it. VSCode will not report any
    // problems, either inline or in the Problems pane, until Program.cs is
    // saved, or closed and re-opened.
    public static void Print()
    {
      System.Console.WriteLine("OtherClass.Print()");
    }
  }
}