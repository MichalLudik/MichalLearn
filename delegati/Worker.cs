using System;

namespace delegati
{
    //public delegate void WorkPerformedHandler(object sender,WorkPerformedEventArgs eventArgs);
    public class Worker
    {
        
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType wType)
        {
            for (int i = 0; i < hours; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnWorkPerformed(i+1,wType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType wType)
        {
            var del = WorkPerformed;
            if (del != null)
            {
                del(this, new WorkPerformedEventArgs(hours,wType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }

        public void worker_Workperformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Hours: {e.Hours}, WorkType: {e.WorkType}");
        }

        public void worker_Workcompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed.");
        }
    }
}