using System;
using static System.Console;

namespace EmployeeApp;

class Employee
{
    //Field data
    private string? _empName; //private field
    private int _empID; 
    public float _currPay;//public field
    private int _empAge;

    private string? _empSSN;

    //Properties!

    public string? SocialSecurityNumber
    {
        get => _empSSN;
        set => _empSSN = value;

    }
    public string? Name
    {
        get{ return _empName; }
        set{
            if(value.Length > 15){
                WriteLine("Error! Name length exceeds 15 characters!");
            }else{
                _empName = value;
            }
        }
    }

    //the 'int' type is a value type, so it's passed by value
    //the 'int' represents the type of data this property encapsulates
    public int ID{
        get{return _empID;}
        set{_empID = value;}
    }

    public float Pay{
        get{return _currPay;}
        set{_currPay = value;}
    }

    public int Age{
        get{return _empAge;}
        set{_empAge = value;}
    }

    //Constructors

    //Default constructor   
    public Employee(){

    }

    //Custom constructor
    public Employee(string? name, int id, float pay):this(name, 0, id, pay, " "){}
    public Employee(string? name, int age, int id, float pay, string? ssn){
        Name = name;
        Age = age;
        ID = id;
        Pay = pay;
        SocialSecurityNumber = ssn; //assign the value of the ssn parameter to the field
    }

    //Methods
    public void GiveBonus(float ammount){
            Pay += ammount; //
    }

    public void DisplayStats(){
        WriteLine($"Name: {Name}");
        WriteLine($"ID: {ID}");
        WriteLine($"Age: {Age}");
        WriteLine($"Pay: {Pay}");
        WriteLine($"SSN: {SocialSecurityNumber}");
    }

    //Accessors (getters)
    public string? GetName(){
        return _empName;
    }

    //Mutators (setters)
    public void SetName(string name){
        //Do check on incomming value before making assignment

        if(name.Length > 15){
            WriteLine("Error! Name length exceeds 15 characters!");
        } else{
            _empName = name;
        }
    }

    public int GetID(){
        return _empID;
    }


}