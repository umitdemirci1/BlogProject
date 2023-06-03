using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedIsGiven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("305dc2e9-cadd-44a7-8a8a-615d7212bea9"), "Admin 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, "Category 1" },
                    { new Guid("9868f285-d7b9-4b5e-83e9-8faa1d11ddfc"), "Admin 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, "Category 1" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("03c51e94-26da-479d-8964-e4ea95b2769c"), "Admin2", new DateTime(2023, 6, 3, 22, 17, 25, 326, DateTimeKind.Local).AddTicks(1596), null, null, "images/testImage2", "jpg", false, null, null },
                    { new Guid("5a77421e-a2e0-461e-9d83-be79cc0f353b"), "Admin1", new DateTime(2023, 6, 3, 22, 17, 25, 326, DateTimeKind.Local).AddTicks(1593), null, null, "images/testImage1", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("696debf9-4b26-4e5f-aebb-c2ce94c3a06e"), new Guid("305dc2e9-cadd-44a7-8a8a-615d7212bea9"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ante metus dictum at tempor commodo ullamcorper a lacus. Sapien pellentesque habitant morbi tristique. Amet facilisis magna etiam tempor orci eu lobortis. Velit dignissim sodales ut eu sem integer vitae. Orci dapibus ultrices in iaculis nunc sed. Vitae congue eu consequat ac felis donec et odio pellentesque. Sed odio morbi quis commodo. Ante in nibh mauris cursus mattis molestie a iaculis at. Fermentum et sollicitudin ac orci phasellus egestas. Ut placerat orci nulla pellentesque dignissim. Amet est placerat in egestas erat. Mauris augue neque gravida in fermentum. In arcu cursus euismod quis viverra nibh cras.", "Admin 2", new DateTime(2023, 6, 3, 22, 17, 25, 326, DateTimeKind.Local).AddTicks(1219), null, null, new Guid("03c51e94-26da-479d-8964-e4ea95b2769c"), false, null, null, "Second Title", 8 },
                    { new Guid("c46a6610-6570-409f-9b70-5e1a5add6bdb"), new Guid("9868f285-d7b9-4b5e-83e9-8faa1d11ddfc"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin 1", new DateTime(2023, 6, 3, 22, 17, 25, 326, DateTimeKind.Local).AddTicks(1213), null, null, new Guid("5a77421e-a2e0-461e-9d83-be79cc0f353b"), false, null, null, "First Title", 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("696debf9-4b26-4e5f-aebb-c2ce94c3a06e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c46a6610-6570-409f-9b70-5e1a5add6bdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("305dc2e9-cadd-44a7-8a8a-615d7212bea9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9868f285-d7b9-4b5e-83e9-8faa1d11ddfc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("03c51e94-26da-479d-8964-e4ea95b2769c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5a77421e-a2e0-461e-9d83-be79cc0f353b"));
        }
    }
}
