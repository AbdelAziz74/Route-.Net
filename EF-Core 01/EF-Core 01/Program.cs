
using System;
using System.ComponentModel.DataAnnotations;
using EF_Core_01.Data;
using EF_Core_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_01
{
     class Program
    {
        static void Main()
        {
            using var context = new ITIDbContext();


            var student = new Student
            {
                FName = "Ahmed",
                LName = "Ali",
                Address = "Cairo",
                Age = 25,
                Dep_Id = 1
            };

            context.Students.Add(student);
            context.SaveChanges();

        }
    }











}
