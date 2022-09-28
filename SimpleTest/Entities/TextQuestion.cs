using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTest.Entities
{
    public class TextQuestion : Question
    {
        public string text;
        public int? minLength;
        public int? maxLength;
    }
}
