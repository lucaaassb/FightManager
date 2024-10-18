namespace FightManager.Core.Entities;

public class Frequency
{
    public Frequency(Guid frequencyId, Guid classroomId, Guid studentId, bool presence, DateTime registerDate)
    {
        FrequencyId = frequencyId;
        ClassroomId = classroomId;
        StudentId = studentId;
        Presence = presence;
        RegisterDate = registerDate;
    }

    public Guid FrequencyId { get; private set; }             // Identificador único
    public Guid ClassroomId { get; private set; }                   // Referência à aula
    public Guid StudentId { get; private set; }                  // Referência ao aluno
    public bool Presence { get; private set; }                // Status de presença do aluno
    public DateTime RegisterDate { get; private set; }        // Data em que a presença foi registrada
}