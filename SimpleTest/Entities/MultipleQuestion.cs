using SimpleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Entities
{
    public class MultipleQuestion : Question
    {
        public readonly IOption[] options;
        public readonly int? maxChecked;
    }
}
