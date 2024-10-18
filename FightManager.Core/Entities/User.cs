using FightManager.Core.Enums;

namespace FightManager.Core.Entities;

public class User : BaseEntity
{
    public User(Guid userId, string fullName, string email, string passwordHash, UserRoleEnum role, DateTime createdAt, bool active)
    {
        UserId = userId;
        FullName = fullName;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
        CreatedAt = createdAt;
        Active = active;
    }

    public Guid UserId { get; private set; }               // Identificador único do usuário
    public string FullName { get; private set; }           // Nome completo
    public string Email { get; private set; }              // E-mail para login e notificações
    public string PasswordHash { get; private set; }       // Senha criptografada
    public UserRoleEnum Role { get; private set; }         // Papel no sistema: Aluno ou Instrutor
    public DateTime CreatedAt { get; private set; }        // Data de criação do usuário
    public bool Active { get; private set; }
    
}