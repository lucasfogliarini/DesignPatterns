namespace DesignPatterns.Creational.Factory
{
    public class WordDocument(string title) : Document(title, DocumentType.Word)
    {
        public override string Print()
        {
            var wordPrinted = base.Print();
            return wordPrinted;
        }
    }
}
