using DenemeProje.Models;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        {
            new Person()
            {
                FirstName = "Sina Emre";
            LastName = "BEKAR";
        },
         new Person()
         {
             FirstName = "Arda";
        LastName = "ŞİŞMAN";
    },
     new Person()
    {
        FirstName = "dOĞUKAN ";
        LastName = "YALÇIN";
    },
     new Person()
    {
        FirstName = "Ercan";
        LastName = "ÜNAL";
    },
    };
Console.WriteLine("Sınıf Listesi==========");
}

