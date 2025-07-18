
using EFCoreApp.Model;
using EFCoreApp.Services;

class Program
{
    static void Main()
    {
        var service = new StudentService();

        while (true)
        {
            Console.WriteLine("\n--- Student Management ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. View Student By ID");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());

                    service.AddStudent(new Student { Name = name, Email = email, Age = age });
                    Console.WriteLine("Student added successfully.");
                    break;

                case "2":
                    var students = service.GetAllStudent();
                    Console.WriteLine("All Students:");
                    foreach (var s in students)
                    {
                        Console.WriteLine($"{s.Id} : {s.Name}, {s.Email}, {s.Age}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    var student = service.GetStudentById(id);
                    if (student != null)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Email: {student.Email}, Age: {student.Age}");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter ID to Update: ");
                    int updateId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter New Name: ");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Enter New Email: ");
                    string newEmail = Console.ReadLine();
                    Console.WriteLine("Enter New Age: ");
                    int newAge = int.Parse(Console.ReadLine());

                    service.UpdateStudent(updateId, new Student { Name = newName, Email = newEmail, Age = newAge });
                    Console.WriteLine("Student updated successfully.");
                    break;

                case "5":
                    Console.WriteLine("Enter ID to Delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    service.DeleteStudent(deleteId);
                    Console.WriteLine("Student deleted successfully.");
                    break;

                case "6":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
