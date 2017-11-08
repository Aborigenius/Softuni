using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;
            var middle = 2 * n - 1; ;
            #region Top
            for (int row = 0; row < n; row++)
            {

                for (int i = 0; i <= row; i++)
                {
                    Console.Write('*');
                }
                Console.Write('\\');
                Console.Write(new string('-', middle));
                Console.Write('/');
                Console.Write(new string('*', row + 1));
                Console.WriteLine();
                middle -= 2;
                #endregion

            }
            #region MiddleLines
            middle = n;
            var left = n / 2;
            for (int row = 1; row <= n / 3; row++)
            {
                
                Console.Write('|');
                Console.Write("{0}\\", new string('*', left));
                Console.Write("{0}/", new string('*', middle));
                Console.Write("{0}", new string('*', left));
                 
                Console.Write('|');
                Console.WriteLine();
                middle -= 2;
                left++;

                // Console.Write("|{0}\\{1}/{0}|", new string('*', n / 2), new string('*', n));

            }
           

            #endregion
            #region Bottom
            middle = 2 * n - 1;
            for (int row = 0; row < n; row++)
            {
                
                for (int i = 0; i <= row; i++)
                {
                    Console.Write('-');
                }
                Console.Write('\\');
                Console.Write(new string('*', middle));
                Console.Write('/');
                Console.Write(new string('-', row + 1));
                Console.WriteLine();
                middle -= 2;
                #endregion

            }
        }
    }
}
// 7
//  *\-------------/*
//  **\-----------/**
//  ***\---------/***
//  ****\-------/****
//  *****\-----/*****
//  ******\---/******
//  *******\-/*******
//  |***\*******/***| n/2 n n/2
//  |****\*****/****|n/2+1 n-2 n/2+1
//  -\*************/-
//  --\***********/--
//  ---\*********/---
//  ----\*******/----
//  -----\*****/-----
//  ------\***/------
//  -------\*/-------

