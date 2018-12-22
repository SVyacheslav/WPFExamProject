namespace WpfExamProject.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    

    public partial class ModelEntity : DbContext
    {
        public ModelEntity()
            : base("name=ModelEntity")
        {
        }

        public virtual DbSet<newEquipment> newEquipments { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturers { get; set; }
        public virtual DbSet<TablesModel> TablesModels { get; set; }
        public virtual DbSet<TablesSNPrefix> TablesSNPrefixes { get; set; }
        public virtual DbSet<TrackMeter> TrackMeters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
