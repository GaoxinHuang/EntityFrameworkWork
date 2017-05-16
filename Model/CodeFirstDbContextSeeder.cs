using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CodeFirstDbContextSeeder : DropCreateDatabaseIfModelChanges<CodeFirstDbContext>
    {
        protected override void Seed(CodeFirstDbContext context)
        {
            User user = new User()
            {
                Username = "testUsername",
                Name = "testName",
                Password = "testPassword",
                Account = new List<Account>()
                {
                    new Account()
                    {
                          Accountname =  "testGaoxin"
                    }
                }
            };
            context.User.Add(user);
            base.Seed(context);
        }
    }
}
