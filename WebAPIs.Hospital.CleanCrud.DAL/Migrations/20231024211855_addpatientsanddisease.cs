using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPIs.Hospital.CleanCrud.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addpatientsanddisease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Speciality",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Disease",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disease", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Patient_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseasePatient",
                columns: table => new
                {
                    DiseasesID = table.Column<int>(type: "int", nullable: false),
                    PatientsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasePatient", x => new { x.DiseasesID, x.PatientsID });
                    table.ForeignKey(
                        name: "FK_DiseasePatient_Disease_DiseasesID",
                        column: x => x.DiseasesID,
                        principalTable: "Disease",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasePatient_Patient_PatientsID",
                        column: x => x.PatientsID,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Disease",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Diabetes" },
                    { 2, "Hypertension" },
                    { 3, "Asthma" },
                    { 4, "Depression" },
                    { 5, "Arthritis" },
                    { 6, "Allergy" },
                    { 7, "Flu" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "ID", "Name", "PerformanceRate", "Salary", "Speciality" },
                values: new object[,]
                {
                    { 1, "Jessie", 65, 27064f, "Hematology" },
                    { 2, "Judy", 32, 18711f, "Neurology" },
                    { 3, "Naomi", 27, 32145f, "Pediatrics" },
                    { 4, "Joann", 72, 9232f, "Hematology" },
                    { 5, "Judy", 19, 48498f, "Dermatology" },
                    { 6, "Alyssa", 79, 16586f, "Gastroenterology" },
                    { 7, "Mable", 5, 33706f, "Infectious Disease" },
                    { 8, "Paula", 0, 19094f, "Urology" },
                    { 9, "Rafael", 97, 12266f, "Pediatrics" },
                    { 10, "Sara", 82, 45041f, "Pediatrics" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "ID", "DoctorID", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Dana" },
                    { 2, 7, "Isaac" },
                    { 3, 9, "Damon" },
                    { 4, 8, "Miriam" },
                    { 5, 7, "Terence" },
                    { 6, 1, "Roosevelt" },
                    { 7, 9, "Eduardo" },
                    { 8, 8, "Wilbert" },
                    { 9, 5, "Tasha" },
                    { 10, 1, "Max" },
                    { 11, 2, "BrIDget" },
                    { 12, 8, "Juan" },
                    { 13, 10, "Krystal" },
                    { 14, 10, "Erma" },
                    { 15, 6, "Orlando" },
                    { 16, 5, "Marvin" },
                    { 17, 4, "Lamar" },
                    { 18, 7, "Joe" },
                    { 19, 8, "Wendell" },
                    { 20, 4, "Sandra" },
                    { 21, 6, "Stephanie" },
                    { 22, 7, "Ervin" },
                    { 23, 4, "Beth" },
                    { 24, 7, "Gretchen" },
                    { 25, 2, "Gwendolyn" },
                    { 26, 7, "Jerry" },
                    { 27, 6, "Mitchell" },
                    { 28, 8, "Maggie" },
                    { 29, 3, "Sandy" },
                    { 30, 2, "Lloyd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseasePatient_PatientsID",
                table: "DiseasePatient",
                column: "PatientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorID",
                table: "Patient",
                column: "DoctorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseasePatient");

            migrationBuilder.DropTable(
                name: "Disease");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Speciality",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
