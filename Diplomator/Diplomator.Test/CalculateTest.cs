namespace Diplomator.Test
{
    public class CalculateTest
    {
        [Fact]
        public static void CalculateDays_WithSucess_ResultCorrect()
        {
            DateTime dateUniversity = new DateTime(2022, 03, 29);
            DateTime dateToday = new DateTime(2022, 08, 14);
            string daysExpect = "138";

            var result = Calculate.CalculateDays(dateUniversity, dateToday);

            Assert.Equal(daysExpect, result);
        }

        [Theory]
        [InlineData("2022/08/13", "2022/08/14")]
        [InlineData("2022/08/10", "2022/08/11")]
        [InlineData("2022/07/01", "2022/07/02")]
        public void CalculateDays_WithSucess_MultipleResultCorrect(DateTime dateUniversity, DateTime dateToday)
        {
            var result = Calculate.CalculateDays(dateUniversity, dateToday);

            Assert.Equal("1", result);
        }

        [Fact]
        public static void CalculateDays_WithSucess_ResultIncorrect()
        {
            DateTime dateUniversity = new DateTime(2022, 03, 29);
            DateTime dateToday = new DateTime(2022, 08, 14);
            string daysExpect = "139";

            var result = Calculate.CalculateDays(dateUniversity, dateToday);

            Assert.NotEqual(daysExpect, result);
        }

        [Fact]
        public static void CalculateDays_WithSucess_ResultNotIsNull()
        {
            DateTime dateUniversity = new DateTime(2022, 03, 29);
            DateTime dateToday = new DateTime(2022, 08, 14);

            var result = Calculate.CalculateDays(dateUniversity, dateToday);

            Assert.NotNull(result);
        }

        [Fact]
        public static void CalculateDays_WithSucess_ResultNotIsEmpty()
        {
            DateTime dateUniversity = new DateTime(2022, 03, 29);
            DateTime dateToday = new DateTime(2022, 08, 14);

            var result = Calculate.CalculateDays(dateUniversity, dateToday);

            Assert.NotEmpty(result);
        }
    }
}