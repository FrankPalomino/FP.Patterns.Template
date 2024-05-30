using FP.Patterns.Template.Exercice3;

EmployeePerformanceReport employeePerformanceReport = new EmployeePerformanceReport();
employeePerformanceReport.GenerateReport();

Console.WriteLine("----------------------------------------------------------");
InventoryReport inventoryReport = new InventoryReport();
inventoryReport.GenerateReport();

Console.WriteLine("----------------------------------------------------------");
SalesReport salesReport = new SalesReport();
salesReport.GenerateReport();