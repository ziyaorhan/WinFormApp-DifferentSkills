using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DifferentSkills.ORM.Manager
{
    public class DatabaseContext : DbContext
    {
        //kurucu metotta oluşturucuyu tetikledik.
        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new Builder());
        }
        //Tablolar DbSet'e eklendi.
        public DbSet<GithubUser> GithubUser { get; set; }
        public DbSet<GithubRepository> GithubRepository { get; set; }

    }
    //oluşturucu sınıf.
    public class Builder : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
