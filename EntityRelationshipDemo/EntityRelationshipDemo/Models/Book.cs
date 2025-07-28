namespace EntityRelationshipDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public Author AuthorNavigation { get; set; }
        public Publisher PublisherNavigation { get; set; }
        public ICollection<BookPublisher> BookPublishersNavigation { get; set; }
    }
}
