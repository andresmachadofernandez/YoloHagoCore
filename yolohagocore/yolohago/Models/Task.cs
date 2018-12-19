using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yolohago.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public Guid Key { get; set; }
        public DateTime CreationDate { get; set; }

        public Task()
        {
            this.Key = Guid.NewGuid();
            this.CreationDate = DateTime.Now;
        }
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                Task user = (Task)obj;
                equals = this.Key == user.Key;
            }
            return equals;
        }
        public override string ToString()
        {
            return this.TaskName;
        }
    }
}

