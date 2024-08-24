using Blog.Models;

namespace Blog.Repositories.Abstractions;

public interface IPostsRepository
{
    Task<IEnumerable<Post>> GetAll();
}