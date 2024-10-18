namespace FightManager.Core.Entities;

public class Payment
{
    public Payment(Guid paymentId, Guid studentId, decimal value, DateTime paymentDate, DateTime expirationMonthlyfee, bool paid)
    {
        PaymentId = paymentId;
        StudentId = studentId;
        Value = value;
        PaymentDate = paymentDate;
        ExpirationMonthlyfee = expirationMonthlyfee;
        Paid = paid;
    }
    
    public Guid PaymentId { get; private set; }              // Identificador único do pagamento
    public Guid StudentId { get; private set; }                  // Referência ao aluno que fez o pagamento
    public decimal Value { get; private set; }                // Valor do pagamento
    public DateTime PaymentDate { get; private set; }       // Data do pagamento
    public DateTime ExpirationMonthlyfee { get; private set; } // Vencimento associado ao pagamento
    public bool Paid { get; private set; }                    // Status de pagamento (pago ou não)


}