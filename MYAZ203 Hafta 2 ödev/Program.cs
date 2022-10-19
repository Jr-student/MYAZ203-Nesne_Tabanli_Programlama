using MYAZ203_Hafta_2_ödev;

EmpManager empManager = new EmpManager();
Employee employee = new Employee
{
    Id = 5,
    FirstName = "Mehmet Ali",
    LastName = "Şahin",
    Age = 67
};

empManager.ReadAll();
Console.WriteLine("-----------");
empManager.Add(employee);
empManager.ReadAll();
Console.WriteLine("-----------");
empManager.Delete(3);
empManager.ReadAll();
Console.WriteLine("-----------");
empManager.Delete(6);
empManager.ReadAll();
Console.WriteLine("-----------");