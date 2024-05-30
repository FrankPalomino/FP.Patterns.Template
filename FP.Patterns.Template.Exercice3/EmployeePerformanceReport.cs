namespace FP.Patterns.Template.Exercice3
{
    public class EmployeePerformanceReport : Report
    {
        protected override void AnalyzeData()
        {
            Console.WriteLine("Analyzing Employee Perdormance Data...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formating report for RRHH area");
            _report = "This is a Employee Performance report";
        }
    }
}
