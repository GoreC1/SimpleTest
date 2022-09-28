using SimpleTest.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleTest.Interfaces;

namespace SimpleTest.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public FormRepository Forms { get; init; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Forms = new FormRepository(context);
        }

        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
