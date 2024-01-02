using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities
{
    [Table("UsersRole")]
    public class UsersRoleEntity
    {
        [Key]
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public int? IdRole { get; set; }

    }
}
