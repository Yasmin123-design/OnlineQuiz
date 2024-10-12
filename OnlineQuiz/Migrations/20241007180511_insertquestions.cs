using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuiz.Migrations
{
    /// <inheritdoc />
    public partial class insertquestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
table: "Questions",
columns: new[] { "Name", "CorrectAnswer", "CategoryId" },
values: new object[,]
{
                  { "What is the powerhouse of the cell?", "Mitochondria", 10 },
                  { "What is the chemical symbol for water?", "H2O", 10 },
                  { "What is the speed of light in vacuum?", "300,000 kilometers per second", 10 },
                  { "Which part of the plant conducts photosynthesis?", "Leaves", 10 },
                  { "What gas do plants absorb from the atmosphere?", "Carbon Dioxide", 10 },
                  { "What is the largest organ in the human body?", "Skin", 10 },
                  { "What is the basic unit of life?", "Cell", 10 },
                  { "What is the main function of red blood cells?", "To transport oxygen", 10 },
                  { "Which planet is known as the Red Planet?", "Mars", 10 },
                  { "What is the process by which water vapor turns into liquid water?", "Condensation", 10 },
                  { "What is the past tense of 'يكتب' (to write)?", "كتب", 12 },
                  { "What is the plural of 'مكتبة' (library)?", "مكتبات", 12 },
                  { "What is the English translation of the Arabic word 'كتاب'?", "Book", 12 },
                  { "What is the opposite of 'طويل' (tall)?", "قصير", 12 },
                  { "What is the meaning of 'سلام' in English?", "Peace", 12 },
                  { "What does 'فيل' mean in English?", "Elephant", 12 },
                  { "What is the Arabic word for 'moon'?", "قمر", 12 },
                  { "What is the Arabic word for 'teacher'?", "معلم", 12 },
                  { "What is the past tense of 'يأكل' (to eat)?", "أكل", 12 },
                  { "What is the Arabic word for 'water'?", "ماء", 12 },
                  { "What is the value of 7 + 5?", "12", 11 },
                  { "What is the formula for the area of a triangle?", "0.5 × Base × Height", 11 },
                  { "What is the square root of 64?", "8", 11 },
                  { "What is the value of 12 ÷ 4?", "3", 11 },
                  { "What is the result of 9 × 6?", "54", 11 },
                  { "What is the perimeter of a rectangle with length 5 and width 3?", "16", 11 },
                  { "What is the value of x if 2x + 4 = 12?", "4", 11 },
                  { "How many degrees are in a right angle?", "90", 11 },
                  { "What is the sum of the angles in a triangle?", "180 degrees", 11 },
                  { "What is the value of π (pi) to two decimal places?", "3.14", 11 }
});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
