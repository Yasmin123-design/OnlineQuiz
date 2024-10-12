using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuiz.Migrations
{
    /// <inheritdoc />
    public partial class insertchoices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
table: "Choices",
columns: new[] { "Name", "QuestionId" },
values: new object[,]
{
        // خيارات الأسئلة في فئة العلوم
               { "Mitochondria", 62 },
               { "Nucleus", 62 },
               { "Ribosome", 62 },

               { "H2O", 63 },
               { "O2", 63 },
               { "CO2", 63 },

               { "300,000 kilometers per second", 64 },
               { "150,000 kilometers per second", 64 },
               { "400,000 kilometers per second", 64 },

               { "Leaves", 65 },
               { "Roots", 65 },
               { "Stem", 65 },

               { "Carbon Dioxide", 66 },
               { "Oxygen", 66 },
               { "Nitrogen", 66 },

               { "Skin", 67 },
               { "Heart", 67 },
                { "Liver", 67 },

               { "Cell", 68 },
        { "Tissue", 68 },
        { "Organ", 68 },

        { "To transport oxygen", 69 },
        { "To transport nutrients", 69 },
        { "To fight infections", 69 },

        { "Mars", 70 },
        { "Venus", 70 },
        { "Jupiter", 70 },

        { "Condensation", 71 },
        { "Evaporation", 71 },
        { "Sublimation", 71 },



        // خيارات الأسئلة في فئة اللغة العربية
        { "كتب", 72 },
        { "يكتب", 72 },
        { "كتبت", 72 },

        { "مكتبات", 73 },
        { "مكتبتين", 73 },
        { "مكتبة", 73 },

        { "Book", 74 },
        { "Notebook", 74 },
        { "Paper", 74 },

        { "قصير",75 },
        { "عريض", 75 },
        { "طويل", 75 },

        { "Peace", 76 },
        { "Love", 76 },
        { "War", 76 },

        { "Elephant", 77 },
        { "Lion", 77 },
        { "Tiger", 77 },

        { "قمر", 78 },
        { "شمس", 78 },
        { "نجمة", 78 },

        { "معلم", 79 },
        { "طالب", 79 },
        { "مدير", 79 },

        { "أكل", 80 },
        { "يأكل", 80 },
        { "يأكله", 80 },

        { "ماء", 81 },
        { "هواء", 81 },
        { "أرض", 81 },
         // خيارات الأسئلة في فئة الرياضيات
        { "12", 82 },
        { "13", 82 },
        { "14", 82 },

        { "0.5 × Base × Height", 83 },
        { "Base × Height", 83 },
        { "Length × Width", 83 },

        { "8", 84 },
        { "6", 84 },
        { "10", 84 },

        { "3", 85 },
        { "4", 85 },
        { "2", 85 },

        { "54", 86 },
        { "60", 86 },
        { "48", 86 },

        { "16", 87 },
        { "20", 87 },
        { "14", 87 },

        { "4", 88 },
        { "2", 88 },
        { "6", 88 },

        { "90", 89 },
        { "80", 89 },
        { "100", 89 },

        { "180 degrees", 90 },
        { "360 degrees", 90 },
        { "90 degrees", 90 },

        { "3.14", 91 },
        { "3.15", 91 },
        { "3.16", 91 },


});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
