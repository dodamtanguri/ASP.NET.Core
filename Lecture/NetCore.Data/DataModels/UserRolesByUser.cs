using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Data.DataModels
{
    public class UserRolesByUser
    {
        [Key, StringLength(50),Column(TypeName ="varchar(50")]
        public string UserId { get; set; }
        [Key, StringLength(50), Column(TypeName = "varchar(50")]
        public string RoleId { get; set; }
        [Required]
        public DateTime OwnUtcDate { get; set; }
    }
}
