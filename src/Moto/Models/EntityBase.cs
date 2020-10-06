using System;
using System.ComponentModel.DataAnnotations;

namespace Moto.Models
{
   public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
