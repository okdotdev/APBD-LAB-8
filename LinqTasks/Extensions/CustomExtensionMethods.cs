using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here


    /// <summary>
    ///     Napisz własną metodę rozszerzeń, która pozwoli skompilować się poniższemu fragmentowi kodu.
    ///     Metodę dodaj do klasy CustomExtensionMethods, która zdefiniowana jest poniżej.
    ///     Metoda powinna zwrócić tylko tych pracowników, którzy mają min. 1 bezpośredniego podwładnego.
    ///     Pracownicy powinny w ramach kolekcji być posortowani po nazwisku (rosnąco) i pensji (malejąco).
    /// </summary>
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        IEnumerable<Emp> empsWithManagers = emps.Where(x => x.Mgr != null);

        //map of managers and their subordinates

        Dictionary<Emp,int> managersWithSubordinates = new();


        foreach (Emp empWithManager in empsWithManagers)
        {
            if(empWithManager.Mgr != null)
            {
                if(managersWithSubordinates.ContainsKey(empWithManager.Mgr))
                {
                    managersWithSubordinates[empWithManager.Mgr]++;
                }
                else
                {
                    managersWithSubordinates.Add(empWithManager.Mgr,1);
                }
            }
        }

        //return colletion of strings



        return empsWithManagers.Where(x => managersWithSubordinates.ContainsKey(x.Mgr))
            .OrderBy(x => x.Ename)
            .ThenByDescending(x => x.Salary);


    }

    public static IEnumerable<Emp> GetEmpsWithDepartments(this IEnumerable<Emp> emps)
    {

        return emps.Where(x => x.Deptno != null);
    }
}