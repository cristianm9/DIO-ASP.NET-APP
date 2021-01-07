using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoDIO.Models
{
	public class Context: DbContext
	{
			public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Produto> Produtos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CursoDIO;Integrated Security=True");
		}

		public void SetModified(object entity)
		{
			Entry(entity).State = EntityState.Modified;
		}
	}
}