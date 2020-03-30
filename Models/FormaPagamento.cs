using System;
using System.ComponentModel.DataAnnotations;

namespace ControleGastos.Models
{
    public class FormaPagamento
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public FormaPagamento()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}
