namespace BC.AppCloud.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using AppCloud;
    using ApiCloud;
    public partial class ModelAC : DbContext
    {
        public ModelAC()
            : base("name=ModelAC")
        {
        }

        #region AppCloud_

        public DbSet<AppCloud_OrgGroupItem> AppCloud_OrgGroupItem { get; set; }
        public DbSet<AppCloud_AppGroupItem> AppCloud_AppGroupItem { get; set; }
        public DbSet<AppCloud_Config> AppCloud_Config { get; set; }
        public DbSet<AppCloud_Baseframe> AppCloud_Baseframe { get; set; }
        #endregion

        #region ApiCloud_

        public DbSet<ApiCloud_ApiRequestInputItem> ApiCloud_ApiRequestInputItem { get; set; }
        public DbSet<ApiCloud_ApiResponseOutputItem> ApiCloud_ApiResponseOutputItem { get; set; }
        public DbSet<ApiCloud_ApiListItem> ApiCloud_ApiListItem { get; set; }
        public DbSet<ApiCloud_ProjectListItem> ApiCloud_ProjectListItem { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
