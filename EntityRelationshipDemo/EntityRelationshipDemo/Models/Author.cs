namespace EntityRelationshipDemo.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublisherId { get; set; }
        public int BookId { get; set; }
        public Publisher PublisherNavigation { get; set; }
        public ICollection<Book> BooksNavigation { get; set; }
    }
}
