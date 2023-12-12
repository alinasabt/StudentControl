using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentControl.Domain.Model
{
    public enum Status
    {
        Studying,
        Notstudying
    }
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string? Middle_name { get; set; }
        public Status Status { get; set; }
        public short Graduate { get; set; }
        public string? Snils { get; set; }
        [JsonIgnore]
        public Guid? GroupID { get; set; }
        [JsonIgnore]
        public Group? Group { get; set; }
        [JsonIgnore]
        public List<Order> Orders { get; set; } = new List<Order>();

        public void RemoveGroup()
        {
            GroupID = null;
            Group = null; 
        }
        public void SetGroup(Group group)
        {
            GroupID = group.Id;
            Group = group;
        }

    }
}
