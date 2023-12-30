using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities
{
    [Table("User")]
    public class UserEntity
    {
        

        [Key]
        public int ID { get; set; }
        [StringLength(150)]
        public string LastName { get; set; }
        [StringLength(250)]

        public string FirstName { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string School { get; set; }
        [StringLength(250)]
        public string City { get; set; }
        [StringLength(250)]
        public string Street { get; set; }
        [StringLength(250)]
        public string Neighborhood { get; set; }
        public bool? JobInTech { get; set; }
        //One to many relationship
        public ICollection<RoleEntity> Roles { get; set; }

        // Many to Many relationship

        public IList<UsersRoleEntity> UserRoles { get; set; }
        
    }
}
