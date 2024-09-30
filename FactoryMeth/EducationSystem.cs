using FactoryMeth.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeth
{
    public class EducationSystem
    {
        private string filePath = "mydb.txt";
        public static void AddEntity(string line)
        {
            var entity = FactoryMethod.CreateEntity(line);
            EducationSystem inputHandler = new EducationSystem();
            switch (entity)
            {
                case Teacher teacher:
                    string teacherField = $"Teacher Id: {teacher.Id}, Teacher Name: {teacher.Name}, Teacher Experience: {teacher.Experience}, Teacher Courses: {string.Join(", ", teacher.Courses)}";
                    inputHandler.WriteToFile(teacherField);
                    break;
                case Student student:
                    string studentField = $"Student ID: {student.Id}, Student Name: {student.Name}, Student Courses: {string.Join(", ", student.Courses)}";
                    inputHandler.WriteToFile(studentField);
                    break;
                case Course course:
                    string courseField = $"Course ID: {course.Id}, Course Name: {course.Name}, Student Ids: {string.Join(", ", course.StudentIds)}, Teacher Id: {course.TeacherId}";
                    inputHandler.WriteToFile(courseField);
                    break;
                default:
                    throw new Exception("Неизвестный объект");
            }
        }
        public void WriteToFile(string entry)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(entry);
            }
        }

        public void ReadFile()
        {
            foreach (var line in File.ReadLines(filePath))
            {
                Console.WriteLine(line);
            }
        }
    }
}
