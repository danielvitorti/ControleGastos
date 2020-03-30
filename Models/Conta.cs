using System;
using System.ComponentModel.DataAnnotations;

namespace ControleGastos.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor")]
        public float Valor { get; set; }
        public virtual Competencia competencia { get; set; }
        public DateTime DataCadastro { get; set; }

        public Conta()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}
