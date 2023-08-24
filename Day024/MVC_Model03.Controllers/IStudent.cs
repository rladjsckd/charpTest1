using MVC_Model03.Models;

namespace MVC_Model03.Repository
{
    public interface IStudent
    {
        //만들고자 하는 기능!!!
        //1.전체검색
        List<Car>getAllStudents();
        //2.특정 ID만 검색하고 싶어
        Car getStudentByID(int id);
    }
}
