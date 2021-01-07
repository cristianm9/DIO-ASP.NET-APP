using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoDIO.Models
{
	public class Produto
	{
		public int Id { get; set; }
		[Display(Name ="Descrição")]
		[Required(ErrorMessage = "Campo Obrigátorio")]
		public string Descricao { get; set; }
		public int Quantidade { get; set; }
		[Range(1,999,ErrorMessage ="Valor fora da faixa")]
		public int CategoriaId { get; set; }
		public Categoria Categoria { get; set; }
	}
}
