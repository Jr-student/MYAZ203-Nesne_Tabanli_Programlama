namespace MYAZ203_Hafta_2_ödev
{
    public class EmpManager
    {
        public List<Employee> employees = new List<Employee>
        {
            new Employee{Id = 1, FirstName = "Ali", LastName = "Şahin", Age = 19},
            new Employee{Id = 2, FirstName = "Mehmet", LastName = "Altındaş", Age = 20},
            new Employee{Id = 3, FirstName = "Halil", LastName = "Yöksıl", Age = 22},
            new Employee{Id = 4, FirstName = "Seralp", LastName = "Özkan", Age = 19}
        };

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employeeId = employees.FirstOrDefault(e=> e.Id == id);
            if(employeeId != null)
                employees.RemoveAt(id - 1);
            else
                Console.WriteLine("Invalid Id\n");
        }

        public void ReadAll()
        {
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName + " " + employee.Age);
            }
        }
    }
}
