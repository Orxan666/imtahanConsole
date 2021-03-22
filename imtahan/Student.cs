using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imtahan
{
    class Student
    {
        public int studentId { get; }

        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        private static int StuId = 0;
        public Group Group;
        public List<Exam> Exams { get; set; }

        public Student(string FullName, string PhoneNumber)
        {

            this.FullName = FullName;
            this.PhoneNumber = PhoneNumber;
            StuId++;
            studentId = StuId;
        }
        public static void AddStudent()
        {
            Console.Write("Fullname: ");
            string frName = Console.ReadLine();
            Console.Write("Phone number: ");
            string phone = Console.ReadLine();
            
            Student student = new Student(frName, phone);
            
            MyList.AllStudents.Add(student);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Yeni telebe {frName} daxil edildi\n");
        }

        public static Student SelectedStudent()
        {
            foreach (var student in MyList.AllStudents)
            {
                Console.WriteLine($"id:{student.studentId} - Student Name:{student.FullName}");
            }
            SelectedID:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nTələbə ids'ni seçin:");
            int stuId = Convert.ToInt32(Console.ReadLine());
            bool isCorrect = false;
            Student selectedStudent = null;
            foreach (var student in MyList.AllStudents)
            {
                if (student.studentId== stuId)
                {
                    isCorrect = true;
                    selectedStudent = student;
                }
            }
            if (isCorrect)
            {
                return selectedStudent;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Group adı mövcud deyil./n");
                goto SelectedID;
            }
        }

        public static void SelectGroupAddStudent()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var group in MyList.AllGroups)
            {
                Console.WriteLine($"Group Name:{group.Name}");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nGroup Adını seçin:");
            string groupName = Console.ReadLine();
            bool isCorrect=false;
            Group selectedGroup = null;
            foreach (var group in MyList.AllGroups)
            {
              if(group.Name== groupName)
                {
                    isCorrect = true;
                    selectedGroup = group;
                }
            }
            if (isCorrect)
            {
                Student selectedStudent = SelectedStudent();
                selectedStudent.Group = selectedGroup;
                selectedGroup.Students.Add(selectedStudent);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"\n{selectedStudent.FullName} {selectedGroup.Name}-na daxil edildi");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Group adı mövcud deyil./n");
            }

        }
    }
}
