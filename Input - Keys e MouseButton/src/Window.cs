using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

public class Window : GameWindow
{
    public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
    {

    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        base.OnUpdateFrame(args);

        Time.Update();
        Input.Update(this);

        if (Input.GetKey(Keys.Escape))
        {
            Close();
        }

        if (Input.GetKeyDouble(Keys.W))
        {
            Console.WriteLine("Teste");
        }
        if (Input.GetMouseButtonDouble(MouseButton.Button1))
        {
            Console.WriteLine("Teste 2");
        }
    }
}
