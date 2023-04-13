using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OOO_Ribolov.Entities
{
	public partial class ContextDB : DbContext
	{
		public ContextDB()
			: base("name=ContextDB")
		{
		}

		public virtual DbSet<Catalog> Catalog { get; set; }
		public virtual DbSet<Category> Category { get; set; }
		public virtual DbSet<Manufacture> Manufacture { get; set; }
		public virtual DbSet<Measurement> Measurement { get; set; }
		public virtual DbSet<Provider> Provider { get; set; }
		public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
				.HasMany(e => e.Catalog)
				.WithRequired(e => e.Category)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Manufacture>()
				.HasMany(e => e.Catalog)
				.WithRequired(e => e.Manufacture)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Measurement>()
				.HasMany(e => e.Catalog)
				.WithRequired(e => e.Measurement)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Provider>()
				.HasMany(e => e.Catalog)
				.WithRequired(e => e.Provider)
				.WillCascadeOnDelete(false);
		}
	}
}
