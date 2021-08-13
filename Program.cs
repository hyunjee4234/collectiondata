using System;
using System.Collections;

class ArrayListProgram
{
    static void Main(string[] args)
    {
        ArrayList al = new ArrayList(100);
        al.Add("S1");
        al.Add("S2");
        Console.WriteLine(al.Add("S3"));
        al.Add("S4");
        al.Add("S5");
        al.AddRange(new string[] { "A1", "A2", "A3" });
        al.Insert(2, "I1");
        al.Remove("S4");
        al.RemoveAt(4);
        al.Sort();
        al.Reverse();
        al.TrimToSize();
        foreach (string s in al)
            Console.WriteLine(s);
        Console.WriteLine(al.Capacity + " " + al.Count);
        string[] ar = (string[])al.ToArray(typeof(string));
    }
}

class HashtableProgram
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add(101, "S1");
        ht.Add(102, "S2");
        ht.Add(103, "S3");
        ht.Add(104, "S4");
        ht.Add(105, "S5");
        ht.Remove(103);
        string value1 = ht[102].ToString();
        Console.WriteLine(value1);
        foreach (DictionaryEntry de in ht)
        {
            int key = (int)de.Key;
            string value = (string)de.Value;
            Console.WriteLine(key + " " + value);
        }
    }
}


class SortedListProgram
{
    static void Main(string[] args)
    {
        SortedList sl = new SortedList();
        sl.Add(101, "S1");
        sl.Add(102, "S2");
        sl.Add(103, "S3");
        sl.Add(104, "S4");
        sl.Add(105, "S5");
        sl.Remove(103);
        string value1 = sl[102].ToString();
        Console.WriteLine(value1);
        foreach (DictionaryEntry de in sl)
        {
            int key = (int)de.Key;
            string value = (string)de.Value;
            Console.WriteLine(key + " " + value);
        }
        string v = (string)sl.GetByIndex(2);
    }
}

class Employee //: IComparable
{
    public int Id;
    public string Name;
    public override string ToString()
    {
        return Id + " "+ Name;
    }
    //public int CompareTo(object obj)
    //{
    //    Employee other = (Employee)obj;
    //    if (this.Id < other.Id)
    //        return -1;
    //    else if (this.Id > other.Id)
    //        return 1;
    //    else
    //        return 0;
    //}
}

class EmployeeComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Employee first = (Employee)x;
        Employee second = (Employee)y;
        return first.Id - second.Id;
    }
}

class EmployeeCollectionProgram
{
    static void Main(string[] args)
    {
        ArrayList alEmp = new ArrayList();
        alEmp.Add(new Employee() { Id = 1, Name = "E1" });
        alEmp.Add(new Employee() { Id = 2, Name = "E2" });
        alEmp.Add(new Employee() { Id = 3, Name = "E2" });
        alEmp.Add(new Employee() { Id = 4, Name = "E3" });
        alEmp.Add(new Employee() { Id = 5, Name = "E4" });

        EmployeeComparer ec = new EmployeeComparer();
        alEmp.Sort(ec);
        alEmp.Reverse();

        foreach (Employee emp in alEmp)
        {
            Console.WriteLine(emp.ToString());
        }

        IEnumerator en = alEmp.GetEnumerator();
        while (en.MoveNext())
        {
            Employee e = (Employee)en.Current;
            Console.WriteLine(e);
        }
    }
}
