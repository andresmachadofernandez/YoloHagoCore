using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yolohago.Models
{
    public class User : Person
    {
        public Guid Key { get; set; }
        public ICollection<Task> TaskCollection { get; set; }

        public User()
        {
            this.Key = Guid.NewGuid();
            this.TaskCollection = new List<Task>();
        }
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                User user = (User)obj;
                equals = this.Key == user.Key;
            }
            return equals;
        }
        public override string ToString()
        {
            return this.Username;
        }

    }
}

