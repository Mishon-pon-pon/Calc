using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal sealed class Expression
    {
        
        private List<Int32> p_operant = new List<Int32>();
        private String p_action;
        private Int32 p_result;

        public String action
        {
            get
            {
                return p_action;
            }
            set
            {
                p_action = value;
            }
        }
        public Int32 result
        {
            get
            {
                return p_result;
            }
            set
            {
                p_result = value;
            }
        }
        public Int32 operant
        {
            get
            {
                int length = p_operant.ToArray().Length;
                for (int i = 0; i < length; i++)
                {
                    result = ((i != 0) ? (result * 10 + p_operant[i]) : p_operant[i]);
                }
                return result;
            }
            set
            {
                p_operant.Add(value);
            }
        }

        public void Clear()
        {
            p_operant.Clear();
            action = "";
            result = 0;
        }
        public void ResetOperant()
        {
            p_operant.Clear();
        }
        public void saveOnceOperant(Int32 n)
        {
            result = n;
        }
    }

}
