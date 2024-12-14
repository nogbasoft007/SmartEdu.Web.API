using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace SmartEdu.SDT.Api.Controller.Students
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly string _connectionString = "YourDatabaseConnectionStringHere";

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            List<Student> students = new List<Student>();

            students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2005, 5, 15),
                    Class = "10",
                    Section = "A",
                    Gender = "Male",
                    Address = "123 Main St",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    GuardianName = "Jane Doe",
                    EnrollmentDate = new DateTime(2021, 8, 1)
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Alice",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(2006, 10, 22),
                    Class = "10",
                    Section = "B",
                    Gender = "Female",
                    Address = "456 Oak St",
                    Email = "alice.smith@example.com",
                    PhoneNumber = "987-654-3210",
                    GuardianName = "Bob Smith",
                    EnrollmentDate = new DateTime(2021, 8, 1)
                }
            };
            //using (SqlConnection conn = new SqlConnection(_connectionString))
            //{
            //    string query = "SELECT StudentId, Name, Age, Class FROM Students";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    conn.Open();
            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            students.Add(new Student
            //            {
            //                StudentId = reader.GetInt32(0),
            //                Name = reader.GetString(1),
            //                Age = reader.GetInt32(2),
            //                Class = reader.GetString(3)
            //            });
            //        }
            //    }
            //}
            return Ok(students);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetStudentById(int id)
        //{
        //    Student student = null;
        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    {
        //        string query = "SELECT StudentId, Name, Age, Class FROM Students WHERE StudentId = @StudentId";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@StudentId", id);
        //        conn.Open();
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                student = new Student
        //                {
        //                    StudentId = reader.GetInt32(0),
        //                    Name = reader.GetString(1),
        //                    Age = reader.GetInt32(2),
        //                    Class = reader.GetString(3)
        //                };
        //            }
        //        }
        //    }
        //    if (student == null) return NotFound("Student not found.");
        //    return Ok(student);
        //}

        //[HttpPost]
        //public IActionResult CreateStudent([FromBody] Student student)
        //{
        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    {
        //        string query = "INSERT INTO Students (Name, Age, Class) VALUES (@Name, @Age, @Class)";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@Name", student.Name);
        //        cmd.Parameters.AddWithValue("@Age", student.Age);
        //        cmd.Parameters.AddWithValue("@Class", student.Class);
        //        conn.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        if (rowsAffected > 0) return Ok("Student created successfully.");
        //    }
        //    return BadRequest("Failed to create student.");
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateStudent(int id, [FromBody] Student student)
        //{
        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    {
        //        string query = "UPDATE Students SET Name = @Name, Age = @Age, Class = @Class WHERE StudentId = @StudentId";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@StudentId", id);
        //        cmd.Parameters.AddWithValue("@Name", student.Name);
        //        cmd.Parameters.AddWithValue("@Age", student.Age);
        //        cmd.Parameters.AddWithValue("@Class", student.Class);
        //        conn.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        if (rowsAffected > 0) return Ok("Student updated successfully.");
        //    }
        //    return NotFound("Student not found.");
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteStudent(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    {
        //        string query = "DELETE FROM Students WHERE StudentId = @StudentId";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@StudentId", id);
        //        conn.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        if (rowsAffected > 0) return Ok("Student deleted successfully.");
        //    }
        //    return NotFound("Student not found.");
        //}
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Class { get; set; }
            public string Section { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string GuardianName { get; set; }
            public DateTime EnrollmentDate { get; set; }
        }
    }
}
