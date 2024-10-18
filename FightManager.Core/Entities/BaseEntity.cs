namespace FightManager.Core.Entities;

public class BaseEntity
{
    public BaseEntity(DateTime createdAt, bool isDeleted)
    {
        CreatedAt = DateTime.Now;
        IsDeleted = false;
    }

    public int Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsDeleted { get; private set; }

    public void SetAsDeleted()
    {
        IsDeleted = true;
    }
}