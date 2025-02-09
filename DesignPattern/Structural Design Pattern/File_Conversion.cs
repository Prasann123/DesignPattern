namespace DesignPattern.Structural_Design_Pattern
{
    public class File_Conversion
    {
        public interface IFileConversion
        {
            void ConvertFile();

            void FormatFile();

        }

        public class PDFAdapter : IFileConversion
        {
            private PDFConversion pdfConversion;

            public PDFAdapter(PDFConversion pDFConversion)
            {
                this.pdfConversion = pDFConversion;

            }
            public void ConvertFile()
            {
                pdfConversion.ConvertFile();
            }

            public void FormatFile()
            {
                pdfConversion.FormatFile();
            }
        }

        public class PDFConversion
        {
            public void ConvertFile()
            {
                Console.WriteLine("Converting PDF file");

            }

            public void FormatFile()
            {
                Console.WriteLine("Formatting PDF file");

            }


        }

        public class WordConversion
        {
            public void ConvertFile()
            {
                Console.WriteLine("Converting Word file");

            }

            public void FormatFile()
            {
                Console.WriteLine("Formatting Word file");

            }
        }

        public class WordConversionAdapter : IFileConversion
        {
            private WordConversion wordConversion;


            public WordConversionAdapter(WordConversion wordConversion)
            {
                this.wordConversion = wordConversion;
            }
            public void ConvertFile()
            {
                wordConversion.ConvertFile();
            }

            public void FormatFile()
            {
                wordConversion.FormatFile();
            }

        }
    }
}
