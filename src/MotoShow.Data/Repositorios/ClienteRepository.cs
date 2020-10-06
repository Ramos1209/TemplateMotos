using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotoShow.Domain.Entityes;
using MotoShow.Domain.Interfaces;

namespace MotoShow.Data.Repositorios
{
  public class ClienteRepository: Repositorio<Cliente>, IClienteRespository
    {
    }
}
