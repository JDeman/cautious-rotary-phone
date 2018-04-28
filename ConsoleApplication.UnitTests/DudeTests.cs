using Xunit;

namespace ConsoleApplication.UnitTests
{
    
    public class DudeTests
    {
//        [Fact]
//        public void WeightCheck_Case_GoodShape()
//        {
//            var dude = new Dude{Name = "Jack", Age = 32, Gender = Genders.Man, Weight = 78};
//
//            var str = dude.WeightCheck();
//
//            Assert.Equal(str, "Jack is in good shape.");
//
//        }


        [Theory]
        [InlineData("Jim",0," get your ass to KFC right now!")]
        [InlineData("Bob",25," get your ass to KFC right now!")]
        [InlineData("Rita",59," get your ass to KFC right now!")]
        [InlineData("Mike",70," is in good shape.")]
        [InlineData("Joe",79," is in good shape.")]
        [InlineData("Travis",102," needs to drop some pounds.")]
        [InlineData("Jake",120," needs to drop some pounds.")]
        [InlineData("Rudolph",123," is bigger than Mobby Dick.")]
        [InlineData("Rudolph",345," is bigger than Mobby Dick.")]
        [InlineData("Rudolph",1230," is bigger than Mobby Dick.")]
        public void WeightCheck_Returns_Propper_Sentence(string name, int weight, string result)
        {
            var dude = new Dude{Name = name, Weight = weight};
            var str = dude.WeightCheck();
            Assert.Equal(str, name + result);
        }
    }
}