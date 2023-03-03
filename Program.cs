public class Teacher
{
    public string Name;
    public List<string> Subject;
    public List<string> Groups;
    public Teacher()
    {
        Console.WriteLine("имя");
        Name = Console.ReadLine();
        List<string> Lesns = new List<string>();
        while (true)
        {
            Console.WriteLine("Add more subj?");
            string a = Console.ReadLine();
            if (a == "y")
            {
                Console.WriteLine("subj");
                Lesns.Add(Console.ReadLine());
            }
            else
            {
                Subject = Lesns;
                break;
            }

        }
        List<string> groups = new List<string>();
        while (true)
        {
            Console.WriteLine("Add more group?");
            string a = Console.ReadLine();
            if (a == "y")
            {
                Console.WriteLine("group");
                Lesns.Add(Console.ReadLine());
            }
            else
            {
                Groups = groups;
                break;
            }

        }
    }
}
    public class Student
    {
        public string Name, Group;
        public List<string[]> Subject;
        public Student()
        {
            Console.WriteLine("имя группа даты");
            string[] input = Console.ReadLine().Split(" ");
            List<string[]> Lesns = new List<string[]>();
            Name = input[0];
            Group = input[1];
            while (true)
            {
                Console.WriteLine("Add more subj?");
                string a = Console.ReadLine();
                if (a == "y")
                {
                    Console.WriteLine("subj mark");
                    Lesns.Add(Console.ReadLine().Split(" "));
                }
                else
                {
                    Subject = Lesns;
                    break;
                }

            }
        }
    }
public class Helper
{
    public string Name;
    public Helper()
    {
        Console.WriteLine("name");
        Name = Console.ReadLine();
    }
}
public class Head
{
    public string Name;
    public Dictionary<string, string> Task;
    public Head()
    {
        Console.WriteLine("имя");
        Name = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("Add more task?");
            string a = Console.ReadLine();
            if (a == "y")
            {
                Console.WriteLine("input task and ppl");
                string[] tsk = { Console.ReadLine(),Console.ReadLine() };
                Task.Add(tsk[0], tsk[1]);
            }
            else
            {
                break;
            }

        }
    }

}
    class Program
    {
        static void Main()
        {

            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Helper> helpers = new List<Helper>();
            List<Head> heads = new List<Head>();
            while (true)
            {
                Console.WriteLine("who");
                string a = Console.ReadLine();
            if (a == "1")
                students.Add(new Student());
            else if (a == "2")
                teachers.Add(new Teacher());
            else if (a == "3")
                helpers.Add(new Helper());
            else if (a == "4")
                heads.Add(new Head());
            else if (a == "5")
                break;
            Console.Clear();
            }
            
            var w = Console.ReadLine();
            if (w == "1")
            {
            var subj = Console.ReadLine();
            var grup = Console.ReadLine();
            var stud  = Console.ReadLine();
            foreach (Student nam in students)
            {
                if (nam.Name == stud)
                {
                    for (int i = 0; i < nam.Subject.Count(); i++)
                    {
                        if (nam.Subject[i][1] == "2")
                        {
                            foreach (Teacher t in teachers)
                            {
                                if ((t.Subject.Contains(nam.Subject[i][0]))&&(t.Groups.Contains(nam.Group)))
                                {
                                    Console.Write(t.Name);
                                    Console.Write(' ' + nam.Subject[i][0]);
                                }
                            }
                        }
                    }
                    break;
                }
            }
            }
            else if (w == "2")
        {
            var subj = Console.ReadLine();
            var teach = Console.ReadLine();
            foreach (Teacher t in teachers)
            {
                if (t.Name == teach)
                {
                    foreach (Student st in students)
                    {
                        foreach (string[] sbj in st.Subject)
                        {
                            if ((sbj[1] == "2") && (sbj[0]==subj))
                            {
                                Console.Write(st.Name);
                                Console.Write(" " + st.Group);  
                            }
                        }
                    }
                }
            }
        }
            else if (w == "3")
        {
            var task = Console.ReadLine();
            foreach (Head head in heads)
            {
                if (head.Task.ContainsKey(task))
                {
                    Console.WriteLine(head.Name);
                }
            }
        }
            else if (w=="4")
        {
            var head = Console.ReadLine();
            foreach (Head hed in heads)
            {
                if (hed.Name == head)
                {
                    foreach(string task in hed.Task.Keys)
                        Console.WriteLine($"{task}");
                }
            }
        }
        }
    }
