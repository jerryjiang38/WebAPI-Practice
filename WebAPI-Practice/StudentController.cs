using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//5_1-目標：透過Json，傳入學生與老師資料
public class Student
{
    public string Student1 { get; set; }
    public string Student2 { get; set; }
    public string Student3 { get; set; }
    public string Student4 { get; set; }
    public Teacher Teacher { get; set; }
}
public class Teacher
{
    public string Teacher1 { get; set; }
}
[Route("[controller]")]
public class StudentController
{
    [HttpGet("get")] //在/student/get取得
    public string Get([FromBody] Student student) //不管甚麼類型盡量都加上[From...]，快速了解傳入來源
    {
        return $"{student.Student1} {student.Student2} {student.Student3} {student.Student4} {student.Teacher.Teacher1}";
    }
}
/* 選擇Body->raw->JSON，輸入以下JSON
{
    "Student1":"jerry",
    "Student2":"nick",
    "Student3":"oscar",
    "Student4":"sherry",
    "Teacher":{
        "Teacher1":"Vern"
    }
}
 */