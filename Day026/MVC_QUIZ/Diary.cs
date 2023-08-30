using System.ComponentModel.DataAnnotations;

namespace MVC_203_08_30QUIZ.Models
{
    public class Diary
    {
        [Key]
        public int No { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Content {get; set;}
        public string Title { get; set;}
    }
}
