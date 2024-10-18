namespace FightManager.Core.Entities;

public class Classroom
{
    public Classroom(Guid classroomId, string categories, DateTime dateHour, Guid instructorId, bool classroomFinished)
    {
        ClassroomId = classroomId;
        Categories = categories;
        DateHour = dateHour;
        InstructorId = instructorId;
        ClassroomFinished = classroomFinished;
    }

    public Guid ClassroomId { get; private set; }                   // Identificador único da aula
    public string Categories { get; private set; }                 // Modalidade da aula
    public DateTime DateHour { get; private set; }                 // Data e hora da aula
    public Instructor? Instructor { get; private set; }              // Instrutor responsável pela aula
    public Guid InstructorId { get; private set; }
    public List<Student> Students { get; private set; } = new List<Student>();          // Lista de alunos inscritos na aula
    public bool ClassroomFinished { get; private set; }           // Status da aula (se foi concluída)
}