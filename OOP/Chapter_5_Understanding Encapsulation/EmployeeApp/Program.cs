using System;
using static System.Console;
using EmployeeApp;

/*
Employee emp = new Employee("Shamil", 001, 100_000);
emp.GiveBonus(546258);
emp.DisplayStats();

//Use the get / set methods to interact with the object's name
emp.Name = "Shamil K";
WriteLine($"\nEmployee name: {emp.Name}");

//Use the get / set methods to interact with the object's ID
emp.ID = 002;
WriteLine($"Employee ID: {emp.ID}");

//Use the get / set methods to interact with the object's pay
emp.Pay = 2_000_000;
WriteLine($"Employee pay: {emp.Pay}");

//Use the get / set methods to interact with the object's age
emp.Age = 21;
WriteLine($"Employee age: {emp.Age}");
emp.Age++;
WriteLine($"Employee new age: {emp.Age}");

*/

//Neu emploee, using the custom constructor with SSN
Employee emp2 = new Employee("Shamil",28, 001, 100_000, "123-45-6789", EmployeePayTypeEnum.Salaried);
emp2.DisplayStats();
WriteLine(emp2.Pay + " - before bonus");
emp2.GiveBonus(100);
WriteLine($"{emp2.Pay} - after bonus");
