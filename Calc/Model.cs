using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal sealed class Operand
    {
        private List<int> value = new List<int>();

        public void SetValue(int n)
        {
            value.Add(n);
        }

        public int GetValue()
        {
            int length = value.ToArray().Length;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result = ((i != 0) ? (result * 10 + value[i]) : value[i]);
            }
            return result;
        }

        public void Clear()
        {
            value.Clear();
        }
    }

}
