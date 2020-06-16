using System;

namespace Solid_Srp
{

    class Program
    {
        static void Main(string[] args)
        {
            var wr = new WorkReport();

            wr.AddEntry(new WorkReportEntry
            {
                ProjectCode = "IOT",
                ProjectName = "Internet Of Things",
                SpentHours = 3
            });
            wr.AddEntry(new WorkReportEntry
            {
                ProjectCode = "AI",
                ProjectName = "Artificial Intelligence",
                SpentHours = 5
            });

            var saver = new FileSaver();

            saver.SaveToFile(@"C:\Temp", "WorkReport.txt", wr);

            Console.WriteLine(wr);

            Console.ReadKey();
        }
    }

    
}
