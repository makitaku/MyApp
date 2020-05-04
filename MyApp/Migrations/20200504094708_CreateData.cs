using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Migrations
{
    public partial class CreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prefectures",
                columns: new[] { "Id", "Name", "Order", "ShortName" },
                values: new object[,]
                {
                    { 1L, "北海道", 1, "北海道" },
                    { 26L, "京都府", 26, "京都" },
                    { 27L, "大阪府", 27, "大阪" },
                    { 28L, "兵庫県", 28, "兵庫" },
                    { 29L, "奈良県", 29, "奈良" },
                    { 30L, "和歌山県", 30, "和歌山" },
                    { 31L, "鳥取県", 31, "鳥取" },
                    { 32L, "島根県", 32, "島根" },
                    { 33L, "岡山県", 33, "岡山" },
                    { 34L, "広島県", 34, "広島" },
                    { 25L, "滋賀県", 25, "滋賀" },
                    { 35L, "山口県", 35, "山口" },
                    { 37L, "香川県", 37, "香川" },
                    { 38L, "愛媛県", 38, "愛媛" },
                    { 39L, "高知県", 39, "高知" },
                    { 40L, "福岡県", 40, "福岡" },
                    { 41L, "佐賀県", 41, "佐賀" },
                    { 42L, "長崎県", 42, "長崎" },
                    { 43L, "熊本県", 43, "熊本" },
                    { 44L, "大分県", 44, "大分" },
                    { 45L, "宮崎県", 45, "宮崎" },
                    { 36L, "徳島県", 36, "徳島" },
                    { 46L, "鹿児島県", 46, "鹿児島" },
                    { 24L, "三重県", 24, "三重" },
                    { 22L, "静岡県", 22, "静岡" },
                    { 2L, "青森県", 2, "青森" },
                    { 3L, "岩手県", 3, "岩手" },
                    { 4L, "宮城県", 4, "宮城" },
                    { 5L, "秋田県", 5, "秋田" },
                    { 6L, "山形県", 6, "山形" },
                    { 7L, "福島県", 7, "福島" },
                    { 8L, "茨城県", 8, "茨城" },
                    { 9L, "栃木県", 9, "栃木" },
                    { 10L, "群馬県", 10, "群馬" },
                    { 23L, "愛知県", 23, "愛知" },
                    { 11L, "埼玉県", 11, "埼玉" },
                    { 13L, "東京都", 13, "東京" },
                    { 14L, "神奈川県", 14, "神奈川" },
                    { 15L, "新潟県", 15, "新潟" },
                    { 16L, "富山県", 16, "富山" },
                    { 17L, "石川県", 17, "石川" },
                    { 18L, "福井県", 18, "福井" },
                    { 19L, "山梨県", 19, "山梨" },
                    { 20L, "長野県", 20, "長野" },
                    { 21L, "岐阜県", 21, "岐阜" },
                    { 12L, "千葉県", 12, "千葉" },
                    { 47L, "沖縄県", 47, "沖縄" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 47L);
        }
    }
}
