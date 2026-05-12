namespace HashSetLib
{
    public class SPSStudent
    {
        public string Name;
        public int Year;
        public string Tutor;

        public SPSStudent(string name, int year, string tutor)
        {
            Name = name;
            Year = year;
            Tutor = tutor;
        }

        public override string ToString()
        {
            return $"{Name}-Year{Year}-{Tutor}";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Year.GetHashCode() ^ Tutor.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            SPSStudent Student2 = (SPSStudent)obj;
            if (Student2 == null) return false;
            return Name == Student2.Name && Year == Student2.Year && Tutor == Student2.Tutor;
        }
    }

    public class MyHashSet
    {
        private List<SPSStudent>[] Table;
        private int size;

        public MyHashSet(int tableSize)
        {
            size = tableSize;
            Table = new List<SPSStudent>[tableSize];

            for (int i = 0; i < tableSize; i++) Table[i] = new List<SPSStudent>();
        }

        public void Add(SPSStudent student)
        {
            // hashes in % order
            int i = Math.Abs(student.GetHashCode()) % size;
            Table[i].Add(student);
        }

        public bool IsPresent(SPSStudent student)
        {
            int i = Math.Abs(student.GetHashCode()) % size;
            return Table[i].Contains(student);
        }

        public void PrintTable()
        {
            Console.WriteLine("Hashes:");

            for (int i = 0; i < Table.Length; i++)
            {
                Console.Write($"[{i}] ");

                foreach (SPSStudent student in Table[i])
                {
                    Console.Write(student + " ");
                }

                Console.WriteLine();
            }
        }
    }
}