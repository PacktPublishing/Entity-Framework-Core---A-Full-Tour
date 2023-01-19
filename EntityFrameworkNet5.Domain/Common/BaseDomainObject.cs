using System;

namespace EntityFrameworkNet5.Domain.Common;

public abstract class BaseDomainObject
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
}
