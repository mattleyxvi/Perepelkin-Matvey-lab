public class Teacher
{
    public string Name;
    public List<string> Subject;
    public List<string> Groups;
    public Teacher()
    {
        Console.WriteLine("введите имя");
        Name = Console.ReadLine();
        List<string> Lesns = new List<string>();
        while (true)
        {
            Console.WriteLine("Добавить предмет? да/нет");
            string a = Console.ReadLine();
            if (a == "да")
            {
                Console.WriteLine("введите предмет");
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
            Console.WriteLine("еще группу? у==да");
            string a = Console.ReadLine();
            if (a == "y")
            {
                Console.WriteLine("введите группу");
                groups.Add(Console.ReadLine());
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
        Console.WriteLine("имя группа ");

        List<string[]> Lesns = new List<string[]>();
        Name = Console.ReadLine();
        Group = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("Еще предмет добавить? да/нет");
            string a = Console.ReadLine();
            if (a == "да")
            {
                Console.WriteLine("предмет и оценка");
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
        Console.WriteLine("имя");
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
        Dictionary<string,string> tsk = new Dictionary<string,string>();
        while (true)
        {
            Console.WriteLine("Добавит приказ? да/нет");
            string a = Console.ReadLine();
            if (a == "да")
            {
                Console.WriteLine("введите приказ а затем для кого он");
                string q = Console.ReadLine();
                string qq = Console.ReadLine();
                tsk[q]=qq;
            }
            else
            {
                Task = tsk;
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
            Console.WriteLine("1-студент;2-препод;3-помошник;4-управляющий;5-закончить ввод");
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
        
        while (true)
        {
            Console.WriteLine("1-выдать долги для студента;2-выдать должников по предмету для препода;3-выдать автора приказа;4-выдать все приказы для одного человека");
            
            var w = Console.ReadLine();
            Console.Clear();
            if (w == "1")
            {
                Console.WriteLine("Введите имя студента");
                string stud = Console.ReadLine();
                foreach (Student nam in students)
                {
                    if (nam.Name == stud)
                    {
                        foreach (string[] i in nam.Subject)
                        {
                            if (i[1] == "2")
                            {
                                foreach (Teacher t in teachers)
                                {
                                    if ((t.Subject.Contains(i[0])) && (t.Groups.Contains(nam.Group)))
                                    {
                                        Console.Write(t.Name);
                                        Console.WriteLine(' ' + i[0]);
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
                Console.WriteLine("Введите предмет");
                var subj = Console.ReadLine();
                Console.WriteLine("Введите имя препода");
                var teach = Console.ReadLine();
                foreach (Teacher t in teachers)
                {
                    if (t.Name == teach)
                    {
                        foreach (Student st in students)
                        {
                            foreach (string[] sbj in st.Subject)
                            {
                                if ((sbj[1] == "2") && (sbj[0] == subj))
                                {
                                    Console.Write(st.Name);
                                    Console.WriteLine(" " + st.Group);
                                }
                            }
                        }
                    }
                }
            }
            else if (w == "3")
            {
                Console.WriteLine("Введите имя управленца");
                var task = Console.ReadLine();
                foreach (Head head in heads)
                {
                    if (head.Task.ContainsKey(task))
                    {
                        Console.WriteLine(head.Name);
                    }
                }
            }
            else if (w == "4")
            {
                Console.WriteLine("Введите имя");
                var head = Console.ReadLine();
                foreach (Head hed in heads)
                {
                    foreach(string ppl in hed.Task.Keys)
                        if (hed.Task[ppl] == head)
                    {
                            Console.WriteLine($"{ppl}");
                    }
                }
            }
            else if (w == "5")
                break;
            
        }
    }
}
