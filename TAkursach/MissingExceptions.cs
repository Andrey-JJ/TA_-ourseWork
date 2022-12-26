using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAkursach
{
    public class MissingExceptions : Exception
    {
        public MissingExceptions(string lexem, string expectedlexems) : base($"Ожидалось получить {expectedlexems}.\nНо была получена {lexem}") 
        { }
    }
}