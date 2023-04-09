﻿using BicycleSales.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BicycleSales.DAL;

public class UserContext : DbContext
{
    public DbSet<AuthorizationDto> Authorizations { get; set; }
    public DbSet<UserDto> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
     builder.UseSqlServer("Data Source=DESKTOP-62LIE27;Initial Catalog = VELIKI; Integrated Security=False;Persist Security Info=False");
     //builder.UseInMemoryDatabase("ForTest");
    }
}