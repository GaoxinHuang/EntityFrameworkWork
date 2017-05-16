using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //[Table("User")]
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public List<Account> Account { get; set; }
        public string Job { get; set; }
    }
}
