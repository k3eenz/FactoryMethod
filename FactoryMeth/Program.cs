using FactoryMeth;
bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("1) Создать новый объект\n2) Вывести всю информацию\n3) Выйти");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Введите тип объекта - student, teacher, course:");
            string objectType = Console.ReadLine();
            Console.WriteLine("Введите Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            switch (objectType.ToLower())
            {
                case "student":
                    Console.WriteLine("Введите Id курсов через запятую:");
                    var courseIds = Console.ReadLine().Split(',').Select(int.Parse).ToList();
                    var studentInfo = $"Student Id={id}, Name={name}, Courses={string.Join(",", courseIds)}";
                    EducationSystem.AddEntity(studentInfo);
                    break;
                case "teacher":
                    Console.WriteLine("Введите опыт работы:");
                    int experience = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите Id курсов через запятую:");
                    var teacherCourseIds = Console.ReadLine().Split(',').Select(int.Parse).ToList();
                    var teacherInfo = $"Teacher Id={id}, Name={name}, Experience={experience}, Courses={string.Join(",", teacherCourseIds)}";
                    EducationSystem.AddEntity(teacherInfo);
                    break;
                case "course":
                    Console.WriteLine("Введите Id учителя:");
                    int teacherId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите Id студентов через запятую:");
                    var studentIds = Console.ReadLine().Split(',').Select(int.Parse).ToList();
                    var courseInfo = $"Course Id={id}, Name={name}, TeacherId={teacherId}, StudentIds={string.Join(",", studentIds)}";
                    EducationSystem.AddEntity(courseInfo);
                    break;
                default:
                    Console.WriteLine("Неизвестный объект.");
                    break;
            }
            break;
        case 2:
            var educationSystem = new EducationSystem();
            educationSystem.ReadFile();
            break;
        case 3:
            isRunning = false;
            break;
        default:
            Console.WriteLine("Неверный выбор");
            break;
    }
}
