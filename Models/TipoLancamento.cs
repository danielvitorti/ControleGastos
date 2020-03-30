using System;
using System.ComponentModel.DataAnnotations;
namespace ControleGastos.Models
{
    public class TipoLancamento
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public TipoLancamento()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}
