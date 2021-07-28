using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorCondominios.BLL.Models
{
    public class Servico
    {
        public int ServicoId { get; set;  }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public StatusServico Status { get; set; }
        public string UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public ICollection<ServicoPredio> ServicoPredios { get; set;  }
    }

    public enum StatusServico
    { 
        Pendente, Recusado, Aceito
    }
}