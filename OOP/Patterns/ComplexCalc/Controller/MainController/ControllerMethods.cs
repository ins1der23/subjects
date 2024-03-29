/// <summary>
/// Статические методы, используемые в котроллере
/// </summary>
abstract class ControllerMethods
{
    /// <summary>
    /// Проверка строки на числовое значение
    /// </summary>
    /// <param name="input">Полученная строка</param>
    /// <returns>Результат проверки</returns>
    public static bool IsNumeric(string input)
    {
        input = input.Replace(" ", "");

        if (input.Equals(string.Empty)) return false;
        if (input.EndsWith("i")) input = input[..^1];
        if (input.StartsWith("-")) input = input[1..];

        if (input.Last().Equals("+") ||
            input.Last().Equals("-") ||
            input.Last().Equals(",") ||
            input.Last().Equals("."))
            return false;
        if (input.Any(x => !double.TryParse(x.ToString(), out _) &&
                   !x.ToString().Equals("+") &&
                   !x.ToString().Equals("-") &&
                   !x.ToString().Equals(",") &&
                   !x.ToString().Equals(".")))
            return false;
        if (input.Count(x => x.ToString().Equals("+")) > 1 ||
            input.Count(x => x.ToString().Equals("-")) > 2)
            return false;
        return true;
    }

    /// <summary>
    /// Проверка строки на оператор вычисления
    /// </summary>
    /// <param name="input">Полученная строка</param>
    /// <returns>Результат проверки</returns>
    public static bool IsOperation(string input)
    {
        input = input.Replace(" ", "");
        if (input.Equals(string.Empty)) return false;
        if (input.Length != 1) return false;
        string[] operations = new string[] { "+", "-", "*", "/" };
        if (operations.Contains(input)) return true;
        return false;
    }
}