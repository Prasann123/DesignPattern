namespace DesignPattern.Structural_Design_Pattern
{
    public class FileConversion_Adaptern
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
            internal void ConvertFile()
            {
                Console.WriteLine("Converting PDF file");

            }

            internal void FormatFile()
            {
                Console.WriteLine("Formatting PDF file");

            }


        }

        public class WordConversion
        {
            internal void ConvertFile()
            {
                Console.WriteLine("Converting Word file");

            }

            internal void FormatFile()
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

