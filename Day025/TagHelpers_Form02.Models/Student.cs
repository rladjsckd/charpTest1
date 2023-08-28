using System.Reflection;

namespace TagHelpers_Form02.Models
{
    public class Student
    {
        public string Major { get; set; }
        public string Name { get; set; }
        public Graduation Graduation { get; set; }
        public string Hp { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public Discharge Discharge { get; set; }
        public Satisfaction Satisfaction { get; set; }
    }
    public enum Gender
    {
        남,
        여
    }
    public enum Discharge 
    {
        군필,
        미필,
        관계없음
    }
    public enum Graduation
    {
        졸업,
        재학,
        휴학
    }
    public enum Satisfaction 
    {
        매우만족,
        만족,
        보통,
        불만족,
        매우불만족
    }
}
