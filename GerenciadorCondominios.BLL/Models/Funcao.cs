using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GerenciadorCondominios.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set;  }
    }
}
