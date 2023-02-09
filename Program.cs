
    public class Student
    {
        public string Name, Group;
        public string Age1, Age2, Age3;
        public List<string[]> Subject;
        public Student()
        {
            Console.WriteLine("имя группа даты");
            string[] input = Console.ReadLine().Split(" ");
            List<string[]> Lesns = new List<string[]>();
            Name = input[0];
            Group = input[1];
            Age1 = input[2];
            Age2 = input[3];
            Age3 = input[4];
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

    class HelloWorld
    {
        static void Main()
        {
            bool add = true;
            List<string> chosen = new List<string>();
        Console.WriteLine("1 отличники, 2 20лет, 3 долги");
            var w = Console.ReadLine();
            if (w == "1")
            {
                while (true)
                {
                    Console.WriteLine("new stud?");
                    var q = Console.ReadLine();
                    if (q == "n")
                    {
                        break;
                    }
                    else
                    {
                        Student boba = new Student();
                        foreach (string[] i in boba.Subject)
                        {
                            if (i[1] != "5")
                            {
                                add = false;
                                break;
                            }
                        }
                        if (add = true)
                            chosen.Add(boba.Name);
                    }
                }
            }
            else if (w == "2")
            {
                while (true)
                {
                    Console.WriteLine("new stud?");
                    var q = Console.ReadLine();
                    if (q == "n")
                    {
                        break;
                    }
                    else
                    {
                        Student boba = new Student();
                        if (Convert.ToInt32(boba.Age3+boba.Age2+boba.Age1)/20230208 >= 20)
                            chosen.Add(boba.Name);
                    }
                }
            }
            else if (w == "3")
            {
                while (true)
                {
                    Console.WriteLine("new stud?");
                    var q = Console.ReadLine();
                    if (q == "n")
                    {
                        break;
                    }
                    else
                    {
                        Student boba = new Student();
                        foreach (string[] i in boba.Subject)
                        {
                            if (i[1] == "-1")
                            {
                                chosen.Add(boba.Name);
                                break;
                            }
                        }
                    }
                }
            }
            foreach (string a in chosen)
                Console.WriteLine(a);
        }
    }
