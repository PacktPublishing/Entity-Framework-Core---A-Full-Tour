using EntityFrameworkNet5.Domain.Common;
using System.Collections.Generic;

namespace EntityFrameworkNet5.Domain;

public class League : BaseDomainObject
{
    public string Name { get; set; }
    public List<Team> Teams { get; set; }
}
