using Domain.Entities.Common;
using Domain.ValueObjects.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Management
{
    [Table("tblGroup")]
    public class Group : BaseEntity<GroupId, Guid>
    {
        [Column("groupId")]
        public override GroupId Id { get; set; } = new GroupId(Guid.NewGuid());
        [Column("groupName")]
        public string Name { get; set; } = string.Empty;
        [Column("groupDescription")]
        public string Description { get; set; } = string.Empty;
    }
}
