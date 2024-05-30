namespace FP.Patterns.Template.Exercice3
{
    public class InventoryReport : Report
    {
        protected override void AnalyzeData()
        {
            Console.WriteLine("Analyzing Inventory Data...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formating report for warehouse area");
            _report = "This is a Inventory report";
        }
    }
}
