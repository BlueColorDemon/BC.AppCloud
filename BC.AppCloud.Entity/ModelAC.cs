namespace BC.AppCloud.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using AppCloud;
    public partial class ModelAC : DbContext
    {
        public ModelAC()
            : base("name=ModelAC")
        {
        }

        public DbSet<AppCloud_OrgGroupItem> AppCloud_OrgGroupItem { get; set; }
        public DbSet<AppCloud_AppGroupItem> AppCloud_AppGroupItem { get; set; }
        public DbSet<AppCloud_Config> AppCloud_Config { get; set; }
        public DbSet<AppCloud_Baseframe> AppCloud_Baseframe { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
