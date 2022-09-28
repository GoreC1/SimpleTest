using Microsoft.EntityFrameworkCore;
using SimpleTest.Entities;
using SimpleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Repositories
{
    public class FormRepository : GenericRepository<Form>, IFormRepository
    {
        public FormRepository(DbContext context) : base(context) { }

        public async Task<Form> UpdateAsync(int id, Form form)
        {
            form.id = id;
            _context.Set<Form>().Update(form);
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
