using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here



    public static IEnumerable<Emp> TaskGetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {

        Dictionary<Emp, int> employeesWithSubordinatesCount = new();
        foreach (Emp employee in emps)
        {
            int subordinatesCount = emps.Count(emp => emp.Mgr != null && emp.Mgr.Empno == employee.Empno);
            if (subordinatesCount > 0)
                employeesWithSubordinatesCount.Add(employee, subordinatesCount);
        }


        Dictionary<Emp, int>.KeyCollection filteredEmployees = employeesWithSubordinatesCount.Keys;


        IOrderedEnumerable<Emp> sortedEmployees = filteredEmployees.OrderBy(emp => emp.Ename)
            .ThenByDescending(emp => emp.Salary);

        return sortedEmployees;
    }

    public static IEnumerable<Emp> TaskGetEmpsWithDepartments(this IEnumerable<Emp> emps)
    {

        return emps.Where(x => x.Deptno != null);
    }
}