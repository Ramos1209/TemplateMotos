using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoShow.Domain.Entityes
{
   public class EntityBase
    {

        public EntityBase()
        {
            DataCadastro.ToString("d");
        }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
