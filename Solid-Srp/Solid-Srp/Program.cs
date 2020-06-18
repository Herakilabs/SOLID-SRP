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

            var saver = new FileSaver();

            saver.SaveToFile(@"C:\Temp", "WorkReport.txt", report);

            Console.WriteLine(report);

            Console.ReadKey();
        }
    }

    
}
