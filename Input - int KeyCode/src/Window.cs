using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

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

        if (Input.GetKey("escape"))
        {
            Close();
        }

        if (Input.GetKey("w"))
        {
            Console.WriteLine("Teste");
        }
        if (Input.GetKeyDown("mouse 0"))
        {
            Console.WriteLine("Teste 2");
        }
        // if (Input.anyKeyDown)
        // {
        //     Console.WriteLine("Teste 3");
        // }
    }
}
