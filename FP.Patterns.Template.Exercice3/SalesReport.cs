namespace FP.Patterns.Template.Exercice3
{
    public class SalesReport : Report
    {
        protected override void AnalyzeData()
        {
            Console.WriteLine("Analyzing Sales Data...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formating report for Sales area");
            _report = "This is a Sales report";
        }
    }
}
