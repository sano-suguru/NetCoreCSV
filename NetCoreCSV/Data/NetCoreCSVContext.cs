using Microsoft.EntityFrameworkCore;
using NetCoreCSV.Models;
using System;

namespace NetCoreCSV.Data {
  public class NetCoreCSVContext : DbContext {
    public NetCoreCSVContext(DbContextOptions<NetCoreCSVContext> options)
      : base(options) { }

    public DbSet<Member> Members { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      modelBuilder.Entity<Member>().HasData(
        new Member {
          Id = 1,
          FullName = "織田信長",
          Country = "尾張",
          Email = "Dai6Tenmao@exsample.com",
          CreatedAt = DateTime.Parse("2017/08/15 20:11:05")
        },
        new Member {
          Id = 2,
          FullName = "豊臣秀吉",
          Country = "尾張",
          Email = "saru-waraji@exsample.com",
          CreatedAt = DateTime.Parse("2017/09/20 23:47:08")
        },
        new Member {
          Id = 3,
          FullName = "徳川家康",
          Country = "三河",
          Email = "kaido.yumitori@exsample.com",
          CreatedAt = DateTime.Parse("2017/12/30 09:08:12")
        }
      );
    }
  }
}
