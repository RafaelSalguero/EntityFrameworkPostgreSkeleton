using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Modelos;

namespace sicca.Persistence.Modelos
{
    [DbConfigurationType(typeof(DbConfig))]
    public class Db : DbContext
    {
        public virtual DbSet<recboletas> recboletas { get; set; }

        public Db(string ConnectionString) : base(ConnectionString)
        {
            Init();
        }

        private void Init()
        {
            Database.CommandTimeout = 1024;
        }

        /// <summary>
        /// Construye el contexto conectandose a la base de datos de desarrollo
        /// </summary>
        public Db() : this("Server=localhost; Port=5432; Database=sicca; User Id=postgres; Password=123456;")
        {
        }


        public static void InitMigrations()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Db, Migrations.Configuration>(true));
            Database.SetInitializer(new CreateDatabaseIfNotExists<Db>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // PostgreSQL uses the public schema by default - not dbo.
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

        }
    }
}
