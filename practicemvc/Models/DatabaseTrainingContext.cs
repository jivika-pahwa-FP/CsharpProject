using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace practicemvc.Models
{
    public partial class DatabaseTrainingContext : DbContext
    {
        public DatabaseTrainingContext()
        {
        }

        public DatabaseTrainingContext(DbContextOptions<DatabaseTrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AEmployee> AEmployees { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AjayEmployee1> AjayEmployee1s { get; set; }
        public virtual DbSet<AjaySbaccount> AjaySbaccounts { get; set; }
        public virtual DbSet<AjaySbtransaction1> AjaySbtransaction1s { get; set; }
        public virtual DbSet<AviBookingDetail> AviBookingDetails { get; set; }
        public virtual DbSet<AviSbaccount> AviSbaccounts { get; set; }
        public virtual DbSet<AviSbtransaction> AviSbtransactions { get; set; }
        public virtual DbSet<BhramarSbaccount> BhramarSbaccounts { get; set; }
        public virtual DbSet<BhramarSbtransaction> BhramarSbtransactions { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<BookingDetailsAbhishek> BookingDetailsAbhisheks { get; set; }
        public virtual DbSet<BookingDetailsAjay> BookingDetailsAjays { get; set; }
        public virtual DbSet<Bookk> Bookks { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Cause> Causes { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<DarshanSbaccount> DarshanSbaccounts { get; set; }
        public virtual DbSet<DarshanSbtransaction> DarshanSbtransactions { get; set; }
        public virtual DbSet<DemoImageDb> DemoImageDbs { get; set; }
        public virtual DbSet<DivyanshSbaccount> DivyanshSbaccounts { get; set; }
        public virtual DbSet<DivyanshSbtransaction> DivyanshSbtransactions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FlightDetail> FlightDetails { get; set; }
        public virtual DbSet<FundReceiver> FundReceivers { get; set; }
        public virtual DbSet<Funder> Funders { get; set; }
        public virtual DbSet<FunderCause> FunderCauses { get; set; }
        public virtual DbSet<Harish1> Harish1s { get; set; }
        public virtual DbSet<HarishSbaccount> HarishSbaccounts { get; set; }
        public virtual DbSet<HarishSbtransaction> HarishSbtransactions { get; set; }
        public virtual DbSet<HarshSbaccount> HarshSbaccounts { get; set; }
        public virtual DbSet<HarshSbtransaction> HarshSbtransactions { get; set; }
        public virtual DbSet<Holding> Holdings { get; set; }
        public virtual DbSet<JivikaSbaccount> JivikaSbaccounts { get; set; }
        public virtual DbSet<JivikaSbtransaction> JivikaSbtransactions { get; set; }
        public virtual DbSet<LekhanaSbacc> LekhanaSbaccs { get; set; }
        public virtual DbSet<LekhanaSbtran> LekhanaSbtrans { get; set; }
        public virtual DbSet<Manisha> Manishas { get; set; }
        public virtual DbSet<ManishaSbaccount> ManishaSbaccounts { get; set; }
        public virtual DbSet<ManishaSbtransaction> ManishaSbtransactions { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PracticeTable> PracticeTables { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RaviSbaccount> RaviSbaccounts { get; set; }
        public virtual DbSet<RaviSbtransaction> RaviSbtransactions { get; set; }
        public virtual DbSet<RitikEmployee> RitikEmployees { get; set; }
        public virtual DbSet<RitikSbacoount> RitikSbacoounts { get; set; }
        public virtual DbSet<RitikSbtransaction> RitikSbtransactions { get; set; }
        public virtual DbSet<RouteDetail> RouteDetails { get; set; }
        public virtual DbSet<SarwatSbaccount> SarwatSbaccounts { get; set; }
        public virtual DbSet<SarwatSbtransaction> SarwatSbtransactions { get; set; }
        public virtual DbSet<SbAccountYash> SbAccountYashes { get; set; }
        public virtual DbSet<SbLoan> SbLoans { get; set; }
        public virtual DbSet<SbTransactionYash> SbTransactionYashes { get; set; }
        public virtual DbSet<SbaccountAbhishek> SbaccountAbhisheks { get; set; }
        public virtual DbSet<SbaccountAmresh> SbaccountAmreshes { get; set; }
        public virtual DbSet<SbaccountSankalp> SbaccountSankalps { get; set; }
        public virtual DbSet<SbaccountShaifali> SbaccountShaifalis { get; set; }
        public virtual DbSet<SbloanSankalp> SbloanSankalps { get; set; }
        public virtual DbSet<SbtransactionAbhishek> SbtransactionAbhisheks { get; set; }
        public virtual DbSet<SbtransactionAmresh> SbtransactionAmreshes { get; set; }
        public virtual DbSet<SbtransactionSankalp> SbtransactionSankalps { get; set; }
        public virtual DbSet<SbtransactionShaifali> SbtransactionShaifalis { get; set; }
        public virtual DbSet<ShanSbaccount> ShanSbaccounts { get; set; }
        public virtual DbSet<ShanSbtransaction> ShanSbtransactions { get; set; }
        public virtual DbSet<Shivam> Shivams { get; set; }
        public virtual DbSet<Shivamsbaccount> Shivamsbaccounts { get; set; }
        public virtual DbSet<Shivamsbtransaction> Shivamsbtransactions { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShsadminDb> ShsadminDbs { get; set; }
        public virtual DbSet<ShscustomerDb> ShscustomerDbs { get; set; }
        public virtual DbSet<ShsordersDb> ShsordersDbs { get; set; }
        public virtual DbSet<ShsproductDb> ShsproductDbs { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StudentTable> StudentTables { get; set; }
        public virtual DbSet<SundaramSbaccount> SundaramSbaccounts { get; set; }
        public virtual DbSet<SundaramSbtransaction> SundaramSbtransactions { get; set; }
        public virtual DbSet<TeacherTable> TeacherTables { get; set; }
        public virtual DbSet<TodoList> TodoLists { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TrasferFund> TrasferFunds { get; set; }
        public virtual DbSet<Trial> Trials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAdmin> UserAdmins { get; set; }
        public virtual DbSet<UserCustomer> UserCustomers { get; set; }
        public virtual DbSet<Watchlist> Watchlists { get; set; }
        public virtual DbSet<ZtoDoList> ZtoDoLists { get; set; }
        public virtual DbSet<ZuserDetail> ZuserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.22.10.31;Database=DatabaseTraining;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AEmployee>(entity =>
            {
                entity.ToTable("a_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AjayEmployee1>(entity =>
            {
                entity.ToTable("Ajay_Employee1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<AjaySbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Ajay_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance).HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.MaxBalance).HasColumnName("maxBalance");
            });

            modelBuilder.Entity<AjaySbtransaction1>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ajay_SBTransaction1");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionId");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionType");
            });

            modelBuilder.Entity<AviBookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("Avi_BookingDetails");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.Doj).HasColumnType("datetime");
            });

            modelBuilder.Entity<AviSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Avi_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AviSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Avi_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhramarSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Bhramar_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CurrentAddress)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhramarSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Bhramar_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.BookId)
                    .ValueGeneratedNever()
                    .HasColumnName("BookID");

                entity.Property(e => e.Bookname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasKey(e => e.Bookingid);

                entity.Property(e => e.Bookingid)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingid");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.Flightid).HasColumnName("flightid");

                entity.Property(e => e.Numberofpassengers).HasColumnName("numberofpassengers");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.Property(e => e.Totalvalue).HasColumnName("totalvalue");
            });

            modelBuilder.Entity<BookingDetailsAbhishek>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("BookingId");

                entity.ToTable("BookingDetails_Abhishek");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.Doj).HasColumnType("smalldatetime");

                entity.Property(e => e.Totalvalue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BookingDetailsAjay>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("BookingDetails_Ajay");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.NumberOfPassengers).HasColumnName("numberOfPassengers");

                entity.Property(e => e.RouteId).HasColumnName("routeId");

                entity.Property(e => e.TotalValue).HasColumnName("totalValue");
            });

            modelBuilder.Entity<Bookk>(entity =>
            {
                entity.HasKey(e => e.Bookid);

                entity.ToTable("Bookk");

                entity.Property(e => e.Bookid)
                    .ValueGeneratedNever()
                    .HasColumnName("bookid");

                entity.Property(e => e.Bookname)
                    .HasMaxLength(50)
                    .HasColumnName("bookname");

                entity.Property(e => e.Booktype)
                    .HasMaxLength(50)
                    .HasColumnName("booktype");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.Bookid);

                entity.ToTable("cart");

                entity.Property(e => e.Bookid)
                    .ValueGeneratedNever()
                    .HasColumnName("bookid");

                entity.Property(e => e.Bookname)
                    .HasMaxLength(50)
                    .HasColumnName("bookname");

                entity.Property(e => e.Booktype)
                    .HasMaxLength(50)
                    .HasColumnName("booktype");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Cause>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("cause");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.Frid)
                    .HasMaxLength(10)
                    .HasColumnName("frid")
                    .IsFixedLength(true);

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("money");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.Customerid);

                entity.Property(e => e.Customerid)
                    .ValueGeneratedNever()
                    .HasColumnName("customerid");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customername");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<DarshanSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("darshanSBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .HasColumnName("customerName")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DarshanSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("darshanSBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .HasColumnName("transactionId")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("transactionType")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DemoImageDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemoImageDb");

                entity.Property(e => e.ImageSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DivyanshSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Divyansh_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.Currentbalance).HasColumnName("currentbalance");

                entity.Property(e => e.Customeraddress)
                    .HasMaxLength(50)
                    .HasColumnName("customeraddress");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customername");
            });

            modelBuilder.Entity<DivyanshSbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid);

                entity.ToTable("Divyansh_SBTransaction");

                entity.Property(e => e.Transactionid)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionid");

                entity.Property(e => e.Accountnumber).HasColumnName("accountnumber");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiondate)
                    .HasColumnType("date")
                    .HasColumnName("transactiondate");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("transactiontype");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Doj).HasColumnType("date");

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<FlightDetail>(entity =>
            {
                entity.HasKey(e => e.Flightid);

                entity.Property(e => e.Flightid)
                    .ValueGeneratedNever()
                    .HasColumnName("flightid");

                entity.Property(e => e.Arrivaltime)
                    .HasColumnType("datetime")
                    .HasColumnName("arrivaltime");

                entity.Property(e => e.Costperseat).HasColumnName("costperseat");

                entity.Property(e => e.Departuretime)
                    .HasColumnType("datetime")
                    .HasColumnName("departuretime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destination");

                entity.Property(e => e.Flightname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flightname");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imagepath");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");

                entity.Property(e => e.Totalcapacity).HasColumnName("totalcapacity");
            });

            modelBuilder.Entity<FundReceiver>(entity =>
            {
                entity.HasKey(e => e.Frid);

                entity.ToTable("fundReceiver");

                entity.Property(e => e.Frid)
                    .HasMaxLength(10)
                    .HasColumnName("frid")
                    .IsFixedLength(true);

                entity.Property(e => e.Frname)
                    .HasMaxLength(10)
                    .HasColumnName("frname")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Funder>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("funder");

                entity.Property(e => e.Fid)
                    .HasMaxLength(10)
                    .HasColumnName("fid")
                    .IsFixedLength(true);

                entity.Property(e => e.Fname)
                    .HasMaxLength(10)
                    .HasColumnName("fname")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<FunderCause>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("funderCauses");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Fid)
                    .HasMaxLength(10)
                    .HasColumnName("fid")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Harish1>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber)
                    .HasName("id_pk");

                entity.ToTable("harish_1");

                entity.Property(e => e.EmployeeNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("employee_number");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(10)
                    .HasColumnName("employee_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarishSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("harish_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarishSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TId);

                entity.ToTable("harish_SBTransaction");

                entity.Property(e => e.TId)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.TType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("t_type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarshSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Harsh_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<HarshSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Harsh_SBTransaction");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).HasMaxLength(20);
            });

            modelBuilder.Entity<Holding>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.Property(e => e.RecordId)
                    .ValueGeneratedNever()
                    .HasColumnName("recordId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("stock");
            });

            modelBuilder.Entity<JivikaSbaccount>(entity =>
            {
                entity.ToTable("Jivika_SBAccount");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountNo).HasColumnName("account_no");

                entity.Property(e => e.CurrentBalance).HasColumnName("current_balance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .HasColumnName("customer_address")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .HasColumnName("customer_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<JivikaSbtransaction>(entity =>
            {
                entity.ToTable("Jivika_SBTransaction");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountNo).HasColumnName("account_no");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Dot)
                    .HasColumnType("datetime")
                    .HasColumnName("dot");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LekhanaSbacc>(entity =>
            {
                entity.HasKey(e => e.AccNumber)
                    .HasName("PK__Lekhana___A24910AB202506CF");

                entity.ToTable("Lekhana_SBAcc");

                entity.Property(e => e.AccNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("acc_number");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LekhanaSbtran>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK_Lekhana_sbtran");

                entity.ToTable("Lekhana_SBTran");

                entity.Property(e => e.TId)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id");

                entity.Property(e => e.Accno).HasColumnName("accno");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.TType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t_type");
            });

            modelBuilder.Entity<Manisha>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Manisha");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<ManishaSbaccount>(entity =>
            {
                entity.HasKey(e => e.Accno);

                entity.ToTable("Manisha_SBAccount");

                entity.Property(e => e.Accno).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishaSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("Manisha_SBTransaction");

                entity.Property(e => e.TransId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransID");

                entity.Property(e => e.Amt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza");

                entity.Property(e => e.PizzaId)
                    .ValueGeneratedNever()
                    .HasColumnName("PizzaID");

                entity.Property(e => e.PizzaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PracticeTable>(entity =>
            {
                entity.ToTable("PracticeTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(10)
                    .HasColumnName("product_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("Product");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<RaviSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNo);

                entity.ToTable("Ravi_SBAccount");

                entity.Property(e => e.AccountNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Account No");

                entity.Property(e => e.CurrentBalance).HasColumnName("Current balance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .HasColumnName("Customer Address")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");
            });

            modelBuilder.Entity<RaviSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ravi_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Transaction Id");

                entity.Property(e => e.AccountNo).HasColumnName("Account No");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RitikEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ritik_Employee");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Doj).HasColumnType("date");

                entity.Property(e => e.Ename).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<RitikSbacoount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Ritik_SBAcoount");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.CurrentBalance).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);
            });

            modelBuilder.Entity<RitikSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ritik_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<RouteDetail>(entity =>
            {
                entity.HasKey(e => e.Routeid);

                entity.Property(e => e.Routeid)
                    .ValueGeneratedNever()
                    .HasColumnName("routeid");

                entity.Property(e => e.Flightid).HasColumnName("flightid");

                entity.Property(e => e.Routedesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("routedesc");
            });

            modelBuilder.Entity<SarwatSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Sarwat_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SarwatSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Sarwat_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbAccountYash>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SB_Account_Yash");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Account Number");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Current Balance");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Address");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");
            });

            modelBuilder.Entity<SbLoan>(entity =>
            {
                entity.ToTable("sbLoan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.DurationInDays).HasColumnName("durationInDays");

                entity.Property(e => e.Intrest).HasColumnName("intrest");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            modelBuilder.Entity<SbTransactionYash>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SB_Transaction_Yash");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Transaction ID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Account Number");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<SbaccountAbhishek>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("AccNo");

                entity.ToTable("SBAccount_Abhishek");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SbaccountAmresh>(entity =>
            {
                entity.HasKey(e => e.AccNo);

                entity.ToTable("SBAccount_Amresh");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SbaccountSankalp>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .HasName("PK_Table_1");

                entity.ToTable("SBAccount_Sankalp");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreditScore)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Credit_Score");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ifsc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ifsc");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<SbaccountShaifali>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SBAccount_Shaifali");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SbloanSankalp>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.ToTable("SBLoan_Sankalp");

                entity.Property(e => e.LoanId).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionAbhishek>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("TransactionId");

                entity.ToTable("SBTransaction_Abhishek");

                entity.Property(e => e.TransactionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionAmresh>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Amresh");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionSankalp>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Sankalp");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionShaifali>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Shaifali");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShanSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("shan_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customerName");
            });

            modelBuilder.Entity<ShanSbtransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shan_SBTransaction");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionId).HasColumnName("transactionID");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("transactionType");
            });

            modelBuilder.Entity<Shivam>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_shivam_1");

                entity.ToTable("shivam");

                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivamsbaccount>(entity =>
            {
                entity.HasKey(e => e.Accountnumber);

                entity.ToTable("shivamsbaccount");

                entity.Property(e => e.Accountnumber).ValueGeneratedNever();

                entity.Property(e => e.Customeraddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivamsbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid)
                    .HasName("PK_shivamsbtransaction_1");

                entity.ToTable("shivamsbtransaction");

                entity.Property(e => e.Transactionid)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("transactiontype")
                    .IsFixedLength(true);

                entity.Property(e => e.Transationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("transationdate");
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.ToTable("ShoppingCart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Model Name");
            });

            modelBuilder.Entity<ShsadminDb>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("SHSAdminDb");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdminEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsFixedLength(true);

                entity.Property(e => e.AdminPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShscustomerDb>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("SHSCustomerDb");

                entity.Property(e => e.CustId)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.HouseNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ShsordersDb>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("SHSOrdersDb");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.CustId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.SellerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ShsproductDb>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("SHSProductDb");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.ProdType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.SellerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.StockId)
                    .HasMaxLength(20)
                    .HasColumnName("stockId");

                entity.Property(e => e.Imagepath)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imagepath");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<StudentTable>(entity =>
            {
                entity.ToTable("StudentTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FileUpload).HasColumnName("file_upload");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .HasColumnName("grade")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Subject1).HasColumnName("subject1");

                entity.Property(e => e.Subject2).HasColumnName("subject2");

                entity.Property(e => e.Subject3).HasColumnName("subject3");
            });

            modelBuilder.Entity<SundaramSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("sundaram_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SundaramSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("sundaram_SBTransaction");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeacherTable>(entity =>
            {
                entity.ToTable("TeacherTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .HasColumnName("password")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TodoList>(entity =>
            {
                entity.ToTable("TodoList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Complete)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TrasferFund>(entity =>
            {
                entity.ToTable("trasferFunds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.FromAccount).HasColumnName("fromAccount");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            modelBuilder.Entity<Trial>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Trial");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");
            });

            modelBuilder.Entity<UserAdmin>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("user_admin");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<UserCustomer>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("user_customer");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Watchlist>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Watchlist");

                entity.Property(e => e.RecordId)
                    .ValueGeneratedNever()
                    .HasColumnName("recordId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("stock");
            });

            modelBuilder.Entity<ZtoDoList>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ZToDoList");

                entity.Property(e => e.EventId).ValueGeneratedNever();

                entity.Property(e => e.EventCreated).HasColumnType("date");

                entity.Property(e => e.EventDescription).IsUnicode(false);

                entity.Property(e => e.EventTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZuserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("ZUserDetails");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
