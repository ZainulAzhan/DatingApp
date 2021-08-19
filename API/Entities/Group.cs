using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace API.Entities
{
    public class Group
    {
        public Group()
        {
        }

        public Group(string name)
        {
            this.Name = name;
            this.Connections = new List<API.Entities.Connection>();

        }

        [Key]
        public string Name { get; set; }
        public ICollection<API.Entities.Connection> Connections { get; set; }
    }
}