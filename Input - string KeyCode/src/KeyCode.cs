using OpenTK.Windowing.GraphicsLibraryFramework;

/// <summary>
/// O código a ser usado para identificar a entrada. Esses códigos correspondem diretamente a uma tecla física no teclado ou a teclas específicas do idioma.
/// </summary>
public static class KeyCode
{
    public static Dictionary<string, object> keys = new Dictionary<string, object>()
    {
        { "none", Keys.Unknown },
        { "backspace", Keys.Backspace },
        { "delete", Keys.Delete },
        { "tab", Keys.Tab },
        // { "clear", Keys. },
        { "return", Keys.Enter },
        { "pause", Keys.Pause },
        { "escape", Keys.Escape },
        { "space", Keys.Space },
        
        // Teclado numérico
        { "[0]", Keys.KeyPad0 },
        { "[1]", Keys.KeyPad1 },
        { "[2]", Keys.KeyPad2 },
        { "[3]", Keys.KeyPad3 },
        { "[4]", Keys.KeyPad4 },
        { "[5]", Keys.KeyPad5 },
        { "[6]", Keys.KeyPad6 },
        { "[7]", Keys.KeyPad7 },
        { "[8]", Keys.KeyPad8 },
        { "[9]", Keys.KeyPad9 },
        { "[.]", Keys.KeyPadDecimal },
        { "[/]", Keys.KeyPadDivide },
        { "[*]", Keys.KeyPadMultiply },
        { "[-]", Keys.KeyPadSubtract },
        { "[+]", Keys.KeyPadAdd },
        { "enter", Keys.KeyPadEnter },
        
        // Setas
        { "up", Keys.Up },
        { "down", Keys.Down },
        { "right", Keys.Right },
        { "left", Keys.Left },
        
        // Navegação
        { "insert", Keys.Insert },
        { "home", Keys.Home },
        { "end", Keys.End },
        { "page up", Keys.PageUp },
        { "page down", Keys.PageDown },
        
        // Teclas de função
        { "f1", Keys.F1 },
        { "f2", Keys.F2 },
        { "f3", Keys.F3 },
        { "f4", Keys.F4 },
        { "f5", Keys.F5 },
        { "f6", Keys.F6 },
        { "f7", Keys.F7 },
        { "f8", Keys.F8 },
        { "f9", Keys.F9 },
        { "f10", Keys.F10 },
        { "f11", Keys.F11 },
        { "f12", Keys.F12 },
        
        // Números alfanuméricos
        { "0", Keys.D0 },
        { "1", Keys.D1 },
        { "2", Keys.D2 },
        { "3", Keys.D3 },
        { "4", Keys.D4 },
        { "5", Keys.D5 },
        { "6", Keys.D6 },
        { "7", Keys.D7 },
        { "8", Keys.D8 },
        { "9", Keys.D9 },
        
        // Pontuação
        { "'", Keys.Apostrophe },
        { ",", Keys.Comma },
        { "-", Keys.Minus },
        { ".", Keys.Period },
        { "/", Keys.Slash },
        { ";", Keys.Semicolon },
        { "=", Keys.Equal },
        { "[", Keys.LeftBracket },
        { "\\", Keys.Backslash },
        { "]", Keys.RightBracket },
        { "`", Keys.GraveAccent },
        
        // Letras (a-z)
        { "a", Keys.A },
        { "b", Keys.B },
        { "c", Keys.C },
        { "d", Keys.D },
        { "e", Keys.E },
        { "f", Keys.F },
        { "g", Keys.G },
        { "h", Keys.H },
        { "i", Keys.I },
        { "j", Keys.J },
        { "k", Keys.K },
        { "l", Keys.L },
        { "m", Keys.M },
        { "n", Keys.N },
        { "o", Keys.O },
        { "p", Keys.P },
        { "q", Keys.Q },
        { "r", Keys.R },
        { "s", Keys.S },
        { "t", Keys.T },
        { "u", Keys.U },
        { "v", Keys.V },
        { "w", Keys.W },
        { "x", Keys.X },
        { "y", Keys.Y },
        { "z", Keys.Z },
        
        // Teclas de controle
        { "num lock", Keys.NumLock },
        { "caps lock", Keys.CapsLock },
        { "scroll lock", Keys.ScrollLock },
        { "right shift", Keys.RightShift },
        { "left shift", Keys.LeftShift },
        { "right control", Keys.RightControl },
        { "left control", Keys.LeftControl },
        { "right alt", Keys.RightAlt },
        { "left alt", Keys.LeftAlt },
        { "left meta", Keys.LeftSuper },
        { "right meta", Keys.RightSuper },
        { "print", Keys.PrintScreen },
        { "menu", Keys.Menu },

        // Botões do mouse
        { "mouse 0", MouseButton.Button1 },
        { "mouse 1", MouseButton.Button2 },
        { "mouse 2", MouseButton.Button3 },
    };
}
