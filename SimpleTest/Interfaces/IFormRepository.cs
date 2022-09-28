using SimpleTest.Entities;
using SimpleTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Interfaces
{
    public interface IFormRepository : IGenericRepository<Form>
    {
        public Task<Form> UpdateAsync(int id, Form form);
    }
}
