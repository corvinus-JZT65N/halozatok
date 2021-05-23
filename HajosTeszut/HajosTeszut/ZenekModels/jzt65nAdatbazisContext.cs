using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class jzt65nAdatbazisContext : DbContext
    {
        public jzt65nAdatbazisContext()
        {
        }

        public jzt65nAdatbazisContext(DbContextOptions<jzt65nAdatbazisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beosztasok> Beosztasoks { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Diak> Diaks { get; set; }
        public virtual DbSet<Dvd> Dvds { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<ErőforrásFoglalá> ErőforrásFoglalás { get; set; }
        public virtual DbSet<Erőforrásgazdák> Erőforrásgazdáks { get; set; }
        public virtual DbSet<Erőforrások> Erőforrásoks { get; set; }
        public virtual DbSet<Foglala> Foglalas { get; set; }
        public virtual DbSet<HálóBeoKedvencZeneszámok> HálóBeoKedvencZeneszámoks { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Jzt655nVfoglalasreszletek> Jzt655nVfoglalasreszleteks { get; set; }
        public virtual DbSet<Kolcsonzesek> Kolcsonzeseks { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Munka> Munkas { get; set; }
        public virtual DbSet<Munkaado> Munkaados { get; set; }
        public virtual DbSet<Napok> Napoks { get; set; }
        public virtual DbSet<Nyelvek> Nyelveks { get; set; }
        public virtual DbSet<Oktatok> Oktatoks { get; set; }
        public virtual DbSet<Orak> Oraks { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Projektek> Projekteks { get; set; }
        public virtual DbSet<Raktar> Raktars { get; set; }
        public virtual DbSet<Rendele> Rendeles { get; set; }
        public virtual DbSet<RendelesTetel> RendelesTetels { get; set; }
        public virtual DbSet<Rendszerek> Rendszereks { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Savok> Savoks { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Statusok> Statusoks { get; set; }
        public virtual DbSet<Student2> Student2s { get; set; }
        public virtual DbSet<StudentOld> StudentOlds { get; set; }
        public virtual DbSet<Szallashely> Szallashelies { get; set; }
        public virtual DbSet<Szoba> Szobas { get; set; }
        public virtual DbSet<Tagok> Tagoks { get; set; }
        public virtual DbSet<Tantermek> Tantermeks { get; set; }
        public virtual DbSet<Tantárgyak> Tantárgyaks { get; set; }
        public virtual DbSet<Termek> Termeks { get; set; }
        public virtual DbSet<Termekkategorium> Termekkategoria { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<Ugyfel> Ugyfels { get; set; }
        public virtual DbSet<UjaenbVszoba> UjaenbVszobas { get; set; }
        public virtual DbSet<Vendeg> Vendegs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=jzt65nkiszolgalo.database.windows.net;Initial Catalog=jzt65nAdatbazis;User ID=hallgato;Password=ASDasd123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Beosztasok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Beosztasok");

                entity.Property(e => e.BeosztasId).HasColumnName("beosztas_id");

                entity.Property(e => e.Beosztasnev)
                    .HasMaxLength(50)
                    .HasColumnName("beosztasnev");

                entity.Property(e => e.Elvart).HasColumnName("elvart");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("Day");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Diak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("diak");

                entity.Property(e => e.Nev).HasMaxLength(50);

                entity.Property(e => e.Szulido).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dvd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dvd");

                entity.Property(e => e.Cim)
                    .HasMaxLength(255)
                    .HasColumnName("cim");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lang).HasColumnName("lang");

                entity.Property(e => e.Nettoar).HasColumnName("nettoar");

                entity.Property(e => e.RaktárKészlet).HasColumnName("raktár készlet");

                entity.Property(e => e.Stilus)
                    .HasMaxLength(255)
                    .HasColumnName("stilus");

                entity.Property(e => e.Szam)
                    .HasMaxLength(255)
                    .HasColumnName("szam");
            });

            modelBuilder.Entity<Employment>(entity =>
            {
                entity.ToTable("Employment");

                entity.Property(e => e.EmploymentId)
                    .HasMaxLength(1)
                    .HasColumnName("EmploymentID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ErőforrásFoglalá>(entity =>
            {
                entity.HasKey(e => e.FoglalásId);

                entity.Property(e => e.FoglalásId).HasColumnName("FoglalásID");

                entity.Property(e => e.ErőforrásFk).HasColumnName("ErőforrásFK");

                entity.Property(e => e.FoglalásKezdete).HasColumnType("date");

                entity.Property(e => e.FoglalásVége).HasColumnType("date");

                entity.Property(e => e.ProjektFk).HasColumnName("ProjektFK");

                entity.HasOne(d => d.ErőforrásFkNavigation)
                    .WithMany(p => p.ErőforrásFoglalás)
                    .HasForeignKey(d => d.ErőforrásFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ErőforrásFoglalás_ToErőforrások");

                entity.HasOne(d => d.ProjektFkNavigation)
                    .WithMany(p => p.ErőforrásFoglalás)
                    .HasForeignKey(d => d.ProjektFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ErőforrásFoglalás_ToProjektek");
            });

            modelBuilder.Entity<Erőforrásgazdák>(entity =>
            {
                entity.HasKey(e => e.ErőforrásgazdaId);

                entity.ToTable("Erőforrásgazdák");

                entity.Property(e => e.ErőforrásgazdaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ErőforrásgazdaID");

                entity.Property(e => e.Név)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Erőforrások>(entity =>
            {
                entity.HasKey(e => e.ErőforrásId);

                entity.ToTable("Erőforrások");

                entity.Property(e => e.ErőforrásId).HasColumnName("ErőforrásID");

                entity.Property(e => e.ErőforrásgazdaFk).HasColumnName("ErőforrásgazdaFK");

                entity.Property(e => e.Név)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.ErőforrásgazdaFkNavigation)
                    .WithMany(p => p.Erőforrásoks)
                    .HasForeignKey(d => d.ErőforrásgazdaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Erőforrások_ToErőforrásgazdák");
            });

            modelBuilder.Entity<Foglala>(entity =>
            {
                entity.HasKey(e => e.FoglalasPk);

                entity.Property(e => e.FoglalasPk)
                    .ValueGeneratedNever()
                    .HasColumnName("FOGLALAS_PK");

                entity.Property(e => e.FelnottSzam).HasColumnName("FELNOTT_SZAM");

                entity.Property(e => e.GyermekSzam).HasColumnName("GYERMEK_SZAM");

                entity.Property(e => e.Meddig)
                    .HasColumnType("date")
                    .HasColumnName("MEDDIG");

                entity.Property(e => e.Mettol)
                    .HasColumnType("date")
                    .HasColumnName("METTOL");

                entity.Property(e => e.SzobaFk).HasColumnName("SZOBA_FK");

                entity.Property(e => e.UgyfelFk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UGYFEL_FK");

                entity.HasOne(d => d.SzobaFkNavigation)
                    .WithMany(p => p.Foglalas)
                    .HasForeignKey(d => d.SzobaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foglalas_Szoba");

                entity.HasOne(d => d.UgyfelFkNavigation)
                    .WithMany(p => p.Foglalas)
                    .HasForeignKey(d => d.UgyfelFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foglalas_Vendeg");
            });

            modelBuilder.Entity<HálóBeoKedvencZeneszámok>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("HálóBeoKedvencZeneszámok");

                entity.Property(e => e.Cím)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Előadó)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InstructorSk)
                    .HasName("PK__tmp_ms_x__9D017A283E8CE057");

                entity.ToTable("Instructor");

                entity.Property(e => e.InstructorSk).HasColumnName("InstructorSK");

                entity.Property(e => e.EmploymentFk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("EmploymentFK")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(7)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusFk).HasColumnName("StatusFK");

                entity.HasOne(d => d.EmploymentFkNavigation)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.EmploymentFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instructor_ToEmployment");

                entity.HasOne(d => d.StatusFkNavigation)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.StatusFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instructor_ToStatus");
            });

            modelBuilder.Entity<Jzt655nVfoglalasreszletek>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("JZT655N_VFoglalasreszletek");

                entity.Property(e => e.Elhelyezkedés)
                    .HasMaxLength(20)
                    .HasColumnName("elhelyezkedés");

                entity.Property(e => e.FoglalásAzonosító).HasColumnName("foglalás_azonosító");

                entity.Property(e => e.Meddig)
                    .HasColumnType("date")
                    .HasColumnName("meddig");

                entity.Property(e => e.Mettől)
                    .HasColumnType("date")
                    .HasColumnName("mettől");

                entity.Property(e => e.SzobákSzáma)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("szobák_száma");

                entity.Property(e => e.Szállás)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("szállás");

                entity.Property(e => e.Vendég)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vendég");
            });

            modelBuilder.Entity<Kolcsonzesek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kolcsonzesek");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ki).HasColumnName("ki");

                entity.Property(e => e.KiDatum)
                    .HasColumnType("date")
                    .HasColumnName("ki_datum");

                entity.Property(e => e.Mit).HasColumnName("mit");

                entity.Property(e => e.VisszaDatum)
                    .HasColumnType("date")
                    .HasColumnName("vissza_datum");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.LessonSk)
                    .HasName("PK__Lesson__B08512E248F14D59");

                entity.ToTable("Lesson");

                entity.Property(e => e.LessonSk).HasColumnName("LessonSK");

                entity.Property(e => e.DayFk).HasColumnName("DayFK");

                entity.Property(e => e.InstructorFk).HasColumnName("InstructorFK");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.RoomFk).HasColumnName("RoomFK");

                entity.Property(e => e.TimeFk).HasColumnName("TimeFK");

                entity.HasOne(d => d.DayFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.DayFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_ToDay");

                entity.HasOne(d => d.InstructorFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.InstructorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_ToInstructor");

                entity.HasOne(d => d.RoomFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.RoomFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_ToRoom");

                entity.HasOne(d => d.TimeFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.TimeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_ToTime");
            });

            modelBuilder.Entity<Munka>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("munka");

                entity.Property(e => e.Allas)
                    .HasMaxLength(50)
                    .HasColumnName("allas");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Kozepiskolas).HasColumnName("kozepiskolas");

                entity.Property(e => e.MunkaId).HasColumnName("munkaId");

                entity.Property(e => e.Oradij).HasColumnName("oradij");

                entity.Property(e => e.Oraszam).HasColumnName("oraszam");
            });

            modelBuilder.Entity<Munkaado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("munkaado");

                entity.Property(e => e.MhelyId).HasColumnName("MHelyID");

                entity.Property(e => e.MunkaadoNev)
                    .HasMaxLength(50)
                    .HasColumnName("Munkaado_nev");

                entity.Property(e => e.Telepules).HasMaxLength(50);
            });

            modelBuilder.Entity<Napok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Napok");

                entity.Property(e => e.Nap)
                    .HasMaxLength(50)
                    .HasColumnName("nap");

                entity.Property(e => e.NapId).HasColumnName("nap_id");
            });

            modelBuilder.Entity<Nyelvek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nyelvek");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lang)
                    .HasMaxLength(255)
                    .HasColumnName("lang");
            });

            modelBuilder.Entity<Oktatok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Oktatok");

                entity.Property(e => e.Beosztás).HasColumnName("beosztás");

                entity.Property(e => e.Nev)
                    .HasMaxLength(50)
                    .HasColumnName("nev");

                entity.Property(e => e.OktatoId).HasColumnName("oktato_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Titulus)
                    .HasMaxLength(50)
                    .HasColumnName("titulus");
            });

            modelBuilder.Entity<Orak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orak");

                entity.Property(e => e.Nap).HasColumnName("nap");

                entity.Property(e => e.OraId).HasColumnName("ora_id");

                entity.Property(e => e.Tanar).HasColumnName("tanar");

                entity.Property(e => e.Targy).HasColumnName("targy");

                entity.Property(e => e.Terem).HasColumnName("terem");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PersonSk);

                entity.ToTable("Person");

                entity.Property(e => e.PersonSk).HasColumnName("PersonSK");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Neptun)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonalNumber).HasMaxLength(9);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.TaxNumber).HasMaxLength(13);
            });

            modelBuilder.Entity<Projektek>(entity =>
            {
                entity.HasKey(e => e.ProjektId);

                entity.ToTable("Projektek");

                entity.Property(e => e.ProjektId).HasColumnName("ProjektID");

                entity.Property(e => e.MenedzserNév).HasMaxLength(25);

                entity.Property(e => e.Név)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.RendszerFk).HasColumnName("RendszerFK");

                entity.HasOne(d => d.RendszerFkNavigation)
                    .WithMany(p => p.Projekteks)
                    .HasForeignKey(d => d.RendszerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projektek_ToRendszerek");
            });

            modelBuilder.Entity<Raktar>(entity =>
            {
                entity.HasKey(e => e.RaktarKod);

                entity.ToTable("Raktar");

                entity.HasIndex(e => e.RaktarKod, "IX_Raktar")
                    .IsUnique();

                entity.Property(e => e.RaktarKod)
                    .ValueGeneratedNever()
                    .HasColumnName("RAKTAR_KOD");

                entity.Property(e => e.RaktarCim)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("RAKTAR_CIM");

                entity.Property(e => e.RaktarNev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("RAKTAR_NEV");
            });

            modelBuilder.Entity<Rendele>(entity =>
            {
                entity.HasKey(e => e.Sorszam);

                entity.Property(e => e.Sorszam)
                    .ValueGeneratedNever()
                    .HasColumnName("SORSZAM");

                entity.Property(e => e.FizMod)
                    .HasMaxLength(255)
                    .HasColumnName("FIZ_MOD");

                entity.Property(e => e.Login)
                    .HasMaxLength(255)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.RendDatum)
                    .HasColumnType("date")
                    .HasColumnName("REND_DATUM");

                entity.Property(e => e.SzallCim)
                    .HasMaxLength(255)
                    .HasColumnName("SZALL_CIM");

                entity.Property(e => e.SzallDatum)
                    .HasColumnType("date")
                    .HasColumnName("SZALL_DATUM");

                entity.Property(e => e.SzallMod)
                    .HasMaxLength(255)
                    .HasColumnName("SZALL_MOD");

                entity.Property(e => e.SzamlaCim)
                    .HasMaxLength(255)
                    .HasColumnName("SZAMLA_CIM");

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.Rendeles)
                    .HasForeignKey(d => d.Login)
                    .HasConstraintName("FK_Rendeles_Ugyfel");
            });

            modelBuilder.Entity<RendelesTetel>(entity =>
            {
                entity.HasKey(e => new { e.Sorszam, e.Termekkod });

                entity.ToTable("Rendeles_tetel");

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.Termekkod)
                    .HasMaxLength(255)
                    .HasColumnName("TERMEKKOD");

                entity.Property(e => e.Egysegar).HasColumnName("EGYSEGAR");

                entity.Property(e => e.Mennyiseg).HasColumnName("MENNYISEG");

                entity.HasOne(d => d.SorszamNavigation)
                    .WithMany(p => p.RendelesTetels)
                    .HasForeignKey(d => d.Sorszam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rendeles_tetel_Rendeles");

                entity.HasOne(d => d.TermekkodNavigation)
                    .WithMany(p => p.RendelesTetels)
                    .HasForeignKey(d => d.Termekkod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rendeles_tetel_Termek");
            });

            modelBuilder.Entity<Rendszerek>(entity =>
            {
                entity.HasKey(e => e.RendszerId);

                entity.ToTable("Rendszerek");

                entity.Property(e => e.RendszerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RendszerID");

                entity.Property(e => e.Név)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomSk)
                    .HasName("PK__Room__328616CFF0E94F5E");

                entity.ToTable("Room");

                entity.Property(e => e.RoomSk).HasColumnName("RoomSK");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Savok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Savok");

                entity.Property(e => e.Időpont).HasMaxLength(50);

                entity.Property(e => e.Sav).HasMaxLength(50);

                entity.Property(e => e.SavId).HasColumnName("Sav_id");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Statusok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("statusok");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Student2>(entity =>
            {
                entity.ToTable("Student2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AverageGrade).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Neptun)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StudentOld>(entity =>
            {
                entity.ToTable("StudentOld");

                entity.Property(e => e.AverageGrade).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Neptun)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Szallashely>(entity =>
            {
                entity.HasKey(e => e.SzallasId);

                entity.ToTable("Szallashely");

                entity.Property(e => e.SzallasId)
                    .ValueGeneratedNever()
                    .HasColumnName("SZALLAS_ID");

                entity.Property(e => e.Cim)
                    .HasMaxLength(100)
                    .HasColumnName("CIM");

                entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");

                entity.Property(e => e.Hely)
                    .HasMaxLength(20)
                    .HasColumnName("HELY");

                entity.Property(e => e.RogzIdo)
                    .HasColumnType("date")
                    .HasColumnName("ROGZ_IDO");

                entity.Property(e => e.Rogzitette)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ROGZITETTE");

                entity.Property(e => e.SzallasNev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SZALLAS_NEV");

                entity.Property(e => e.Tipus)
                    .HasMaxLength(50)
                    .HasColumnName("TIPUS");
            });

            modelBuilder.Entity<Szoba>(entity =>
            {
                entity.ToTable("Szoba");

                entity.Property(e => e.SzobaId)
                    .ValueGeneratedNever()
                    .HasColumnName("SZOBA_ID");

                entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");

                entity.Property(e => e.Klimas)
                    .HasMaxLength(1)
                    .HasColumnName("KLIMAS");

                entity.Property(e => e.Potagy).HasColumnName("POTAGY");

                entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");

                entity.Property(e => e.SzobaSzama)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SZOBA_SZAMA");

                entity.HasOne(d => d.SzallasFkNavigation)
                    .WithMany(p => p.Szobas)
                    .HasForeignKey(d => d.SzallasFk)
                    .HasConstraintName("FK_Szoba_Szallashely");
            });

            modelBuilder.Entity<Tagok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tagok");

                entity.Property(e => e.Cim)
                    .HasMaxLength(255)
                    .HasColumnName("cim");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kedvencnyelv).HasColumnName("kedvencnyelv");

                entity.Property(e => e.Kedvencstilus)
                    .HasMaxLength(50)
                    .HasColumnName("kedvencstilus");

                entity.Property(e => e.Nev)
                    .HasMaxLength(255)
                    .HasColumnName("nev");
            });

            modelBuilder.Entity<Tantermek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tantermek");

                entity.Property(e => e.Terem).HasMaxLength(50);
            });

            modelBuilder.Entity<Tantárgyak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tantárgyak");

                entity.Property(e => e.Tantargykod).HasMaxLength(50);

                entity.Property(e => e.Tantárgynév).HasMaxLength(50);
            });

            modelBuilder.Entity<Termek>(entity =>
            {
                entity.HasKey(e => e.Termekkod);

                entity.ToTable("Termek");

                entity.Property(e => e.Termekkod)
                    .HasMaxLength(255)
                    .HasColumnName("TERMEKKOD");

                entity.Property(e => e.Felvitel)
                    .HasColumnType("date")
                    .HasColumnName("FELVITEL");

                entity.Property(e => e.Felvitte)
                    .HasMaxLength(255)
                    .HasColumnName("FELVITTE");

                entity.Property(e => e.KatId).HasColumnName("KAT_ID");

                entity.Property(e => e.Keszlet).HasColumnName("KESZLET");

                entity.Property(e => e.Leiras)
                    .HasMaxLength(255)
                    .HasColumnName("LEIRAS");

                entity.Property(e => e.Listaar).HasColumnName("LISTAAR");

                entity.Property(e => e.Megnevezes)
                    .HasMaxLength(255)
                    .HasColumnName("MEGNEVEZES");

                entity.Property(e => e.Megys)
                    .HasMaxLength(255)
                    .HasColumnName("MEGYS");

                entity.Property(e => e.RaktarKod).HasColumnName("RAKTAR_KOD");

                entity.HasOne(d => d.Kat)
                    .WithMany(p => p.Termeks)
                    .HasForeignKey(d => d.KatId)
                    .HasConstraintName("FK_Termek_Termekkategoria");

                entity.HasOne(d => d.RaktarKodNavigation)
                    .WithMany(p => p.Termeks)
                    .HasForeignKey(d => d.RaktarKod)
                    .HasConstraintName("FK_Termek_Raktar");
            });

            modelBuilder.Entity<Termekkategorium>(entity =>
            {
                entity.HasKey(e => e.KatId);

                entity.HasIndex(e => e.KatNev, "utk")
                    .IsUnique();

                entity.Property(e => e.KatId)
                    .ValueGeneratedNever()
                    .HasColumnName("KAT_ID");

                entity.Property(e => e.KatNev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("KAT_NEV");

                entity.Property(e => e.SzuloKat).HasColumnName("SZULO_KAT");

                entity.HasOne(d => d.SzuloKatNavigation)
                    .WithMany(p => p.InverseSzuloKatNavigation)
                    .HasForeignKey(d => d.SzuloKat)
                    .HasConstraintName("FK_Termekkategoria_Termekkategoria");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.ToTable("Time");

                entity.Property(e => e.TimeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TimeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(13)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Ugyfel>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.ToTable("Ugyfel");

                entity.Property(e => e.Login)
                    .HasMaxLength(255)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.Cim)
                    .HasMaxLength(255)
                    .HasColumnName("CIM");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nem)
                    .HasMaxLength(1)
                    .HasColumnName("NEM");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("NEV");

                entity.Property(e => e.Szulev).HasColumnName("SZULEV");
            });

            modelBuilder.Entity<UjaenbVszoba>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UJAENB_VSZOBA");

                entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");

                entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");

                entity.Property(e => e.Hely)
                    .HasMaxLength(20)
                    .HasColumnName("HELY");

                entity.Property(e => e.Klimas)
                    .HasMaxLength(1)
                    .HasColumnName("KLIMAS");

                entity.Property(e => e.Potagy).HasColumnName("POTAGY");

                entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");

                entity.Property(e => e.SzallasNev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SZALLAS_NEV");

                entity.Property(e => e.SzobaId).HasColumnName("SZOBA_ID");

                entity.Property(e => e.SzobaSzama)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SZOBA_SZAMA");
            });

            modelBuilder.Entity<Vendeg>(entity =>
            {
                entity.HasKey(e => e.Usernev);

                entity.ToTable("Vendeg");

                entity.Property(e => e.Usernev)
                    .HasMaxLength(20)
                    .HasColumnName("USERNEV");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NEV");

                entity.Property(e => e.SzamlCim)
                    .HasMaxLength(100)
                    .HasColumnName("SZAML_CIM");

                entity.Property(e => e.SzulDat)
                    .HasColumnType("date")
                    .HasColumnName("SZUL_DAT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
