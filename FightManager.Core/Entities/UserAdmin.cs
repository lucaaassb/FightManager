using FightManager.Core.Enums;

namespace FightManager.Core.Entities;

public class UserAdmin : User
{
    public UserAdmin(string fullName, string email, string passwordHash, EUserRole role, DateTime createdAt, bool active) : base(fullName, email, passwordHash, role, createdAt, active)
    {
    }
}