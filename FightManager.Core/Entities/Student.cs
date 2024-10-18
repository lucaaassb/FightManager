namespace FightManager.Core.Entities;

public class Student : User
{
    public DateTime DateOfEntry { get; private set; }        // Data de entrada na academia
    public string Categories { get; private set; }           // Modalidade (jiu-jitsu, muay thai, MMA)
    public string Belt { get; private set; }                // Faixa atual do aluno (ex.: branca, azul, etc.)
    public bool PaidMonthlyFee { get; private set; }        // Status de pagamento da mensalidade
    public DateTime MonthlyPaymentDue { get; private set; } // Data de vencimento da mensalidade
    public List<Payment> Payments { get; private set; }  // Histórico de pagamentos
}