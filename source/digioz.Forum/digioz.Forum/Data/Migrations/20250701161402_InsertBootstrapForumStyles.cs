using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertBootstrapForumStyles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumStyle",
                columns: new[] { "StyleId", "StyleName", "StyleCopyright", "StyleActive", "StylePath", "BbcodeBitField", "StyleParentId", "StyleParentTree" },
                columnTypes: new[] { "int", "nvarchar(255)", "nvarchar(255)", "int", "nvarchar(255)", "nvarchar(255)", "int", "nvarchar(255)" },
                values: new object[,]
                {
                    { 3, "bootstrap", "&copy; Bootstrap", 0, "bootstrap", "//g=", 0, "" },
                    { 4, "bootstrap_dark", "&copy; Bootstrap", 0, "bootstrap_dark", "//g=", 0, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumStyle",
                keyColumn: "StyleId",
                keyValues: new object[] { 3, 4 });
        }
    }
}
