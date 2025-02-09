namespace DesignPattern.Behaviour_Design_Pattern.Template_Design_Pattern
{

    public abstract class Report_Generation
    {
        public void CreateReport()
        {
            DataFetch();
            FormatReport();
            SaveReport();
        }

        protected abstract void DataFetch();

        protected abstract void FormatReport();

        protected abstract void SaveReport();
    }

    public class ExcelReport : Report_Generation
    {

        protected override void DataFetch()
        {
            Console.WriteLine("Data Fetch from Excel");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Format Report in Excel");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("Save Report in Excel");
        }
    }

    public class PDFReport : Report_Generation
    {
        protected override void DataFetch()
        {
            Console.WriteLine("Data Fetch from PDF");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Format Report in PDF");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("Save Report in PDF");
        }

    }






}
