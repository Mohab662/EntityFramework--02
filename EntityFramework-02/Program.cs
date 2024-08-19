using EntityFramework_02.Context;
using EntityFramework_02.Entities;

namespace EntityFramework_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SchoolDbContext schoolDbContext = new SchoolDbContext()) {

                Topic topic = new Topic() { Name = "Wep" };
                Student student = new Student() { Address = "Giza", FName = "Mohab", LName = "Belkan", Age = 20 };
                Course course = new Course()
                {
                    Name = "C#"
                    ,
                    Description = "sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss"
                    ,
                    Duration = 10
                };
                Department department = new Department()
                {
                    Name = "D1",
                };
                Instructor instructor = new Instructor()
                {
                    Name = "mohab",
                    Adress = "ssssssssssssssssss",
                    HourRate = 15,
                    Salary = 5000,
                    Bouns = 1000
                };
                Stud_Course stud_Course = new Stud_Course()
                {
                    Grade = 20
                };

                #region Add
                schoolDbContext.Student.Add(student);
                schoolDbContext.Course.Add(course);
                schoolDbContext.Department.Add(department);
                schoolDbContext.Instructor.Add(instructor);
                schoolDbContext.Topic.Add(topic);
                schoolDbContext.SaveChanges();
                #endregion

                #region Edit

                dynamic Std = schoolDbContext.Topic.Where(T => T.Id == 10).Select(E => E.Name);
                Std = "ll";

                schoolDbContext.SaveChanges();

                #endregion

                #region Delete
                schoolDbContext.Department.Remove(department);
                schoolDbContext.SaveChanges();

                #endregion
            }
        }
    }
}
