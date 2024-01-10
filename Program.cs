// See https://aka.ms/new-console-template for more information
using ConsoleApp1;



List<Employee> employees = new List<Employee>()
{
    new Employee() {Id=1,Name="Sam",Designation="Manager",Doj=new DateTime(day:12,month:09,year:2022)},
    new Employee() {Id=2,Name="Ananth",Designation="Developer",Doj=new DateTime(day:10,month:06,year:2022)},
    new Employee() {Id=3,Name="Prakash",Designation="HR",Doj=new DateTime(day:11,month:05,year:2022)},
    new Employee() {Id=4,Name="Kanishk",Designation="Manager",Doj=new DateTime(day:17,month:11,year:2022)},
};
Console.WriteLine("ID\t Name \t Designation \t Date of Joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id +"\t \t");
    Console.Write(emp.Name +"\t \t");
    Console.Write(emp.Designation +"\t \t");
    Console.Write(emp.Doj.ToLongDateString());
    Console.WriteLine("\n");
}
Console.ReadKey();