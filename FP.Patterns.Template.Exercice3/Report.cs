namespace FP.Patterns.Template.Exercice3
{
    public abstract class Report
    {
        protected string _report;

        public void GenerateReport()
        {
            CollectData();
            AnalyzeData();
            FormatReport();
            PrintReport();
        }

        protected void CollectData()
        {
            Console.WriteLine("Collecting Data from raw data");
        }
        protected abstract void AnalyzeData();
        protected abstract void FormatReport();
        protected void PrintReport()
        {
            Console.WriteLine(_report);
        }
    }
}
