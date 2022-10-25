// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ListTest22;


List<int> myFirstList = new List<int> ();
myFirstList.Add (34);
myFirstList.Add(-233);//tilføjer bagerst
myFirstList.Add(9801);
myFirstList.Add(67);
myFirstList.Add(2);
myFirstList.Add(-9582);
myFirstList.Add(770);
myFirstList.Insert(3, 1300);//indsætter på position og rykker de andre
myFirstList[4] = 85;

myFirstList.Remove(9801);

//foreach (int item in myFirstList)
//{
//    Console.WriteLine(item);
//}

List<Book> books = new List<Book>();




Book b1 = new Book("C# bogen", "John Sharp", "124124124");
Book b2 = new Book("PHP bogen", "John Jensen", "sdfsf");
Book b3 = new Book("Pascal bogen", "John Pascal", "76767");

books.Add(b1);
books.Add(b2);
books.Add(b3);





foreach(Book b in books)
{
    Console.WriteLine(b);
}

//books.Remove(b2);



foreach (Book b in books)
{
    Console.WriteLine(b);
}

Console.WriteLine("Fremmødte");

Student s1;
s1 = new Student("Poul", true);
Student s2 = new Student("Carina", true);
Student s3 = new Student("Anders", false);

List<Student> fremMødte = new List<Student>();
fremMødte.Add(s1);
fremMødte.Add(s2);
fremMødte.Add(s3);
//fremMødte[0] = s3;
fremMødte.Remove(s2);
fremMødte[0].Attendance = true;
Console.WriteLine("Foreach");
//foreach
foreach(Student s in fremMødte)
{
    Console.WriteLine(s);
}

Console.WriteLine("For-loop");
//for-loop
for (int i = 0; i < fremMødte.Count; i++)
{
    Console.WriteLine(fremMødte[i].ToString());

}


//while
Console.WriteLine("While-loop");
int j=0;
while(j<fremMødte.Count)
{
    Console.WriteLine(fremMødte[j].ToString());
    j++;
}





