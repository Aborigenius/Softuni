using BashSoft.DataStructure;
using System;
using System.IO;
namespace BashSoft
{
    class Launcher
    {
        static void Main(string[] args)
        {
            IOManager.TraverseDirectory(10);
            StudentsRepository.InitializeData();

            //StudentsRepository.InitializeData();
            StudentsRepository.GetStudentScoresFromCourse("Ivan", "Unity");
        }
    }
}
