using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Models
{
    public class UserProfile

    {
        public int Id { get; set; }

        public String Bio { get; set; }
        public String AvatarUrl { get; set; }
        public String Birthday { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
