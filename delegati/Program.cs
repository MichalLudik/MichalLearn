using System;

namespace delegati
{
    //public delegate int WorkPerformedHandler(int hours, WorkType worktype);
    class Program
    {
        static void Main()
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;
            
            //int finalHours= del1(5,WorkType.GoToMeetings); //posledny delegat vrati hodnotu

            //Console.WriteLine(finalHours);
            //del2(10,WorkType.Golf);


            var worker = new Worker();
            worker.WorkPerformed += worker.worker_Workperformed;
            worker.WorkCompleted += worker.worker_Workcompleted;
            worker.DoWork(10,WorkType.Golf);

            Console.ReadLine();
        }
        

        static int WorkPerformed1(int hours, WorkType wType)
        {
            Console.WriteLine($"WorkPerformed1 {hours} worktype {wType}.");
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType wType)
        {
            Console.WriteLine($"WorkPerformed2 {hours} worktype {wType}.");
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType wType)
        {
            Console.WriteLine($"WorkPerformed3 {hours} worktype {wType}.");
            return hours + 3;
        }

        
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        Hospoda
    }
}