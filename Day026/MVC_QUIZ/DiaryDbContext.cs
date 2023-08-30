using Microsoft.EntityFrameworkCore;

namespace MVC_203_08_30QUIZ.Models
{
    public class DiaryDbContext : DbContext
    {
        //생성자, DB연결 초기화
        public DiaryDbContext(DbContextOptions options) : base(options)
        {

        }

        //DB연결 작업 ----> appsettings.json
        //테이블 만들기
        public DbSet<Diary> Diary { get; set; }
    }
}
