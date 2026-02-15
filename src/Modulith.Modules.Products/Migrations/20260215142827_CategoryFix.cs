using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modulith.Modules.Products.Migrations
{
    /// <inheritdoc />
    public partial class CategoryFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("05237d85-80d1-428f-a3b3-3d9630707692"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("2a6e4b52-6a81-4b71-ad7f-01f4de15cd84"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("33dd7bda-2b23-47cc-bbf9-fffdc286f92c"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("39bde98d-4565-4d9c-a4a6-d0e6d24ae37f"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("54ad2e44-2239-4782-819c-e78495029250"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("5c4f30d3-6330-4470-b6a3-a01261b33e46"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("5edd6b26-67d1-45c1-9857-e2a3b7dfce82"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("806bfc07-aabc-4a37-a892-0c811f3dc09c"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("9d618fe1-8ba6-4801-8f71-3349b7966428"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("a3285a3f-a7c4-4edc-8ef9-26627f9ac5b0"));

            migrationBuilder.AlterColumn<Guid>(
                name: "version",
                table: "products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("2bf0baa8-4979-4338-a60a-412fe8490033"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("f1d33def-5831-4d10-8471-2af0d1129a44"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_date",
                table: "products",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 873, DateTimeKind.Utc).AddTicks(2240),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 248, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 873, DateTimeKind.Utc).AddTicks(1650),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 248, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.AlterColumn<Guid>(
                name: "version",
                table: "categories",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("b0ad8aaa-7137-4f1e-8543-3000faaf4509"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("03e65255-1f6a-4ea9-8132-a90122045dd5"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_date",
                table: "categories",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 869, DateTimeKind.Utc).AddTicks(4390),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 243, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 868, DateTimeKind.Utc).AddTicks(5350),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 242, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "created_date", "description", "name", "version" },
                values: new object[,]
                {
                    { new Guid("567b3e58-5b63-4052-9338-64880a64c2a1"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3230), "Books designed to provoke excitement, tension, and suspense, often involving danger and high stakes.", "Thriller", new Guid("0cfe8965-e5e3-49cf-8411-4c8f9b003b9b") },
                    { new Guid("5751fa0e-4e3c-43cf-960c-0c30ba41b5e9"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3230), "Books set in the past, often blending fictional characters and events with real historical contexts.", "Historical Fiction", new Guid("5a91f931-23e9-43ff-ae56-cd08a2299c73") },
                    { new Guid("5f2d7456-1639-4d66-b852-533f0ab3752d"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3210), "Books centered around solving a crime or unraveling a puzzle, often featuring detectives or amateur sleuths.", "Mystery", new Guid("67cb5f42-9f91-459a-90f4-6ce6f59f394a") },
                    { new Guid("7f49e612-e3f9-47f3-94c0-7768e56bb0a1"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(2320), "Books featuring magical or supernatural elements often set in imaginary worlds.", "Fantasy", new Guid("10fa1bf7-75b6-4f40-ab57-52841bb0a633") },
                    { new Guid("7fe4066e-18eb-446e-91ec-793c43a0eb45"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3260), "Books offering advice, guidance, and strategies for personal growth, improvement, and self-discovery.", "Self-Help", new Guid("b8c68edf-270e-4429-98ca-31a1db8dfd28") },
                    { new Guid("97470322-75ea-4426-8556-e760aee87769"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3220), "Books focusing on romantic relationships and emotional connections between characters.", "Romance", new Guid("e65b6790-3c0c-40f2-886d-a8028f28ecda") },
                    { new Guid("a7ce8d63-7abd-4964-a720-d786518473d3"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3240), "Books intended to evoke fear, dread, or terror through supernatural or psychological elements.", "Horror", new Guid("b5bc25f5-0375-49fa-bb5e-45b16e6379d2") },
                    { new Guid("ab5a920f-4b96-4961-939f-7dd531c6cde4"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3250), "Books recounting the life and experiences of a real person, often written by another individual.", "Biography", new Guid("ed4f1bd5-bf46-40cb-b490-9065943ab4ec") },
                    { new Guid("b594495b-eaed-4534-a8d2-205e3bde221d"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3170), "Books exploring speculative concepts such as advanced science and technology, space exploration, or futuristic societies.", "Science Fiction", new Guid("c6935c57-651c-4edd-bf4c-59973ed43c4d") },
                    { new Guid("c6f265fa-98bd-4f53-bb64-d5a83e6dfa81"), new DateTime(2026, 2, 15, 14, 28, 26, 872, DateTimeKind.Utc).AddTicks(3260), "Books providing recipes, cooking techniques, and culinary inspiration for preparing various dishes and cuisines.", "Cooking", new Guid("0350a75b-9b9b-4239-a16c-939781f4a478") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("567b3e58-5b63-4052-9338-64880a64c2a1"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("5751fa0e-4e3c-43cf-960c-0c30ba41b5e9"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("5f2d7456-1639-4d66-b852-533f0ab3752d"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("7f49e612-e3f9-47f3-94c0-7768e56bb0a1"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("7fe4066e-18eb-446e-91ec-793c43a0eb45"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("97470322-75ea-4426-8556-e760aee87769"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("a7ce8d63-7abd-4964-a720-d786518473d3"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("ab5a920f-4b96-4961-939f-7dd531c6cde4"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("b594495b-eaed-4534-a8d2-205e3bde221d"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: new Guid("c6f265fa-98bd-4f53-bb64-d5a83e6dfa81"));

            migrationBuilder.AlterColumn<Guid>(
                name: "version",
                table: "products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("f1d33def-5831-4d10-8471-2af0d1129a44"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("2bf0baa8-4979-4338-a60a-412fe8490033"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_date",
                table: "products",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 248, DateTimeKind.Utc).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 873, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 248, DateTimeKind.Utc).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 873, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.AlterColumn<Guid>(
                name: "version",
                table: "categories",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("03e65255-1f6a-4ea9-8132-a90122045dd5"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("b0ad8aaa-7137-4f1e-8543-3000faaf4509"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "update_date",
                table: "categories",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 243, DateTimeKind.Utc).AddTicks(4913),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 869, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 23, 10, 27, 55, 242, DateTimeKind.Utc).AddTicks(3065),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2026, 2, 15, 14, 28, 26, 868, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "created_date", "description", "name", "version" },
                values: new object[,]
                {
                    { new Guid("05237d85-80d1-428f-a3b3-3d9630707692"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5530), "Books offering advice, guidance, and strategies for personal growth, improvement, and self-discovery.", "Self-Help", new Guid("5ed284d7-3180-46c4-8a49-8cf6ac4c8f2d") },
                    { new Guid("2a6e4b52-6a81-4b71-ad7f-01f4de15cd84"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5443), "Books exploring speculative concepts such as advanced science and technology, space exploration, or futuristic societies.", "Science Fiction", new Guid("88c9f1b6-0a72-4cf1-b1cd-d6e05585459d") },
                    { new Guid("33dd7bda-2b23-47cc-bbf9-fffdc286f92c"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5505), "Books centered around solving a crime or unraveling a puzzle, often featuring detectives or amateur sleuths.", "Mystery", new Guid("553ce211-6136-4762-b96a-3deb7ba73d50") },
                    { new Guid("39bde98d-4565-4d9c-a4a6-d0e6d24ae37f"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5521), "Books designed to provoke excitement, tension, and suspense, often involving danger and high stakes.", "Thriller", new Guid("63cd68b4-4aee-44c0-b2d9-cbc07d3b3ceb") },
                    { new Guid("54ad2e44-2239-4782-819c-e78495029250"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5533), "Books providing recipes, cooking techniques, and culinary inspiration for preparing various dishes and cuisines.", "Cooking", new Guid("cbd4fa8c-51f0-40f3-8f0e-cc1de656b454") },
                    { new Guid("5c4f30d3-6330-4470-b6a3-a01261b33e46"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(4409), "Books featuring magical or supernatural elements often set in imaginary worlds.", "Fantasy", new Guid("20f7f85b-f4e7-46fb-9804-ba999e510e57") },
                    { new Guid("5edd6b26-67d1-45c1-9857-e2a3b7dfce82"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5523), "Books intended to evoke fear, dread, or terror through supernatural or psychological elements.", "Horror", new Guid("b859aa05-57f9-4b11-bdfe-a66944cd25d1") },
                    { new Guid("806bfc07-aabc-4a37-a892-0c811f3dc09c"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5508), "Books focusing on romantic relationships and emotional connections between characters.", "Romance", new Guid("a42b0c3f-a0d3-45cf-9804-7fb54647f086") },
                    { new Guid("9d618fe1-8ba6-4801-8f71-3349b7966428"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5515), "Books set in the past, often blending fictional characters and events with real historical contexts.", "Historical Fiction", new Guid("9ff398f0-1468-490e-9da9-193b69c6c6ee") },
                    { new Guid("a3285a3f-a7c4-4edc-8ef9-26627f9ac5b0"), new DateTime(2024, 4, 23, 10, 27, 55, 247, DateTimeKind.Utc).AddTicks(5526), "Books recounting the life and experiences of a real person, often written by another individual.", "Biography", new Guid("fab13603-1716-4b2c-a66e-5937ce5a16c6") }
                });
        }
    }
}
