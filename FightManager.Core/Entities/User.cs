using FightManager.Core.Enums;

namespace FightManager.Core.Entities;

public class User : BaseEntity
{
    public User(string fullName, string email)
        : base()
    {
        FullName = fullName;
        Email = email;
    }

    public Guid UserId { get; private set; }               // Identificador único do usuário
    public string FullName { get; private set; }           // Nome completo
    public string Email { get; private set; }              // E-mail para login e notificações
    public string PasswordHash { get; private set; }       // Senha criptografada
    public UserRoleEnum Role { get; private set; }         // Papel no sistema: Aluno ou Instrutor
    public DateTime CreatedAt { get; private set; }        // Data de criação do usuário
    
}