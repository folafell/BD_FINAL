using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Aeroport;

public partial class AeroportContext : DbContext
{
    public AeroportContext()
    {
    }

    public AeroportContext(DbContextOptions<AeroportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<Airplane> Airplanes { get; set; }

    public virtual DbSet<AirplaneType> AirplaneTypes { get; set; }

    public virtual DbSet<Boss> Bosses { get; set; }

    public virtual DbSet<Brigade> Brigades { get; set; }

    public virtual DbSet<CanceledFlight> CanceledFlights { get; set; }

    public virtual DbSet<Cashier> Cashiers { get; set; }

    public virtual DbSet<Dispatcher> Dispatchers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Passenger> Passengers { get; set; }

    public virtual DbSet<Pilot> Pilots { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Security> Securities { get; set; }

    public virtual DbSet<Stewardess> Stewardesses { get; set; }

    public virtual DbSet<Technician> Technicians { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Aeroport;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.AdministratorId).HasName("PK__Administ__ACDEFE33799B27E5");

            entity.ToTable("Administrator");

            entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<Airplane>(entity =>
        {
            entity.HasKey(e => e.AirplaneId).HasName("PK__Airplane__5ED76B857825B7E3");

            entity.ToTable("Airplane");

            entity.Property(e => e.AirplaneId).HasColumnName("AirplaneID");
            entity.Property(e => e.LastRepair).HasColumnType("date");
            entity.Property(e => e.ReceiptDate).HasColumnType("date");
            entity.Property(e => e.TechnicalInspection).HasColumnType("date");
            entity.Property(e => e.ToAirplaneTypeId).HasColumnName("ToAirplaneTypeID");

            entity.HasOne(d => d.ToAirplaneType).WithMany(p => p.Airplanes)
                .HasForeignKey(d => d.ToAirplaneTypeId)
                .HasConstraintName("FK__Airplane__ToAirp__4222D4EF");
        });

        modelBuilder.Entity<AirplaneType>(entity =>
        {
            entity.HasKey(e => e.AirplaneTypeId).HasName("PK__Airplane__DC2C8DCD83CBFD1E");

            entity.ToTable("AirplaneType");

            entity.Property(e => e.AirplaneTypeId).HasColumnName("AirplaneTypeID");
            entity.Property(e => e.AirplaneTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Boss>(entity =>
        {
            entity.HasKey(e => e.BossId).HasName("PK__Boss__07C93FD68A3B8CDE");

            entity.ToTable("Boss");

            entity.Property(e => e.BossId).HasColumnName("BossID");
            entity.Property(e => e.Firstname).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("money");
        });

        modelBuilder.Entity<Brigade>(entity =>
        {
            entity.HasKey(e => e.BrigadeId).HasName("PK__Brigade__BEF4D27A52C58517");

            entity.ToTable("Brigade");

            entity.Property(e => e.BrigadeId).HasColumnName("BrigadeID");
            entity.Property(e => e.BrigadeAirplaneId).HasColumnName("BrigadeAirplaneID");
            entity.Property(e => e.BrigadeBossId).HasColumnName("BrigadeBossID");

            entity.HasOne(d => d.BrigadeAirplane).WithMany(p => p.Brigades)
                .HasForeignKey(d => d.BrigadeAirplaneId)
                .HasConstraintName("FK__Brigade__Brigade__44FF419A");

            entity.HasOne(d => d.BrigadeBoss).WithMany(p => p.Brigades)
                .HasForeignKey(d => d.BrigadeBossId)
                .HasConstraintName("FK__Brigade__Brigade__45F365D3");
        });

        modelBuilder.Entity<CanceledFlight>(entity =>
        {
            entity.HasKey(e => e.CanceledFlightId).HasName("PK__Canceled__3545C725C132F74B");

            entity.Property(e => e.CanceledFlightId).HasColumnName("CanceledFlightID");
            entity.Property(e => e.FlightId).HasColumnName("FlightID");
            entity.Property(e => e.Reason).HasMaxLength(50);

            entity.HasOne(d => d.Flight).WithMany(p => p.CanceledFlights)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK__CanceledF__Fligh__5BE2A6F2");
        });

        modelBuilder.Entity<Cashier>(entity =>
        {
            entity.HasKey(e => e.CashierId).HasName("PK__Cashier__C58D14B6E0343217");

            entity.ToTable("Cashier");

            entity.Property(e => e.CashierId).HasColumnName("CashierID");
            entity.Property(e => e.AccountantEducation).HasMaxLength(50);
            entity.Property(e => e.CashierEmployeeId).HasColumnName("CashierEmployeeID");

            entity.HasOne(d => d.CashierEmployee).WithMany(p => p.Cashiers)
                .HasForeignKey(d => d.CashierEmployeeId)
                .HasConstraintName("FK__Cashier__Cashier__07C12930");
        });

        modelBuilder.Entity<Dispatcher>(entity =>
        {
            entity.HasKey(e => e.DispatcherId).HasName("PK__Dispatch__EB9ED16407A58A7D");

            entity.ToTable("Dispatcher");

            entity.Property(e => e.DispatcherId).HasColumnName("DispatcherID");
            entity.Property(e => e.DispatcherEmployeeId).HasColumnName("DispatcherEmployeeID");
            entity.Property(e => e.Education).HasMaxLength(50);

            entity.HasOne(d => d.DispatcherEmployee).WithMany(p => p.Dispatchers)
                .HasForeignKey(d => d.DispatcherEmployeeId)
                .HasConstraintName("FK__Dispatche__Dispa__04E4BC85");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1CA6D10F5");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeBrigadeId).HasColumnName("EmployeeBrigadeID");
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("money");

            entity.HasOne(d => d.EmployeeBrigade).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmployeeBrigadeId)
                .HasConstraintName("FK__Employee__Employ__7C4F7684");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__Flight__8A9E148EC953FEE6");

            entity.ToTable("Flight");

            entity.Property(e => e.FlightId).HasColumnName("FlightID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.FlightAirplaneTypeId).HasColumnName("FlightAirplaneTypeID");
            entity.Property(e => e.FlightBrigadeId).HasColumnName("FlightBrigadeID");
            entity.Property(e => e.PlaceFrom).HasMaxLength(50);
            entity.Property(e => e.PlaceTo).HasMaxLength(50);

            entity.HasOne(d => d.FlightAirplaneType).WithMany(p => p.Flights)
                .HasForeignKey(d => d.FlightAirplaneTypeId)
                .HasConstraintName("FK__Flight__FlightAi__5812160E");

            entity.HasOne(d => d.FlightBrigade).WithMany(p => p.Flights)
                .HasForeignKey(d => d.FlightBrigadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Flight__FlightBr__59063A47");
        });

        modelBuilder.Entity<Passenger>(entity =>
        {
            entity.HasKey(e => e.PassengerId).HasName("PK__Passenge__88915F90950574D0");

            entity.ToTable("Passenger", tb =>
                {
                    tb.HasTrigger("Добавление");
                    tb.HasTrigger("Изменение");
                    tb.HasTrigger("Удаление");
                });

            entity.Property(e => e.PassengerId).HasColumnName("PassengerID");
            entity.Property(e => e.Age).HasDefaultValueSql("('18')");
            entity.Property(e => e.Firstname).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Lastname).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
        });

        modelBuilder.Entity<Pilot>(entity =>
        {
            entity.HasKey(e => e.PilotId).HasName("PK__Pilot__B305516DF1901C3D");

            entity.ToTable("Pilot");

            entity.Property(e => e.PilotId).HasColumnName("PilotID");
            entity.Property(e => e.PilotEmployeeId).HasColumnName("PilotEmployeeID");

            entity.HasOne(d => d.PilotEmployee).WithMany(p => p.Pilots)
                .HasForeignKey(d => d.PilotEmployeeId)
                .HasConstraintName("FK__Pilot__PilotEmpl__7F2BE32F");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Schedule__9C8A5B6935CB8AB9");

            entity.ToTable("Schedule");

            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.ScheduleFlightId).HasColumnName("ScheduleFlightID");

            entity.HasOne(d => d.ScheduleFlight).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ScheduleFlightId)
                .HasConstraintName("FK__Schedule__Schedu__628FA481");

            entity.HasMany(d => d.Airplanes).WithMany(p => p.Schedules)
                .UsingEntity<Dictionary<string, object>>(
                    "ScheduleAirplane",
                    r => r.HasOne<Airplane>().WithMany()
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Schedule_Airplane_Airplane"),
                    l => l.HasOne<Schedule>().WithMany()
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("FK_Schedule_Airplane_Schedule"),
                    j =>
                    {
                        j.HasKey("ScheduleId", "AirplaneId");
                        j.ToTable("Schedule_Airplane");
                        j.IndexerProperty<int>("ScheduleId").HasColumnName("ScheduleID");
                        j.IndexerProperty<int>("AirplaneId").HasColumnName("AirplaneID");
                    });
        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity.HasKey(e => e.SecurityId).HasName("PK__Security__9F8B0950ED9788E6");

            entity.ToTable("Security");

            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.Education).HasMaxLength(50);
            entity.Property(e => e.SecurityEmployeeId).HasColumnName("SecurityEmployeeID");

            entity.HasOne(d => d.SecurityEmployee).WithMany(p => p.Securities)
                .HasForeignKey(d => d.SecurityEmployeeId)
                .HasConstraintName("FK__Security__Securi__0D7A0286");
        });

        modelBuilder.Entity<Stewardess>(entity =>
        {
            entity.HasKey(e => e.StewardessId).HasName("PK__Stewarde__3EAD338B30C967D1");

            entity.ToTable("Stewardess");

            entity.Property(e => e.StewardessId).HasColumnName("StewardessID");
            entity.Property(e => e.ForeignLanguage).HasMaxLength(50);
            entity.Property(e => e.StewardessEmployeeId).HasColumnName("StewardessEmployeeID");

            entity.HasOne(d => d.StewardessEmployee).WithMany(p => p.Stewardesses)
                .HasForeignKey(d => d.StewardessEmployeeId)
                .HasConstraintName("FK__Stewardes__Stewa__0A9D95DB");
        });

        modelBuilder.Entity<Technician>(entity =>
        {
            entity.HasKey(e => e.TechnicianId).HasName("PK__Technici__301F82C1F1F1C249");

            entity.ToTable("Technician");

            entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");
            entity.Property(e => e.Education).HasMaxLength(50);
            entity.Property(e => e.TechnicianEmployeeId).HasColumnName("TechnicianEmployeeID");

            entity.HasOne(d => d.TechnicianEmployee).WithMany(p => p.Technicians)
                .HasForeignKey(d => d.TechnicianEmployeeId)
                .HasConstraintName("FK__Technicia__Techn__02084FDA");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Ticket__712CC6271E0C0F31");

            entity.ToTable("Ticket");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.DateOf).HasColumnType("date");
            entity.Property(e => e.PriceOf).HasColumnType("money");
            entity.Property(e => e.Seat).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TicketFlightId).HasColumnName("TicketFlightID");
            entity.Property(e => e.TicketPassengerId).HasColumnName("TicketPassengerID");

            entity.HasOne(d => d.TicketFlight).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.TicketFlightId)
                .HasConstraintName("FK__Ticket__TicketFl__5FB337D6");

            entity.HasOne(d => d.TicketPassenger).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.TicketPassengerId)
                .HasConstraintName("FK__Ticket__TicketPa__5EBF139D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
