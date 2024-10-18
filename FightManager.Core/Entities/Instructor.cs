using FightManager.Core.Enums;

namespace FightManager.Core.Entities;

public class Instructor : User
{
    public Instructor(Guid userId, string fullName, string email, string passwordHash, EUserRole role, DateTime createdAt, bool active) : base(fullName, email, passwordHash, role, createdAt, active)
    {
    }

    public List<string> Categories { get; private set; } = new List<string>();
    public List<Classroom> Classrooms { get; private set; } = new List<Classroom>();
}