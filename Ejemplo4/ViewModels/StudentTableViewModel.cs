﻿using Ejemplo4.Commands;
using Ejemplo4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejemplo4.ViewModels
{
    public class StudentTableViewModel : ViewModelBase
    {

        private StudentModel currentStudent;
        public StudentModel CurrentStudent
        {
            get { return currentStudent; }
            set
            {
                currentStudent = value;
                OnPropertyChanged(nameof(CurrentStudent));
            }
     
        }

        private StudentModel selectedStudent { set; get; }
        public StudentModel SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }

        }


        private bool editarActivado { set; get; }
        public bool EditarActivado
        {
            get { return editarActivado; }
            set
            {
                editarActivado = value;
                OnPropertyChanged(nameof(EditarActivado));
            }

        }
        private bool cambiarEstudiante { set; get; }
        public bool CambiarEstudiante
        {
            get { return cambiarEstudiante; }
            set
            {
                cambiarEstudiante = value;
                OnPropertyChanged(nameof(CambiarEstudiante));
            }

        }


        public ObservableCollection<string> listaNumeros { set; get; }

        private ObservableCollection<StudentModel> listaEstudiantes;

        public ICommand StudentCommand { set; get; }

        public ObservableCollection<StudentModel> ListaEstudiantes
        {
            get { return listaEstudiantes; }
            set
            {
                listaEstudiantes = value;
                OnPropertyChanged(nameof(ListaEstudiantes));
            }
        }

        public StudentTableViewModel()
        {
            listaNumeros = new ObservableCollection<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            currentStudent = new StudentModel();
            StudentCommand = new StudentCommand(this);
            listaEstudiantes = new ObservableCollection<StudentModel>();
            editarActivado = false;
            cambiarEstudiante = true;
        }

    }

}
