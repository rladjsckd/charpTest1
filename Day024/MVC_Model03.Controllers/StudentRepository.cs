using MVC_Model03.Models;

namespace MVC_Model03.Repository
{
    public class StudentRepository : IStudent
    {

        public List<Car> getAllStudents()
        {
            return DataSource();
        }
        public Car getStudentByID(int id)
        {
            return DataSource().Where(x => x.ID ==id).FirstOrDefault();
        }
        private List<Car> DataSource() 
        {
            var cars = new List<Car>()
            {
                new Car {ID =1, Brand="그랜저", Speed = 220},
                new Car {ID =2, Brand="아반떼", Speed = 200},
                new Car {ID =3, Brand="BMW", Speed = 250},
            };
            return cars;
        }
    }
}
