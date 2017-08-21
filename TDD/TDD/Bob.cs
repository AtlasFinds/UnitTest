using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD
{
    public class Bob
    {
        public int GetValue(string s)
        {
            return 1;
        }

        public int StubDependency(string s)
        {
            if (s == "abc")
              return 1;
            if (s == "xyz")
              return 2;
            return 0;
        }
    }
}
