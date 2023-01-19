using EntityFrameworkNet5.Domain.Common;

namespace EntityFrameworkNet5.Domain;

public class Coach : BaseDomainObject
{
    public string Name { get; set; }
    public int? TeamId { get; set; }
    ////public virtual Team Team { get; set; }
}
