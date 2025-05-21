namespace CleanArchitecture.Domain.Common;

/// <summary>
/// 包含审计信息的实体基类
/// </summary>
public abstract class AuditableEntity : BaseEntity
{
    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}