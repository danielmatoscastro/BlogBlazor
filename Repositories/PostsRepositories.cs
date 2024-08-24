using Blog.Models;
using Blog.Repositories.Abstractions;
using Blog.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Blog.Repositories;

public class PostsRepository : IPostsRepository
{
    private readonly IMongoCollection<Post> _posts;

    public PostsRepository(IOptions<ConnectionStrings> connectionStrings)
    {
        MongoClient client = new MongoClient(connectionStrings.Value.MongoDb);
        IMongoDatabase database = client.GetDatabase("Blog");
        _posts = database.GetCollection<Post>("Posts");
    }

    public async Task<IEnumerable<Post>> GetAll() => await _posts.Find(new BsonDocument()).ToListAsync();
}