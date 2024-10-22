using FightManager.Core.Enums;

namespace FightManager.Application.Models;

public class CreateUserInputModel
{
    public string Fullname { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public EUserRole Role { get; set; }
}