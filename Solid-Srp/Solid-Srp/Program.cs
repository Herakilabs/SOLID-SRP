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

            Console.WriteLine(report.ToString());
            
            
            report.SaveToFile(@"Reports", "WorkReport.txt");

            Console.ReadKey();
        }
    }    
}
