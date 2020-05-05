using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Project.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }



        public DbSet<Course> Courses { get; set; }
        public DbSet<WhatYouWillLearn> WhatYouWillLearns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Web Development", Description = "Web development refers to building, creating, and an maintaining websites" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Mobile Apps", Description = "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Web design", Description = "Web designers use their creative and software engineering/programing skills to design, build and improve websites" });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 1,
                Name = "The Complete JavaScript Course 2020: Build Real Projects!",
                Price = 20M,
                ShortDescription = "Master JavaScript with the most complete course! Projects, challenges, quizzes, JavaScript ES6+, OOP, AJAX, Webpack",
                WhatYouWillLearn = new List<WhatYouWillLearn>
                {
                    new WhatYouWillLearn{ WhatYouWillLearnId = 1, CourseId = 1, Text = "Go from a total beginner to an advanced JavaScript developer" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 2, CourseId = 1, Text = "JavaScript and programming fundamentals: variables, boolean logic, if/else, loops, functions, arrays, etc." },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 3, CourseId = 1, Text = "Asynchronous JavaScript: The event loop, promises, async/await, AJAX and APIs" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 4, CourseId = 1, Text = "Code 3 beautiful real-world apps with both ES5 and ES6+ (no boring toy apps here)" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 5, CourseId = 1, Text = "Modern JavaScript for 2020: NPM, Webpack, Babel and ES6 modules" }
                },
                ImageThumbnailUrl = "https://img-a.udemycdn.com/course/240x135/851712_fc61_5.jpg",
                ImageUrl = "https://img-a.udemycdn.com/course/750x422/437398_46c3_9.jpg",
                IsCourseOfTheWeek = true,
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 2,
                Name = "Modern JavaScript From The Beginning",
                Price = 39M,
                ShortDescription = "Learn and build projects with pure JavaScript (No frameworks or libraries)",
                WhatYouWillLearn = new List<WhatYouWillLearn>
                {
                    new WhatYouWillLearn{ WhatYouWillLearnId = 1, CourseId = 2, Text = "Modular learning sections & 10 real world projects with pure JavaScript" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 2, CourseId = 2, Text = "Master the DOM(document object model) WITHOUT jQuery " },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 3, CourseId = 2, Text = "Asynchronous programming with Ajax, Fetch API, Promises & Async / Await" }
                },
                ImageThumbnailUrl = "https://img-a.udemycdn.com/course/240x135/1463348_52a4_2.jpg",
                ImageUrl = "https://img-a.udemycdn.com/course/750x422/1463348_52a4_2.jpg",
                IsCourseOfTheWeek = true,
                InStock = true,
                CategoryId = 1,
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 3,
                Name = "The Complete Android N Developer Course",
                Price = 19M,
                ShortDescription = "Learn Android App Development with Android 7 Nougat by building real apps including Uber, Whatsapp and Instagram!",
                WhatYouWillLearn = new List<WhatYouWillLearn>
                {
                    new WhatYouWillLearn{ WhatYouWillLearnId = 1, CourseId = 3, Text = "Real-world skills to build real-world websites: professional, beautiful and truly responsive websites" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 2, CourseId = 3, Text = "A huge project that will teach you everything you need to know to get started with HTML5 and CSS3" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 3, CourseId = 3, Text = "The proven 7 real - world steps from complete scratch to a fully functional and optimized website" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 4, CourseId = 3, Text = "Simple - to - use web design guidelines and tips to make your website stand out from the crowd" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 5, CourseId = 3, Text = "Learn super cool jQuery effects like animations" }
                },
                ImageThumbnailUrl = "https://img-a.udemycdn.com/course/240x135/951618_0839_2.jpg",
                ImageUrl = "https://coursedrive.us/wp-content/uploads/2020/02/The-Complete-Android-N-Developer-Course-Drive.jpg",
                IsCourseOfTheWeek = true,
                InStock = true,
                CategoryId = 2
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 4,
                Name = "The easiest way to learn modern web design, HTML5 and CSS3 step-by-step from scratch. Design AND code a huge project",
                Price = 78M,
                ShortDescription = "The easiest way to learn modern web design, HTML5 and CSS3 step-by-step from scratch. Design AND code a huge project",
                WhatYouWillLearn = new List<WhatYouWillLearn>
                {
                    new WhatYouWillLearn{ WhatYouWillLearnId = 1, CourseId = 4, Text = "Real-world skills to build real-world websites: professional, beautiful and truly responsive websites" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 2, CourseId = 4, Text = "The proven 7 real-world steps from complete scratch to a fully functional and optimized website" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 3, CourseId = 4, Text = "A huge project that will teach you everything you need to know to get started with HTML5 and CSS3" },
                    new WhatYouWillLearn{ WhatYouWillLearnId = 4, CourseId = 4, Text = "Simple-to-use web design guidelines and tips to make your website stand out from the crowd" }
                },
                ImageThumbnailUrl = "https://img-a.udemycdn.com/course/240x135/437398_46c3_9.jpg",
                ImageUrl = "https://img-a.udemycdn.com/course/750x422/437398_46c3_9.jpg",
                IsCourseOfTheWeek = true,
                InStock = true,
                CategoryId = 3
            });
        }
    }
}
