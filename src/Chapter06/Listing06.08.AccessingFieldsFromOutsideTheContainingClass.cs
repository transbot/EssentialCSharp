﻿// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618
// 不需要赋值
#pragma warning disable IDE0059

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_08;

using System;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 = new();
        Employee employee2;
        employee2 = new();

        employee1.FirstName = "Inigo";
        employee1.LastName = "Montoya";
        employee1.Salary = "太少了";
        IncreaseSalary(employee1);
        #region HIGHLIGHT
        Console.WriteLine(
            $"{ employee1.GetName() }: { employee1.Salary }");
        #endregion HIGHLIGHT
        // ...
    }
    #region EXCLUDE
    public static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "勉强过活";
    }
}

public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary = "不够";

    public string GetName()
    {
        return FirstName + " " + LastName;
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
