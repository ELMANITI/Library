using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities
{
    [Table("Role")]
    public class RoleEntity
    {
       

        [Key] 
        public int ID { get; set; }
        [StringLength(150)]
        public string RoleName { get; set; }
        //one to many Relationship
        public ICollection<UserEntity> Users { get; set; }
    }
}
