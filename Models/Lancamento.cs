using System;
using System.ComponentModel.DataAnnotations;

namespace ControleGastos.Models
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Valor")]
        public float Valor { get; set; }
        [Display(Name = "Tipo de lançamento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public virtual TipoLancamento tipoLancamento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Conta")]
        public virtual Conta conta { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Forma de pagamento")]
        public virtual FormaPagamento formaPagamento { get; set; }

        [Display(Name = "Competência")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public virtual Competencia competencia { get; set; }

        public DateTime DataCadastro { get; set; }

        public Lancamento()
        {
            this.DataCadastro = DateTime.Now;
        }

    }

}
