namespace DesignPatterns.Factory
{
    public abstract class Document(string title, DocumentType type)
    {
        public string Title { get; set; } = title;
        public DocumentType Type { get; set; } = type;

        public virtual string Print()
        {
            var documentPrinted = $"Imprimindo um documento {Type} com o título: {Title}";
            return documentPrinted;
        }

        public static Document Create(DocumentType type, string title)
        {
            return type switch
            {
                DocumentType.PDF => new PdfDocument(title),
                DocumentType.Word => new WordDocument(title),
                _ => throw new ArgumentException("Invalid document type."),
            };
        }
    }
}
