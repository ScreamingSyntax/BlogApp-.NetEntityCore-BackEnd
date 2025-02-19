﻿using Domain.BisleriumBlog;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BisleriumBlog
{
    public interface IBlogPostService
    {
        Task<BlogPost> AddBlogPost(BlogPost blogPost);
        Task<BlogPost> UpdateBlogPost(BlogPost blogPost);
        Task<bool> DeleteBlogPost(String blogPostId, IDbContextTransaction? transaction = null);
        Task<(IEnumerable<BlogWithReactions> blogPostsWithReactions, int totalCount)> GetAllBlogPosts(int pageNumber, int pageSize, string? sortType);
        Task<IEnumerable<BlogPost?>> GetBlogPostById(String blogPostId);
        Task<IEnumerable<BlogWithReactions>> GetUsersBlogs(String userId); 

        Task<IEnumerable<BlogHistory>> GetUsersBlogHistoru(String userId);

        Task<bool> DeleteAllPostsOfUser (String userId); 
    }
}
