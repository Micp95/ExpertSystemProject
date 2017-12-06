using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportSystem.Engine
{
    public class SystemController
    {
        private Loader _loader;

        private List<Variable> _knowledgeBase;
        private List<Role> _roles;

        public SystemController(string fileWithRoles)
        {
            _loader = new Loader(fileWithRoles);
        }

        public void Initialize()
        {
            _roles = _loader.LoadRoles();
            _knowledgeBase = new List<Variable>();

        }
        public void AddKnowledge(List<Variable> knowledge)
        {
            _knowledgeBase.AddRange(knowledge);
        }

        public void Inference()
        {
            if (_knowledgeBase.Count == 0 || _roles.Count == 0)
                throw new Exception("XDDD - Emtpy knowledgeBase or roles");

            bool isKnowledgeChange;
            bool isRolesEmpty;

            int previousKnowledgeLevel;
            int currentKnowledgeLevel;

            do
            {
                previousKnowledgeLevel = _knowledgeBase.Count;

                TryActiveRoles();

                currentKnowledgeLevel = _knowledgeBase.Count;

                isKnowledgeChange = currentKnowledgeLevel != previousKnowledgeLevel;
                isRolesEmpty = _roles.Count == 0;

            } while (isKnowledgeChange && !isRolesEmpty);
        }

        public List<Variable> KnowledgeBase
        {
            get
            {
                return _knowledgeBase;
            }
        }

        private void TryActiveRoles()
        {
            List<Role> inActiveRoles = new List<Role>();
            List<Variable> newKnowledge = new List<Variable>();

            foreach(var role in _roles)
            {
                if (role.IsActive(_knowledgeBase))
                    newKnowledge.Add(role.Result);
                else
                    inActiveRoles.Add(role);
            }

           _roles = inActiveRoles;
           _knowledgeBase.AddRange(newKnowledge);
        }



    }
}
