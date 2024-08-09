namespace DesignPatterns.Factory
{
    public class PdfDocument(string title) : Document(title, DocumentType.PDF)
    {
        public override string Print()
        {
            var pdfPrinted = base.Print();
            return pdfPrinted;
        }
    }
}
