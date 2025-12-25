using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

public class Window : GameWindow
{
    private static float value;
    
    public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
    {

    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        base.OnUpdateFrame(args);

        Time.Update();

        // Incrementa o valor usando deltaTime
        // Isso faz com que o valor aumente em 1 unidade por segundo
        value += 1 * Time.deltaTime;

        Console.WriteLine(value);
    }
}
