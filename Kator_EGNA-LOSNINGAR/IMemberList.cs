using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata02
{
    public interface IMemberList
    {
        public IMember this[int idx] { get; }
        public int Count();
        public int Count(int year);
        public void Sort();
    }
}
