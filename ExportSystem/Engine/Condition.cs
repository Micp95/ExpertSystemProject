using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportSystem.Engine
{
    public class Condition
    {
        private Variable _var;


        public Condition(Variable var)
        {
            _var = var;
        }
        public bool IsCorrect(string value)
        {
            return _var.Value.ToLower().Equals(value.ToLower());
        }
        public string Name
        {
            get
            {
                return _var.Name;
            }
        }


    }
}
