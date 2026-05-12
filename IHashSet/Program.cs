using HashSetLib;

class Program
{
    static void Main()
    {
        MyHashSet Group = new MyHashSet(5);

        SPSStudent s1 = new SPSStudent("Adam", 10, "AB");
        SPSStudent s2 = new SPSStudent("Bob", 11, "CD");
        SPSStudent s3 = new SPSStudent("Charlie", 10, "EF");
        SPSStudent s4 = new SPSStudent("Dylin", 12, "GH");
        SPSStudent s5 = new SPSStudent("Ethan", 13, "IJ");

        Group.Add(s1);
        Group.Add(s2);
        Group.Add(s3);
        Group.Add(s4);
        Group.Add(s5);

        Group.PrintTable();

        Console.WriteLine();

        Console.WriteLine("Testing search:");
        Console.WriteLine("Alice found: " + Group.IsPresent(s1));
        Console.WriteLine("Fred found: " + Group.IsPresent(new SPSStudent("Fred", 10, "KL")));
    }
}