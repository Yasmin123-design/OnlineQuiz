using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuiz.Migrations
{
    /// <inheritdoc />
    public partial class delete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // حذف خيارات الأسئلة في فئة العلوم
            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Mitochondria", 1 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Nucleus", 1 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Ribosome", 1 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "H2O", 2 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "O2", 2 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "CO2", 2 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "300,000 kilometers per second", 3 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "150,000 kilometers per second", 3 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "400,000 kilometers per second", 3 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Leaves", 4 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Roots", 4 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Stem", 4 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Carbon Dioxide", 5 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Oxygen", 5 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Nitrogen", 5 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Skin", 6 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Heart", 6 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Liver", 6 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Cell", 7 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Tissue", 7 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Organ", 7 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "To transport oxygen", 8 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "To transport nutrients", 8 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "To fight infections", 8 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Mars", 9 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Venus", 9 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Jupiter", 9 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Condensation", 10 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Evaporation", 10 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Sublimation", 10 });

            // حذف خيارات الأسئلة في فئة اللغة العربية
            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "كتب", 11 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "يكتب", 11 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "كتبت", 11 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "مكتبات", 12 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "مكتبتين", 12 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "مكتبة", 12 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Book", 13 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Notebook", 13 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Paper", 13 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "قصير", 14 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "عريض", 14 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "طويل", 14 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Peace", 15 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Love", 15 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "War", 15 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Elephant", 16 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Lion", 16 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Tiger", 16 });

            // حذف خيارات الأسئلة في فئة اللغة العربية
            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "قمر", 17 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "شمس", 17 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "نجمة", 17 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "معلم", 18 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "طالب", 18 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "مدير", 18 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "أكل", 19 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "يأكل", 19 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "يأكله", 19 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "ماء", 20 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "هواء", 20 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "أرض", 20 });

            // حذف خيارات الأسئلة في فئة الرياضيات
            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "12", 21 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "13", 21 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "14", 21 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "0.5 × Base × Height", 22 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Base × Height", 22 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "Length × Width", 22 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "8", 23 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "6", 23 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "10", 23 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "3", 24 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "4", 24 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "2", 24 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "54", 25 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "60", 25 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "48", 25 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "16", 26 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "20", 26 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "14", 26 });
            migrationBuilder.DeleteData(
    table: "Choices",
    keyColumns: new[] { "Name", "QuestionId" },
    keyValues: new object[] { "90", 28 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "80", 28 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "100", 28 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "180 degrees", 29 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "360 degrees", 29 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "90 degrees", 29 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "3.14", 30 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "3.15", 30 });

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumns: new[] { "Name", "QuestionId" },
                keyValues: new object[] { "3.16", 30 });
            migrationBuilder.DeleteData(
    table: "Questions",
    keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
    keyValues: new object[] { "What is the powerhouse of the cell?", "Mitochondria", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the chemical symbol for water?", "H2O", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the speed of light in vacuum?", "300,000 kilometers per second", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "Which part of the plant conducts photosynthesis?", "Leaves", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What gas do plants absorb from the atmosphere?", "Carbon Dioxide", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the largest organ in the human body?", "Skin", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the basic unit of life?", "Cell", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the main function of red blood cells?", "To transport oxygen", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "Which planet is known as the Red Planet?", "Mars", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the process by which water vapor turns into liquid water?", "Condensation", 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the past tense of 'يكتب' (to write)?", "كتب", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the plural of 'مكتبة' (library)?", "مكتبات", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the English translation of the Arabic word 'كتاب'?", "Book", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the opposite of 'طويل' (tall)?", "قصير", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the meaning of 'سلام' in English?", "Peace", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What does 'فيل' mean in English?", "Elephant", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the Arabic word for 'moon'?", "قمر", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the Arabic word for 'teacher'?", "معلم", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the past tense of 'يأكل' (to eat)?", "أكل", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the Arabic word for 'water'?", "ماء", 3 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the value of 7 + 5?", "12", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the formula for the area of a triangle?", "0.5 × Base × Height", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the square root of 64?", "8", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the value of 12 ÷ 4?", "3", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the result of 9 × 6?", "54", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the perimeter of a rectangle with length 5 and width 3?", "16", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the value of x if 2x + 4 = 12?", "4", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "How many degrees are in a right angle?", "90", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the sum of the angles in a triangle?", "180 degrees", 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumns: new[] { "Name", "CorrectAnswer", "CategoryId" },
                keyValues: new object[] { "What is the value of π (pi) to two decimal places?", "3.14", 2 });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
