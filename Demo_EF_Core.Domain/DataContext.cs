using Demo_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo_EF_Core.Domain
{
    public class DataContext : DbContext
    {
        public DbSet<Contact> Contacts { get { return Set<Contact>(); } }
        public DbSet<Categorie> Categories { get { return Set<Categorie>(); } }
        public DbSet<Utilisateur> Utilisateurs { get { return Set<Utilisateur>(); } }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=Demo_EF_Core;Integrated Security=True");
        }   

        
    }
}