public class SaveEventArgs : EventArgs
{
    public User User { get; set; }
    public string Action { get; set; } // Тип дії (Додано, Оновлено, Видалено)
}