namespace DealerPlusApp.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DealerPlusEntities : DbContext
    {
        public DealerPlusEntities()
            : base("name=DealerPlusEntities")
        {
        }
       
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AdminSystem> AdminSystems { get; set; }
        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<CreditDebit> CreditDebits { get; set; }
        public virtual DbSet<CreditDebitData> CreditDebitDatas { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ExpenseIncome> ExpenseIncomes { get; set; }
        public virtual DbSet<ExpenseIncomeData> ExpenseIncomeDatas { get; set; }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<MRQVSCash> MRQVSCashes { get; set; }
        public virtual DbSet<OverheadExpense> OverheadExpenses { get; set; }
        public virtual DbSet<OverheadExpenseData> OverheadExpenseDatas { get; set; }
        public virtual DbSet<OverheadSalary> OverheadSalaries { get; set; }
        public virtual DbSet<ProfitAndLoseAll> ProfitAndLoseAlls { get; set; }
        public virtual DbSet<ProfitAndLoseAllData> ProfitAndLoseAllDatas { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreSalary> StoreSalaries { get; set; }
        public virtual DbSet<StoreSalaryData> StoreSalaryDatas { get; set; }
        public virtual DbSet<Summary> Summaries { get; set; }
        public virtual DbSet<SummaryData> SummaryDatas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UsersAdmin> UsersAdmins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.ModifiedUserAdminID)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Checks)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.CreditDebitDatas)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.EmplyeeID);

            modelBuilder.Entity<ExpenseIncome>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Market>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Market>()
                .Property(e => e.StoreCount)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MRQVSCash>()
                .Property(e => e.Check)
                .IsFixedLength();

            modelBuilder.Entity<OverheadExpense>()
                .HasMany(e => e.OverheadExpenseDatas)
                .WithOptional(e => e.OverheadExpense)
                .HasForeignKey(e => e.OHExpenseID);

            modelBuilder.Entity<OverheadExpenseData>()
                .Property(e => e.ModifiedUserAdminID)
                .IsFixedLength();

            modelBuilder.Entity<ProfitAndLoseAll>()
                .HasMany(e => e.ProfitAndLoseAllDatas)
                .WithOptional(e => e.ProfitAndLoseAll)
                .HasForeignKey(e => e.ProfitLoseAllID);

            modelBuilder.Entity<Store>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<UsersAdmin>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<UsersAdmin>()
                .HasMany(e => e.Markets)
                .WithOptional(e => e.UsersAdmin)
                .HasForeignKey(e => e.UserAdminID);
        }
    }
}
