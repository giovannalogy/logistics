﻿using Logistics.Domain.Entities;

public class PolicyRepository : BaseRepository<Policy>, IPolicyRepository
{
    public PolicyRepository(AppDbContext context) : base(context)
    {
    }
}
