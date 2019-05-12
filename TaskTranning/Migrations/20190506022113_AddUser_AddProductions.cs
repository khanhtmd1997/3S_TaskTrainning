using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTranning.Migrations
{
    public partial class AddUser_AddProductions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreName = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ModelYear = table.Column<int>(nullable: false),
                    ListPrice = table.Column<decimal>(nullable: false),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => new { x.ProductId, x.StoreId });
                    table.ForeignKey(
                        name: "FK_Stock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "BrandName" },
                values: new object[,]
                {
                    { 1, "Pro" },
                    { 2, "XMax" },
                    { 3, "xxx" },
                    { 4, "S+" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Iphone" },
                    { 2, "Oppo" },
                    { 3, "Samsung" },
                    { 4, "Nokia" },
                    { 5, "Hawai" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "City", "Email", "FirstName", "LastName", "Phone", "State", "Street", "ZipCode" },
                values: new object[] { 1, "Hue City", "customer@gmail.com", "Nguyen Van", "Khanh", 364606406, "", "18/11 Thuy Tu", "49000" });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "City", "Email", "Phone", "State", "StoreName", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Hue City", "khanhtmd99@gmail.com", 364606406, "", "KhanhStore", "18/11 Thuy Tu", "49000" },
                    { 2, "Hue City", "Loc97@gmail.com", 364606406, "", "LocStore", "18/11 Thuy Tu", "49000" },
                    { 3, "Hue City", "Huan97@gmail.com", 364606406, "", "HuanStore", "18/11 Thuy Tu", "49000" },
                    { 4, "Hue City", "Tuan97@gmail.com", 364606406, "", "TuanStore", "18/11 Thuy Tu", "49000" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CategoryId", "ListPrice", "ModelYear", "Picture", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, 1, 1m, 1, "logo.jpg", "Iphone 7" },
                    { 2, 1, 1, 1m, 1, "logo.jpg", "Iphone X" },
                    { 3, 1, 1, 1m, 1, "logo.jpg", "Oppo S10" },
                    { 4, 1, 1, 1m, 1, "logo.jpg", "Samsung S10+" },
                    { 5, 1, 1, 1m, 1, "logo.jpg", "Lumia" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "FullName", "IsActive", "PassWord", "Phone", "Picture", "StoreId" },
                values: new object[] { 1, "18/11 Thuy Tu", "khanhtmd97@gmail.com", "Nguyen Van Khanh", true, "10000:HhTGg7oLgnnEv9ms1t0Brh6XBaecLRHmAHn8NiV72vI6m/iv", 364606406, "logo.jpg", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_StoreId",
                table: "Stock",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StoreId",
                table: "User",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
