using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoDIO.Models
{
	public class Categoria
	{
		public int id { get; set; }
		[Display(Name = "Descrição")]
		[Required(ErrorMessage ="Campo Obrigátorio")]
		public string Descricao { get; set; }
		public List<Produto> Produtos { get; set; }
	}
}
