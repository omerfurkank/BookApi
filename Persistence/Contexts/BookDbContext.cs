﻿using Domain.Entities;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts;
public class BookDbContext : IdentityDbContext<User,Role,int>
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public BookDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
    { 
        Configuration = configuration;
    }
}
