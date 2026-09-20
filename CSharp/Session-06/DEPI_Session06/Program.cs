namespace DEPI_Session06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee
                (
                1,
                "Mohamed",
                60_000,
                Gender.M,
                new HiringDate(10, 10, 2010),
                SecurityLevel.DBA
                );

            EmpArr[1] = new Employee
                (
                2,
                "Ahmed",
                20_000,
                Gender.M,
                new HiringDate(11, 11, 2011),
                SecurityLevel.Guest
                );

            EmpArr[2] = new Employee
                (
                3,
                "Hana",
                20_000,
                Gender.F,
                new HiringDate(12, 12, 2012),
                SecurityLevel.SecurityOfficer
                );

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
                Console.WriteLine();
            }
        }
    }
}
