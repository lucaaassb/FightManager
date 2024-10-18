namespace FightManager.Core.Entities;

public class Plan
{
    public Plan(string planName, decimal value, int monthsDuration)
    {
        PlanId = Guid.NewGuid();
        PlanName = planName;
        Value = value;
        MonthsDuration = monthsDuration;
    }

    public Guid PlanId { get; private set; }                  // Identificador único do plano
    public string PlanName { get; private set; }                  // Nome do plano (ex.: Mensal, Trimestral)
    public decimal Value { get; private set; }                // Valor do plano
    public int MonthsDuration { get; private set; }           // Duração do plano em meses
    public List<Student> Students { get; private set; } = new List<Student>(); // Alunos inscritos nesse plano
}