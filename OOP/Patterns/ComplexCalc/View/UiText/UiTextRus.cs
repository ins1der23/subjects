/// <summary>
/// Абстрактный класс для сообщений руского UI
/// </summary>
class UiTextRus : UiText
{
    /// <summary>
    /// Конструктор, устанавливающий текст сообщений UI
    /// </summary>
    public UiTextRus()
    {
        start = "Введите CALC или EXIT";
        first = "Введите первое число.";
        operation = "Введите операцию";
        second = "Введите второе число.";
        inputNum = "Введите комплексное (6+8i) или вещественное (7) число ";
        inputError = "ОШИБКА ВВОДА";
        pressEnter = "Нажмите ENTER для продолжения";
        zeroError = "НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ";
    }
}