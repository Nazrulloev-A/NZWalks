﻿using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data;

public class NZWalksDbContext: DbContext
{
    public NZWalksDbContext(DbContextOptions _dbContextOptions):base(_dbContextOptions)
    {
        
    }

    public DbSet <Difficulty> Difficulties { get; set; }
    public DbSet<Regions> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }

}
