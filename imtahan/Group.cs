using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imtahan
{
    class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set;}
        public Group(string Name )

        {
            this.Name = Name;
            Students = new List<Student>();
        }
        public static void AddGroup()
        {
            Console.Write("Group Name: ");
            string groupName = Console.ReadLine();

            Group group = new Group(groupName);
            MyList.AllGroups.Add(group);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Group {groupName} daxil edildi\n");
        }
    }
}
