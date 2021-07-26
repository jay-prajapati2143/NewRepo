using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class Person
    {
        //public static Person[] people = new Person[]
        //    {
        //        new Person("Weston",33),
        //        new Person("johnnathon", 41),
        //        new Person("John",35),
        //        new Person("Adam",30)
        //    };
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }
        string Name { get; set; }
        int Age { get; set; }
    }
}