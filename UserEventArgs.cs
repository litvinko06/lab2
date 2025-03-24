namespace lab4.BlazorLab;

public class UserEventArgs : EventArgs
{
    public User User { get; set; }
    public string Action { get; set; } // Тип дії (Додано, Оновлено, Видалено)
}