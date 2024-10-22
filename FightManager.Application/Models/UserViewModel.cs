using FightManager.Core.Enums;

namespace FightManager.Application.Models;

public class UserViewModel
{
    public UserViewModel(string fullName, string email, DateTime createdAt, EUserRole userRole)
    {
        FullName = fullName;
        Email = email;
        CreatedAt = createdAt;
        UserRole = userRole;
    }

    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public EUserRole UserRole { get; private set; }
    
}