using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroVMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ItemRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemRequestMasters",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedBy = table.Column<long>(type: "bigint", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsBranchApproved = table.Column<bool>(type: "bit", nullable: false),
                    BranchApprovedUserID = table.Column<long>(type: "bigint", nullable: true),
                    BranchApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsHeadOfficeApproved = table.Column<bool>(type: "bit", nullable: false),
                    HeadOfficeApprovedUserID = table.Column<long>(type: "bigint", nullable: true),
                    HeadOfficeApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRequestMasters", x => x.RequestId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemRequestMasters");
        }
    }
}
