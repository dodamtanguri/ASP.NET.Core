using System;
using Microsoft.EntityFrameworkCore;
using NetCore.Data.DataModels;

namespace NetCore.Services.Data
{
    //Fluent API
    //상속
    //CodeFirstDbContext : 자식클래스
    //DbContext : 부모클래스
    public class CodeFirstDbContext : DbContext
    {
        //생성자 상속
      public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext>options) : base(options)
            {

        }
        //DB 테이블 리스트 지정
        public DbSet<User> Users { get; set; }

        //메서드 상속, 부모클래스에서 OnModelCreating 메소드가 virtual
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //4가지 작업
            //DB 테이블 변경
            modelBuilder.Entity<User>().ToTable(name: "User");


            //복합키


        }
    }
}
