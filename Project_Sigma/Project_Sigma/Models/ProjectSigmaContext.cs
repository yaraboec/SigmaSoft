using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_Sigma.Models
{
    public partial class ProjectSigmaContext : DbContext
    {
        public ProjectSigmaContext()
        {
        }

        public ProjectSigmaContext(DbContextOptions<ProjectSigmaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaContainIngr> PizzaContainIngrs { get; set; }
        public virtual DbSet<PizzaContainsInOrder> PizzaContainsInOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-04TLCNK;initial catalog=ProjectSigma;user id=boss; password=yarasys");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Action>(entity =>
            {
                entity.HasKey(e => e.IdAction)
                    .HasName("PK_Actions_IDAcion");

                entity.Property(e => e.IdAction).HasColumnName("ID_Action");

                entity.Property(e => e.BeginAction)
                    .HasColumnType("time(0)")
                    .HasColumnName("Begin_Action");

                entity.Property(e => e.EndAction)
                    .HasColumnType("time(0)")
                    .HasColumnName("End_Action");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PercentSkidki).HasColumnName("Percent_skidki");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK_Clients_IDClient");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.HasKey(e => e.IdIngredient)
                    .HasName("PK_Ingred_IDIngred");

                entity.Property(e => e.IdIngredient).HasColumnName("ID_Ingredient");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("PK_Orders_IDOrder");

                entity.Property(e => e.IdOrder).HasColumnName("ID_Order");

                entity.Property(e => e.IdAction).HasColumnName("ID_Action");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.TimeOrder)
                    .HasColumnType("datetime")
                    .HasColumnName("Time_Order");

                entity.HasOne(d => d.IdActionNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdAction)
                    .HasConstraintName("FK_Orders_IDAction ");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_IDClient");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza)
                    .HasName("PK_Pizza_IDPizza");

                entity.ToTable("Pizza");

                entity.Property(e => e.IdPizza).HasColumnName("ID_Pizza");

                entity.Property(e => e.Img).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PriceWork).HasColumnName("Price_Work");

                entity.Property(e => e.ResultPrice).HasColumnName("Result_Price");

                entity.Property(e => e.Sostav)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PizzaContainIngr>(entity =>
            {
                entity.HasKey(e => new { e.IdPizza, e.IdIngredient })
                    .HasName("PK__Pizza_co__6A4836C50811ECB7");

                entity.ToTable("Pizza_contain_ingr");

                entity.Property(e => e.IdPizza).HasColumnName("ID_Pizza");

                entity.Property(e => e.IdIngredient).HasColumnName("ID_Ingredient");

                entity.HasOne(d => d.IdIngredientNavigation)
                    .WithMany(p => p.PizzaContainIngrs)
                    .HasForeignKey(d => d.IdIngredient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzaContainIngr_IDIngr");

                entity.HasOne(d => d.IdPizzaNavigation)
                    .WithMany(p => p.PizzaContainIngrs)
                    .HasForeignKey(d => d.IdPizza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzaContainIngr_IDPizza");
            });

            modelBuilder.Entity<PizzaContainsInOrder>(entity =>
            {
                entity.HasKey(e => new { e.IdPizza, e.IdOrder })
                    .HasName("PK__Pizza_co__74714E5B0067503C");

                entity.ToTable("Pizza_contains_in_order");

                entity.Property(e => e.IdPizza).HasColumnName("ID_Pizza");

                entity.Property(e => e.IdOrder).HasColumnName("ID_Order");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.PizzaContainsInOrders)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzaContainInOrder_IDOrder");

                entity.HasOne(d => d.IdPizzaNavigation)
                    .WithMany(p => p.PizzaContainsInOrders)
                    .HasForeignKey(d => d.IdPizza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzaContainInOrder_IDPizza");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
