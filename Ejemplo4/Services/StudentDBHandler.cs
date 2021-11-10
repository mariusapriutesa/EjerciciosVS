﻿using Ejemplo4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Services
{
    public class StudentDBHandler
    {
        public static ObservableCollection<StudentModel> studentList{ get; set; }

        public static ObservableCollection<StudentModel> GetStudents(){

            studentList = new ObservableCollection<StudentModel>();

            for (int i=0; i<20; i++) {
                StudentModel student = new StudentModel();
                student._id = i.ToString();
                student.Nombre = "Estudiante " + i.ToString();
                student.Curso = "Primero";
                student.Fecha = DateTime.Today;
                studentList.Add(student);
            }

            return studentList;

        }
        public static Boolean EditStudent(StudentModel student) {

            bool okEdit = false;
            foreach (StudentModel s in studentList)
            {
                if (s._id.Equals(student._id))
                    {
                    s.Nombre = student.Nombre;
                    s.Curso = student.Curso;
                    s.Fecha = student.Fecha;
                    okEdit = true;
                
                }



            }



            return okEdit;
        
        }

    }
}
