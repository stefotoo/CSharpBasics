using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Petrov";
        byte age = 44;
        bool isFemale = false;
        string gender;
        ulong personalId = 7004051415;
        ulong employeeId = 112301122345;
        if (!isFemale)
        {
            gender = "Male";
        }
        else
        {
            gender = "Female";
        }
        Console.WriteLine("First name: {0} \nLast name = {1} \nAge = {2} \nGender = {3} \nPersonal ID = {4} \nEmployee ID = {5}", firstName, lastName, age, gender, personalId, employeeId);
    }
}

