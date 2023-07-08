namespace FinanceManager.Database.Models;

public class Operation
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public float Income { get; set; }

    public float Debit { get; set; }

    public float Balance { get; set; }
}
