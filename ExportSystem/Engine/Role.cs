using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportSystem.Engine
{
    public class Role
    {
        private List<Condition> _conditions;
        private Variable _result;
        

        public Role(List<Condition> conditions, Variable result)
        {
            _conditions = conditions;
            _result = result;
        }

        public Variable Result
        {
            get
            {
                return _result;
            }
        }

        public bool IsActive(List<Variable> knowledge)
        {
            bool result = _conditions.All(condition =>
            {
                var knownCondition = knowledge.FirstOrDefault(x => x.Name.ToLower().Equals(condition.Name.ToLower()));
                if (knownCondition != null && condition.IsCorrect(knownCondition.Value))
                    return true;
                else
                    return false;
            });
            return result;
        }

    }
}
