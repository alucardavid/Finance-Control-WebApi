using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Control_Finance_WebAPI.Infra.Data.Models
{
    public partial class DevGeniusFinanceContext : IdentityDbContext<IdentityUser>
    {
        public DevGeniusFinanceContext()
        {
        }

        public DevGeniusFinanceContext(DbContextOptions<DevGeniusFinanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Balance> Balances { get; set; } = null!;
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; } = null!;
        public virtual DbSet<FormOfPayment> FormOfPayments { get; set; } = null!;
        public virtual DbSet<MonthlyExpense> MonthlyExpenses { get; set; } = null!;
        public virtual DbSet<VariableExpense> VariableExpenses { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin" }, StringSplitOptions.None)[0];
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
                string connectionString = configuration.GetConnectionString("devgenius_finance");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.ToTable("Balance");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserCpf)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("User_CPF");
            });

            modelBuilder.Entity<ExpenseCategory>(entity =>
            {
                entity.ToTable("ExpenseCategory");

                entity.Property(e => e.DtCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<FormOfPayment>(entity =>
            {
                entity.ToTable("FormOfPayment");

                entity.Property(e => e.BalanceId).HasColumnName("Balance_Id");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Balance)
                    .WithMany(p => p.FormOfPayments)
                    .HasForeignKey(d => d.BalanceId);
            });

            modelBuilder.Entity<MonthlyExpense>(entity =>
            {
                entity.ToTable("MonthlyExpense");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExpenseCategoryId).HasColumnName("ExpenseCategory_Id");

                entity.Property(e => e.FormOfPaymentId).HasColumnName("FormOfPayment_Id");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserCpf)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("User_CPF");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ExpenseCategory)
                    .WithMany(p => p.MonthlyExpenses)
                    .HasForeignKey(d => d.ExpenseCategoryId);

                entity.HasOne(d => d.FormOfPayment)
                    .WithMany(p => p.MonthlyExpenses)
                    .HasForeignKey(d => d.FormOfPaymentId);

            });

            modelBuilder.Entity<VariableExpense>(entity =>
            {
                entity.ToTable("VariableExpense");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FormOfPaymentId).HasColumnName("FormOfPayment_Id");

                entity.Property(e => e.Place).HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.UserCpf)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("User_CPF");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FormOfPayment)
                    .WithMany(p => p.VariableExpenses)
                    .HasForeignKey(d => d.FormOfPaymentId);
                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
