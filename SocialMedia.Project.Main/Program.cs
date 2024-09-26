using SocialMedia.Project.DAL.Repositories.Concrate;
using SocialMedia.Project.DAL.Repositories.Abstract;
using SocialMedia.Project.Models.Entities.Concrate;
using System;


namespace SocialMedia.Project.Main
{
    class Program
    {

 
        static void Main(string[] args)
        {
            using (var context = new SocialMediaDbContext())
            {
                using (var unitOfWork = new UnitOfWork(context))
                {
                    // Yeni UserDetails elave edek
                    var userDetails = new UserDetails
                    {
                        Name = "Aygun",
                        Surname = "Bayramova",
                        Birthday = new DateTime(2004, 9, 4),
                        Role = Role.User
                    };

                    unitOfWork.UserDetails.Add(userDetails);
                    unitOfWork.Complete();

                    Console.WriteLine("UserDetails daxil edildi");

                    // Yeni User elave edek
                    var newUser = new User
                    {
                        UserDetails = userDetails
                    };

                    unitOfWork.Users.Add(newUser);
                    unitOfWork.Complete();
                    Console.WriteLine("User əlavə olundu");

                    // Bütün istifadəçiləri gətirmək
                    var users = unitOfWork.Users.GetAll();
                    foreach (var user in users)
                    {
                        Console.WriteLine($"User ID: {user.Id}, Name: {user.UserDetails.Name}, Role: {user.UserDetails.Role}");
                    }

                    // İstifadeci yenilemek
                    var userToUpdate = unitOfWork.Users.GetById(newUser.Id);
                    if (userToUpdate != null)
                    {
                        userToUpdate.UserDetails.Name = "Sema";
                        userToUpdate.UserDetails.Surname = "Bayramova";
                        unitOfWork.Users.Update(userToUpdate.Id);
                        unitOfWork.Complete();
                        Console.WriteLine("User yenilendi");
                    }

                    // Yeni Post elave etmek
                    var newPost = new Post
                    {
                        Text = "One of the best days in my life",
                        LikeCount = 777,
                        CreatedDate = DateTime.Now
                    };
                    unitOfWork.Posts.Add(newPost);
                    unitOfWork.Complete();
                    Console.WriteLine("Postunuz yuklendi");

                    // Butun postlari gostermek
                    var posts = unitOfWork.Posts.GetAll();
                    foreach (var post in posts)
                    {
                        Console.WriteLine($"Post ID: {post.Id}, Text: {post.Text}, Likes: {post.LikeCount}");
                    }

                    // Yeni Comment elave etmek
                    var newComment = new Comment
                    {
                        Text = "!No Comment!",
                        LikeCount = 777,
                        PostId = newPost.Id,
                        CreatedDate = DateTime.Now
                    };
                    unitOfWork.Comments.Add(newComment);
                    unitOfWork.Complete();
                    Console.WriteLine("Comment elave edildi!");

                    // Butun kommentleri gostermek
                    var comments = unitOfWork.Comments.GetAll();
                    foreach (var comment in comments)
                    {
                        Console.WriteLine($"Comment ID: {comment.Id}, Text: {comment.Text}, Likes: {comment.LikeCount}");
                    }
                }
            }
        }
    }
}
