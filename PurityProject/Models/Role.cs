using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PurityProject.Models
{
    [Table("Role")]
    public partial class Role
    {
        public Role()
        {
            RoleAccounts = new HashSet<RoleAccount>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }

    }
}
