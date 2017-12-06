using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportSystem.Engine
{
    public class Loader
    {
        private string _fileName;

        public Loader (string fileName)
        {
            _fileName = fileName;

            if (!File.Exists(fileName))
                throw new Exception("XDDDDD - incorrect file name - loser!");
        }

        public List<Role> LoadRoles()
        {
            List<Role> roles = new List<Role>();

            using (var stream = new StreamReader(_fileName))
            {
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();
                    roles.Add(LoadRole(line));
                }
            }

           return roles;
        }

        private Role LoadRole ( string line)
        {
            List<Condition> conditions = new List<Condition>();
            Variable result = null;

            var magickTable = line.Split();
            var indexes = GetIsIndexes(magickTable);

            foreach(var index in indexes)
            {
                if (index - 1 < 0 || index + 1 >= magickTable.Length)
                    throw new Exception("XDDDD - damaged input file");

                string name = magickTable[index - 1];
                string value = magickTable[index + 1];
                if (index != indexes.Last())
                    conditions.Add(new Condition(new Variable(name, value)));
                else
                    result = new Variable(name, value);

            }

            return new Role(conditions, result);
        }

        private List<int> GetIsIndexes(string[] table)
        {
            List<int> result = new List<int>();

            for(int k =0;k< table.Length;k++)
            {
                if (table[k].ToLower().Equals("is"))
                {
                    result.Add(k);
                }
            }
            return result;
        }

    }
}
