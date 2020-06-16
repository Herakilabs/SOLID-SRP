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
                ProjectName = "Artificial Intelegence",
                SpentHours = 5
            });

            wr.SaveToFile(@"C:\Temp\", "WorkHours.txt");

            Console.WriteLine(wr);

            Console.ReadKey();
        }
    }

    
}
