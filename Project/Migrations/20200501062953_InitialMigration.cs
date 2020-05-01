using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsCourseOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Web Development", "Web development refers to building, creating, and an maintaining websites" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Mobile Apps", "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Web design", "Web designers use their creative and software engineering/programing skills to design, build and improve websites" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsCourseOfTheWeek", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://img-a.udemycdn.com/course/240x135/851712_fc61_5.jpg", "https://img-a.udemycdn.com/course/750x422/437398_46c3_9.jpg", true, true, "The Complete JavaScript Course 2020: Build Real Projects!", 20m, "Master JavaScript with the most complete course! Projects, challenges, quizzes, JavaScript ES6+, OOP, AJAX, Webpack" },
                    { 2, 1, "https://img-a.udemycdn.com/course/240x135/1463348_52a4_2.jpg", "https://img-a.udemycdn.com/course/750x422/1463348_52a4_2.jpg", true, true, "Modern JavaScript From The Beginning", 39m, "Learn and build projects with pure JavaScript (No frameworks or libraries)" },
                    { 3, 2, "https://img-a.udemycdn.com/course/240x135/951618_0839_2.jpg", "https://coursedrive.us/wp-content/uploads/2020/02/The-Complete-Android-N-Developer-Course-Drive.jpg", true, true, "The Complete Android N Developer Course", 19m, "Learn Android App Development with Android 7 Nougat by building real apps including Uber, Whatsapp and Instagram!" },
                    { 4, 3, "https://img-a.udemycdn.com/course/240x135/437398_46c3_9.jpg", "https://img-a.udemycdn.com/course/750x422/437398_46c3_9.jpg", true, true, "The easiest way to learn modern web design, HTML5 and CSS3 step-by-step from scratch. Design AND code a huge project", 78m, "The easiest way to learn modern web design, HTML5 and CSS3 step-by-step from scratch. Design AND code a huge project" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
