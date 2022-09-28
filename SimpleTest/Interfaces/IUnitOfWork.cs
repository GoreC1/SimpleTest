using SimpleTest.Interfaces;
using SimpleTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        FormRepository Forms { get; }
        Task<int> Complete();
    }
}
