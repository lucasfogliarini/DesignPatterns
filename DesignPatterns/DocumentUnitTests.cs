using DesignPatterns.Factory;

namespace DesignPatterns
{
    public class DocumentUnitTests
    {
        [Fact]
        public void Print_ShouldPrintPdf_WhenPdfDocument()
        {
            var documentTitle = "PDF Title";
            var pdfDocument = Document.Create(DocumentType.PDF, documentTitle);

            var pdfPrinted = pdfDocument.Print();

            Assert.Equal($"Imprimindo um documento {DocumentType.PDF} com o título: {documentTitle}", pdfPrinted);
            Assert.Equal(DocumentType.PDF, pdfDocument.Type);
            Assert.Equal(documentTitle, pdfDocument.Title);
        }
    }
}