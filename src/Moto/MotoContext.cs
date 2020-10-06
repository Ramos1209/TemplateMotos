using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moto.Models;

namespace Moto
{
   public class MotoContext: DbContext
   {
       public MotoContext():base(nameOrConnectionString: "Server=DESKTOP-OF7OPC1\\SQLEXPRESS; Database=AppMotoShow;Integrated Security=True")
       {
           
       }

       public DbSet<Cliente> Clientes { get; set; }
    }
}
