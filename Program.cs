﻿using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2

{
    public class Program
    {
        public static void Main(string[] args)
        {
            lab_work_2.Class1 obj1 = new lab_work_2.Class1();
            lab_work_2.Class2 obj2 = new lab_work_2.Class2();
            lab_work_2.Class3 obj3 = new lab_work_2.Class3();
            lab_work_2.Class4 obj4 = new lab_work_2.Class4();
            lab_work_2.Class5 obj5 = new lab_work_2.Class5();
            lab_work_2.Class6 obj6 = new lab_work_2.Class6();
            lab_work_2.Class7 obj71 = new lab_work_2.Class7();
            lab_work_2.Class7 obj72 = new lab_work_2.Class7();
            lab_work_2.Class7 obj73 = new lab_work_2.Class7();

            // obj1.somestrangenumber = Convert.ToInt32(Console.ReadLine());
            // obj1.anothernumber = Convert.ToInt32(Console.ReadLine());
            // obj1.swap(ref obj1.numberone, ref obj1.numbertwo);
            // //End of lab-1
            // Console.WriteLine($"Sum of numbers: {obj2.sum(ref obj2.firstnum, ref obj2.secondnum)}");
            // //End of lab-2
            // obj3.maxmin();
            // //End of lab-3
            // obj4.sumaver();
            //End of lab-4
            obj5.sort1();
            //End of lab-5
            obj6.sort2();
            //End of lab-6
            obj71.fill();
            obj72.fill();
            Console.WriteLine("Here`s your new array: ");
            for(int i = 0; i<5; i++){
                obj73.array[i] = obj71.array[i] + obj72.array[i];
                Console.Write($"{obj73.array[i]}, ");
            }
        }
    }
}