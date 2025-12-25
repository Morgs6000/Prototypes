using OpenTK.Windowing.GraphicsLibraryFramework;

/// <summary>
/// O código a ser usado para identificar a entrada. Esses códigos correspondem diretamente a uma tecla física no teclado ou a teclas específicas do idioma.
/// </summary>
public static class KeyCode
{
    public static Dictionary<int, object> keys = new Dictionary<int, object>()
    {
        { -1, Keys.Unknown },
        { 259, Keys.Backspace },
        { 261, Keys.Delete },
        { 258, Keys.Tab },
        // { "clear", Keys. },
        { 257, Keys.Enter },
        { 284, Keys.Pause },
        { 256, Keys.Escape },
        { 32, Keys.Space },
        
        // Teclado numérico
        { 320, Keys.KeyPad0 },
        { 321, Keys.KeyPad1 },
        { 322, Keys.KeyPad2 },
        { 323, Keys.KeyPad3 },
        { 324, Keys.KeyPad4 },
        { 325, Keys.KeyPad5 },
        { 326, Keys.KeyPad6 },
        { 327, Keys.KeyPad7 },
        { 328, Keys.KeyPad8 },
        { 329, Keys.KeyPad9 },
        { 330, Keys.KeyPadDecimal },
        { 331, Keys.KeyPadDivide },
        { 332, Keys.KeyPadMultiply },
        { 333, Keys.KeyPadSubtract },
        { 334, Keys.KeyPadAdd },
        { 335, Keys.KeyPadEnter },
        
        // Setas
        { 265, Keys.Up },
        { 264, Keys.Down },
        { 262, Keys.Right },
        { 263, Keys.Left },
        
        // Navegação
        { 260, Keys.Insert },
        { 268, Keys.Home },
        { 269, Keys.End },
        { 266, Keys.PageUp },
        { 267, Keys.PageDown },
        
        // Teclas de função
        { 290, Keys.F1 },
        { 291, Keys.F2 },
        { 292, Keys.F3 },
        { 293, Keys.F4 },
        { 294, Keys.F5 },
        { 295, Keys.F6 },
        { 296, Keys.F7 },
        { 297, Keys.F8 },
        { 298, Keys.F9 },
        { 299, Keys.F10 },
        { 300, Keys.F11 },
        { 301, Keys.F12 },
        
        // Números alfanuméricos
        { 48, Keys.D0 },
        { 49, Keys.D1 },
        { 50, Keys.D2 },
        { 51, Keys.D3 },
        { 52, Keys.D4 },
        { 53, Keys.D5 },
        { 54, Keys.D6 },
        { 55, Keys.D7 },
        { 56, Keys.D8 },
        { 57, Keys.D9 },
        
        // Pontuação
        { 39, Keys.Apostrophe },
        { 44, Keys.Comma },
        { 45, Keys.Minus },
        { 46, Keys.Period },
        { 47, Keys.Slash },
        { 59, Keys.Semicolon },
        { 61, Keys.Equal },
        { 91, Keys.LeftBracket },
        { 92, Keys.Backslash },
        { 93, Keys.RightBracket },
        { 96, Keys.GraveAccent },
        
        // Letras (a-z)
        { 65, Keys.A },
        { 66, Keys.B },
        { 67, Keys.C },
        { 68, Keys.D },
        { 69, Keys.E },
        { 70, Keys.F },
        { 71, Keys.G },
        { 72, Keys.H },
        { 73, Keys.I },
        { 74, Keys.J },
        { 75, Keys.K },
        { 76, Keys.L },
        { 77, Keys.M },
        { 78, Keys.N },
        { 79, Keys.O },
        { 80, Keys.P },
        { 81, Keys.Q },
        { 82, Keys.R },
        { 83, Keys.S },
        { 84, Keys.T },
        { 85, Keys.U },
        { 86, Keys.V },
        { 87, Keys.W },
        { 88, Keys.X },
        { 89, Keys.Y },
        { 90, Keys.Z },
        
        // Teclas de controle
        { 282, Keys.NumLock },
        { 280, Keys.CapsLock },
        { 281, Keys.ScrollLock },
        { 344, Keys.RightShift },
        { 340, Keys.LeftShift },
        { 345, Keys.RightControl },
        { 341, Keys.LeftControl },
        { 346, Keys.RightAlt },
        { 342, Keys.LeftAlt },
        { 343, Keys.LeftSuper },
        { 347, Keys.RightSuper },
        { 283, Keys.PrintScreen },
        { 348, Keys.Menu },

        // Botões do mouse
        { 0, MouseButton.Button1 },
        { 1, MouseButton.Button2 },
        { 2, MouseButton.Button3 },
    };
}
