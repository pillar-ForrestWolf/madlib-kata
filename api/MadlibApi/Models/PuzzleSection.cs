namespace MadlibApi.Models
{
    public class PuzzleSection
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public PuzzleSectionType SectionType;
    }
    
    public enum PuzzleSectionType
    {
        PlainText, Input
    }
    
}