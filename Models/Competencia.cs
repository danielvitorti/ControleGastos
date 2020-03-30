using System;
using System.ComponentModel.DataAnnotations;
namespace ControleGastos.Models
{
    public class Competencia
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Período inicial")]
        public DateTime PeriodoInicial { get; set; }
        [Display(Name = "Período final")]
        public DateTime PeriodoFinal { get; set; }

        public DateTime DataCadastro { get; set; }
        public Competencia()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}
