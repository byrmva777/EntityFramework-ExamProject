using SocialMedia.Project.DAL.Repositories.Concrate;
using SocialMedia.Project.Models.Entities.Concrate;
using System;

namespace SocialMedia.Project.Main 
{
    class Program
    {
        private static object userRepository;
        private static object commentRepository;
        private static object postRepository;

        static void Main(string[] args)
        {

            using (var context = new SocialMediaDbContext())
            {

                var userRepository = new BaseRepository<User>(context);
                var userDetailsRepository = new BaseRepository<UserDetails>(context);
                var postRepository = new BaseRepository<Post>(context);
                var commentRepository = new BaseRepository<Comment>(context);



                var userDetails = new UserDetails
                {
                    Name = "Aygun ",
                    Surname = "Bayramova",
                    Birthday = new DateTime(2004, 9, 4),
                    Role = Role.User
                };

                userDetailsRepository.Add(userDetails);
                userDetailsRepository.SaveChanges();
            };

       
//            Console.WriteLine("Melumatlar daxil edildi");

//            var newUser = new User
//            {
//                UserDetails = userDetails
//            };
//            //userRepository.Add(newUser);
//            //userRepository.SaveChanges();


//            var newUser2 = new User
//            {
//                UserDetails = userDetails
//            };
//            //userRepository.Add(newUser2);
//            //userRepository.SaveChanges();

//            Console.WriteLine("User elave olundu");


//            var users = userRepository.GetAll();
//            foreach (var user in users)
//            {
//                Console.WriteLine($"User ID: {user.Id}, Name: {user.UserDetails.Name}, Role: {user.UserDetails.Role}");
//            }


//            var userToUpdate = userRepository.GetById(newUser.Id);
//            if (userToUpdate != null)
//            {
//                userToUpdate.UserDetails.Name = "Sema";
//                userToUpdate.UserDetails.Surname = "Bayramova";
//                userRepository.Update(userToUpdate.Id);
//                Console.WriteLine("Update olundu");
//            }


//            var newPost = new Post
//            {
//                Text = "One of the best day in my life",
//                LikeCount = 777,
//                CreatedDate = DateTime.Now
//            };
//            postRepository.Add(newPost);
//            Console.WriteLine("Postunuz yuklendi");


//            var posts = postRepository.GetAll();
//            foreach (var post in posts)
//            {
//                Console.WriteLine($"Post ID: {post.Id}, Text: {post.Text}, Likes: {post.LikeCount}");
//            }


//            var newComment = new Comment
//            {
//                Text = "!No Comment!",
//                LikeCount = 777,
//                PostId = newPost.Id,
//                CreatedDate = DateTime.Now
//            };
//            commentRepository.Add(newComment);
//            Console.WriteLine("Komment elave edildi!");

//            var comments = commentRepository.GetAll();
//            foreach (var comment in comments)
//            {
//                Console.WriteLine($"Comment ID: {comment.Id}, Text: {comment.Text}, Likes: {comment.LikeCount}");
//            }

        }
    }
}








