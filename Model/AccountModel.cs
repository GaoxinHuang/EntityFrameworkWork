using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Account")]
    public class Account
    {
        public int Id { get; set; }
        [Column("AccountName")]
        public string Accountname { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
