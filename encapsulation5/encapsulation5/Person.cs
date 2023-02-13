using System;

namespace encapsulation5
{
    public class Person
    {
       

            private int age;
            private string firstname;
            private string lastname;
            private decimal salary;

           

            public string FirstName
            {
                get { return firstname;}
                set { firstname = value; }

            }

            public string LastName
            {
                get { return lastname; }
                set { lastname = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public decimal Salary
            {
                get { return salary; }
                set { salary = value; }
            }

           

            public Person(string firstname, string lastname, int age, decimal salary)
            {
                this.FirstName = firstname;
                this.LastName = lastname;
                this.Age = age;
                this.Salary = salary;
            }
            
           

            public void IncreaseSalary(decimal percentage)
            {
                if (this.Age > 30)
                {
                    this.Salary += this.Salary * percentage / 100;
                }
                else if(this.Age < 30)
                {
                    this.Salary += this.Salary * percentage / 200;
                }
            }
            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName} receives {String.Format("{0:0.00}", this.Salary)} leva.";
            }
    }

    }
