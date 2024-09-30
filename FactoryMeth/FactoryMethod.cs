using FactoryMeth.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeth
{
    public abstract class FactoryMethod
    {
        public static Entity CreateEntity(string line)
        {
            Console.WriteLine(line);
            string[] parameters = line.Split(new[] { ", " }, StringSplitOptions.None);
            string entityType = parameters[0].Split(' ')[0].Trim().ToLower();
            int id = int.Parse(parameters[0].Split('=')[1].Trim());
            string name = parameters[1].Split('=')[1].Trim();
            switch (entityType)
            {
                case "student":
                    var studentCourses = parameters[2].Split('=')[1].Trim().Split(',').Select(int.Parse).ToList();
                    return new Student(id, name, studentCourses);
                case "teacher":
                    int experience = int.Parse(parameters[2].Split('=')[1].Trim());
                    var teacherCourses = parameters[3].Split('=')[1].Trim().Split(',').Select(int.Parse).ToList();
                    return new Teacher(id, name, experience, teacherCourses);
                case "course":
                    int teacherId = int.Parse(parameters[2].Split('=')[1].Trim());
                    var studentIds = parameters[3].Split('=')[1].Trim().Split(',').Select(int.Parse).ToList();
                    return new Course(id, name, teacherId, studentIds);
                default:
                    throw new Exception("Неизвестный объект");
            }
        }
    }
}
