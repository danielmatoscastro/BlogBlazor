using MongoDB.Bson;

namespace Blog.Models;

public class Post
{
    public ObjectId Id { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}