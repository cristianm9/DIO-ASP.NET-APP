using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDIO.Models
{
	public class Categoria
	{
		public int id { get; set; }
		public string Descricao { get; set; }
		public List<Produto> Produtos { get; set; }
	}
}
