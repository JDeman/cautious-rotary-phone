using Xunit;

namespace ConsoleApplication.UnitTests
{
    
    public class DudeTests
    {
        [Fact]
        public void WeightCheck_Case_GoodShape()
        {
            var dude = new Dude{Name = "Jack", Age = 32, Gender = Genders.Man, Weight = 78};

            var str = dude.WeightCheck();

            Assert.Equal(str, "Jack is in good shape.");

        }
        
        [Fact]
        public void WeightCheck_Case_HugeWeight()
        {
            var dude = new Dude{Name = "Paula", Age = 54, Gender = Genders.Trans, Weight = 154};

            var str = dude.WeightCheck();

            Assert.Equal(str, "Paula is bigger than Mobby Dick.");
        }
        
        [Fact]
        public void WeightCheck_Case_Overweight()
        {
            var dude = new Dude{Name = "Rita", Age = 72, Gender = Genders.Woman, Weight = 116};

            var str = dude.WeightCheck();

            Assert.Equal(str, "Rita needs to drop some pounds.");
        }
        
        [Fact]
        public void WeightCheck_Case_Skinny()
        {
            var dude = new Dude{Name = "Bob", Age = 72, Gender = Genders.Man, Weight = 61};

            var str = dude.WeightCheck();

            Assert.Equal(str, "Bob get your ass to KFC right now!");
        }
    }
}