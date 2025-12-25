using OpenTK.Windowing.Desktop;

public class Program
{
    private static void Main(string[] args)
    {
        using(Window window = new Window(GameWindowSettings.Default, NativeWindowSettings.Default))
        {
            window.CenterWindow();
            window.Run();
        }
    }
}