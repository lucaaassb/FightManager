using FightManager.Core.Enums;

namespace FightManager.Core.Entities;

public class Student : User
{
    public Student(Guid userId, string fullName, string email, string passwordHash, UserRoleEnum role, DateTime createdAt, bool active, string categories, bool paidMonthlyFee, DateTime monthlyPaymentDue) : base(userId, fullName, email, passwordHash, role, createdAt, active)
    {
        Categories = categories;
        PaidMonthlyFee = paidMonthlyFee;
        MonthlyPaymentDue = monthlyPaymentDue;
    }

    public DateTime DateOfEntry { get; private set; }                           // Data de entrada na academia
    public string Categories { get; private set; }                              // Modalidade (jiu-jitsu, muay thai, MMA)
    public bool PaidMonthlyFee { get; private set; }                            // Status de pagamento da mensalidade
    public DateTime MonthlyPaymentDue { get; private set; }                     // Data de vencimento da mensalidade
    public List<Payment> Payments { get; private set; } = new List<Payment>();  // Histórico de pagamentos
}