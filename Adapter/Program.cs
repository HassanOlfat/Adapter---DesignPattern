using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person() {NationalCode = 10, FristName = "Ali", LastName = "Rezaii"};
            var e= new  EmployeeDAO();
          var id=  e.Save(new PersonAdatpter(p));
            Console.WriteLine(id);
            Console.ReadKey();
        }
    }
}
