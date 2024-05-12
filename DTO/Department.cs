using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Department
    {
        private string id;
        private string name;
        private string description;

        public Department(string id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
