using System;

namespace Solid_Srp
{

    class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkReport();

            report.AddEntry(new WorkReportEntry
            {
                ProjectCode = "IOT",
                ProjectName = "Internet Of Things",
                SpentHours = 3
            });
            report.AddEntry(new WorkReportEntry
            {
                ProjectCode = "AI",
                ProjectName = "Artificial Intelligence",
                SpentHours = 5
            });

            var scheduler = new Scheduler();
            scheduler.AddEntry(new ScheduleTask 
            { 
                TaskId = 1,
                Content = "Do something now.",
                ExecuteOn = DateTime.Now.AddDays(5)
            });

            scheduler.AddEntry(new ScheduleTask 
            { 
                TaskId = 2,
                Content = "Don't forget to...",
                ExecuteOn = DateTime.Now.AddDays(2)
            });

            Console.WriteLine(report.ToString());
            Console.WriteLine(scheduler.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);

            Console.ReadKey();
        }
    }    
}
