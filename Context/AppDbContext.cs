using EF_HW2.Configuration;
using EF_HW2.Models;
using EntityFrameWork_Hw2.Configuration;
using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_HW2.Context;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-8V8B7U4\\MSSQLSERVER01;Initial Catalog=LibraryT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorsConfiguration());
        modelBuilder.ApplyConfiguration(new BooksConfigure());
        modelBuilder.ApplyConfiguration(new CategoryConfigure());
        modelBuilder.ApplyConfiguration(new DepartmentsConfigure());
        modelBuilder.ApplyConfiguration(new FacultiesConfigure());
        modelBuilder.ApplyConfiguration(new GroupsConfigure());
        modelBuilder.ApplyConfiguration(new LibsConfigure());
        modelBuilder.ApplyConfiguration(new PressConfigure());
        modelBuilder.ApplyConfiguration(new S_CardsConfigure());
        modelBuilder.ApplyConfiguration(new StudentsConfigure());
        modelBuilder.ApplyConfiguration(new T_CardsConfigure());
        modelBuilder.ApplyConfiguration(new TeachersConfigure());
        modelBuilder.ApplyConfiguration(new ThemesConfiguration());
    }

    public DbSet<Authors> Authorss { get; set; }
    public DbSet<Books> Bookss { get; set; }
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Departments> Departmentss { get; set; }
    public DbSet<Faculties> Facultiess { get; set; }
    public DbSet<Groups> Groupss { get; set; }
    public DbSet<Libs> Libss { get; set; }
    public DbSet<Press> Presss { get; set; }
    public DbSet<S_Cards> S_Cardss { get; set; }
    public DbSet<Students> Studentss { get; set; }
    public DbSet<T_Cards> T_Cardss { get; set; }
    public DbSet<Teachers> Teacherss { get; set; }
    public DbSet<Themes> Themess { get; set; }
}
