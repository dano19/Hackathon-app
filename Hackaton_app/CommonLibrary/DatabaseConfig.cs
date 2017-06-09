using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CommonLibrary
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DatabaseContent : DbContext
    {
        public DatabaseContent() : base("SERVER=164.132.197.194; DATABASE=hackathon_db; UID=hackathon_acc; PASSWORD=XIkcxrVZsZu1xsRr;Convert Zero Datetime=True;Allow User Variables=True;")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.Log = s => Debug.WriteLine(s);
        }

        static DatabaseContent()
        {
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }
        
        public DbSet<Database.Venue> Venues { get; set; }

    }

    public partial class MyObjextContextMigration<T> : DbMigrationsConfiguration<T> where T : DbContext
    {
        #region Ctors
        public MyObjextContextMigration()
            : base()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }
        #endregion

        #region Overrides
#if DEBUG
        protected override void Seed(T context)
        {
        }
#endif
        #endregion
    }
}