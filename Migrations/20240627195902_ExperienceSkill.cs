using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class ExperienceSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Habilities",
                table: "Experiences");

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Experiences",
                type: "TEXT",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Experiences",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Experiences",
                type: "TEXT",
                maxLength: 230,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 230,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "Experiences",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Experiences");

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Experiences",
                type: "TEXT",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Experiences",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Experiences",
                type: "TEXT",
                maxLength: 230,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 230);

            migrationBuilder.AddColumn<string>(
                name: "Habilities",
                table: "Experiences",
                type: "TEXT",
                nullable: true);
        }
    }
}
