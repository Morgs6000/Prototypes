using OpenTK.Windowing.Desktop;

public class Program
{
    private static void Main(string[] args)
    {
        GameWindow window = new GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default);

        window.Load += delegate
        {

        };

        window.UpdateFrame += delegate
        {
            GameCursor.Update(window);

            // GameCursor.lockState = CursorLockMode.None;
            GameCursor.lockState = CursorLockMode.Locked;
            // GameCursor.lockState = CursorLockMode.Confined;
        };

        window.RenderFrame += delegate
        {
            window.SwapBuffers();
        };

        window.CenterWindow();
        window.Run();
    }
}
