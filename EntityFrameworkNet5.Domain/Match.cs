﻿using EntityFrameworkNet5.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkNet5.Domain;

public class Match : BaseDomainObject
{
    public int HomeTeamId { get; set; }
    public virtual Team HomeTeam { get; set; }
    public int AwayTeamId { get; set; }
    public virtual Team AwayTeam { get; set; }

    [Precision(18, 2)]
    public decimal TicketPrice { get; set; }

    public DateTime Date { get; set; }
}
