namespace FightManager.Core.Entities;

public class Plan
{
    public Plan(Guid planId, string planName, decimal value, int mesesDuração)
    {
        PlanId = planId;
        PlanName = planName;
        Value = value;
        MesesDuração = mesesDuração;
    }

    public Guid PlanId { get; private set; }                  // Identificador único do plano
    public string PlanName { get; private set; }                  // Nome do plano (ex.: Mensal, Trimestral)
    public decimal Value { get; private set; }                // Valor do plano
    public int MesesDuração { get; private set; }           // Duração do plano em meses
    public List<Student> Students { get; private set; } = new List<Student>(); // Alunos inscritos nesse plano
}