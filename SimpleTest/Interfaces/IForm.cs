using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Interfaces
{
    public interface IForm
    {
        public int id { get; set; }
        public string name { get; set; }
        public IQuestion[] questions { get; set; }
    }
}
