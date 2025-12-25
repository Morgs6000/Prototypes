using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

public class Input
{
    private static KeyboardState keyboardState = null!;
    private static MouseState mouseState = null!;

    // Dicionário para armazenar tempos do último clique de cada tecla(para double click)
    private static Dictionary<Keys, float> lastKeyClickTimes = new Dictionary<Keys, float>();
    private static Dictionary<MouseButton, float> lastMouseClickTimes = new Dictionary<MouseButton, float>();

    // Tempo máximo entre cliques para ser cconsiderado double click (200ms)
    private static float DOUBLE_CLICK_TIME = 0.2f;

    /// <summary>
    /// Alguma tecla ou botão do mouse está pressionado no momento? (Somente leitura)
    /// </summary>
    public static bool anyKey
    {
        get
        {
            if (keyboardState.IsAnyKeyDown)
            {
                return true;
            }
            if (mouseState.IsAnyButtonDown)
            {
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Retorna verdadeiro no primeiro frame em que o usuário pressionar qualquer tecla ou botão do mouse. (Somente leitura)
    /// </summary>
    public static bool anyKeyDown
    {
        get
        {
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (key != Keys.Unknown)
                {
                    if (GetKeyDown(key))
                    {
                        return true;
                    }
                }
            }
            foreach (MouseButton button in Enum.GetValues(typeof(MouseButton)))
            {
                if (GetMouseButtonDown(button))
                {
                    return true;
                }
            }

            return false;
        }
    }

    /// <summary>
    /// Retorna verdadeiro no primeiro frame em que o usuário solta qualquer tecla ou botão do mouse. (Somente leitura)
    /// </summary>
    public static bool anyKeyUp
    {
        get
        {
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (key != Keys.Unknown)
                {
                    if (GetKeyUp(key))
                    {
                        return true;
                    }
                }
            }
            foreach (MouseButton button in Enum.GetValues(typeof(MouseButton)))
            {
                if (GetMouseButtonUp(button))
                {
                    return true;
                }
            }

            return false;
        }
    }

    /// <summary>
    /// Posição atual do cursor em coordenadas de pixel. (Somente leitura).
    /// </summary>
    public static Vector2 mousePosition
    {
        get
        {
            return mouseState.Position;
        }
    }

    /// <summary>
    /// Delta de rolagem atual do mouse. (Somente leitura)
    /// </summary>
    public static Vector2 mouseScrollDelta
    {
        get
        {
            return mouseState.ScrollDelta;
        }
    }

    /// <summary>
    /// Retorna a primeira tecla ou botão do mouse pressionado no moemnto. (Somente leitura)
    /// </summary>
    public static string pressedKey
    {
        get
        {
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (key != Keys.Unknown)
                {
                    if (GetKey(key) || GetKeyDown(key) || GetKeyUp(key))
                    {
                        return key.ToString();
                    }
                }
            }
            foreach (MouseButton button in Enum.GetValues(typeof(MouseButton)))
            {
                if (GetMouseButton(button) || GetMouseButtonDown(button) || GetMouseButtonUp(button))
                {
                    return button.ToString();
                }
            }

            return string.Empty;
        }
    }

    /// <summary>
    /// Atualiza os estados de entrada
    /// </summary>
    public static void Update(GameWindow gameWindow)
    {
        keyboardState = gameWindow.KeyboardState;
        mouseState = gameWindow.MouseState;
    }

    /// <summary>
    /// Retorna verdadeiro enquanto o usuário mantiver pressionada a tecla identificada pelo parâmetro de enumeração KeyCode.
    /// </summary>
    public static bool GetKey(Keys key)
    {
        return keyboardState.IsKeyDown(key);
    }

    /// <summary>
    /// Retorna verdadeiro durante o frame em que o usuário começa a pressionar a tecla identificada pelo parâmetro de enumeração KeyCode.
    /// </summary>
    public static bool GetKeyDown(Keys key)
    {
        return keyboardState.IsKeyPressed(key);
    }

    /// <summary>
    /// Retorna verdadeiro durante o frame em que o usuário solta a tecla identificada pelo parâmetro de enumeração KeyCode.
    /// </summary>
    public static bool GetKeyUp(Keys key)
    {
        return keyboardState.IsKeyReleased(key);
    }

    /// <summary>
    /// Retorna verdadeiro durante o frame em que o usuário pressionar duas vezes a tecla identificada pelo parâmetro de enumeração KeyCode.
    /// </summary>
    /// <param name="key">Tecla a ser verificada</param>
    /// <returns>True se foi detectado double click neste frame</returns>
    public static bool GetKeyDouble(Keys key)
    {
        // Inicializa o contador de tempo se esta tecla não existir no dicionário
        if (!lastKeyClickTimes.ContainsKey(key))
        {
            lastKeyClickTimes[key] = 0;
        }

        // Decrementa o tempo para esta tecla especifica (contagem regressiva)
        if (lastKeyClickTimes[key] > 0)
        {
            lastKeyClickTimes[key] -= Time.deltaTime;

            // Garante que o tempo não fique negativo
            if (lastKeyClickTimes[key] < 0)
            {
                lastKeyClickTimes[key] = 0;
            }
        }

        // Se a tecla foi pressionada neste frame
        if (GetKeyDown(key))
        {
            // Se ainda esta no tempo do double clique (segundo clique)
            if (lastKeyClickTimes[key] > 0)
            {
                // Resta o timer após detectar o double click
                lastKeyClickTimes[key] = 0;

                // Double click detectado!
                return true;
            }
            else
            {
                // Primeiro Click - Iniciar o timer;
                lastKeyClickTimes[key] = DOUBLE_CLICK_TIME;
            }
        }

        // Não foi double click
        return false;
    }
    
    /// <summary>
    /// Retorna se o botão do mouse especificado está pressionado.
    /// </summary>
    public static bool GetMouseButton(MouseButton button)
    {
        return mouseState.IsButtonDown(button);
    }
    
    /// <summary>
    /// Retorna verdadeiro durante o período em que o usuário pressionou o botão do mouse especificado.
    /// </summary>
    public static bool GetMouseButtonDown(MouseButton button)
    {
        return mouseState.IsButtonPressed(button);
    }
    
    /// <summary>
    /// Retorna verdadeiro durante o período em que o usuário solta o botão do mouse especificado.
    /// </summary>
    public static bool GetMouseButtonUp(MouseButton button)
    {
        return mouseState.IsButtonReleased(button);
    }

    /// <summary>
    /// Retorna verdadeiro durante o período em que o usuário pressionou duas vezes o botão do mouse especificado.
    /// </summary>
    /// <param name="key">Tecla a ser verificada</param>
    /// <returns>True se foi detectado double click neste frame</returns>
    public static bool GetMouseButtonDouble(MouseButton button)
    {
        // Inicializa o contador de tempo se esta tecla não existir no dicionário
        if (!lastMouseClickTimes.ContainsKey(button))
        {
            lastMouseClickTimes[button] = 0;
        }

        // Decrementa o tempo para esta tecla especifica (contagem regressiva)
        if (lastMouseClickTimes[button] > 0)
        {
            lastMouseClickTimes[button] -= Time.deltaTime;

            // Garante que o tempo não fique negativo
            if (lastMouseClickTimes[button] < 0)
            {
                lastMouseClickTimes[button] = 0;
            }
        }

        // Se a tecla foi pressionada neste frame
        if (GetMouseButtonDown(button))
        {
            // Se ainda esta no tempo do double clique (segundo clique)
            if (lastMouseClickTimes[button] > 0)
            {
                // Resta o timer após detectar o double click
                lastMouseClickTimes[button] = 0;

                // Double click detectado!
                return true;
            }
            else
            {
                // Primeiro Click - Iniciar o timer;
                lastMouseClickTimes[button] = DOUBLE_CLICK_TIME;
            }
        }

        // Não foi double click
        return false;
    }
}
