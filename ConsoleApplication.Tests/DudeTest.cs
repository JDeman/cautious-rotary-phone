using System;
using Xunit;
using ConsoleApplication;

namespace ConsoleApplication.Tests
{
    public class DudeTest
    {
        ///////////////////////
        // WeightCheckEnhanced
        ///////////////////////
        
        [Fact]
        public void Huge_People_Should_Stop_Eating()
        {
            var dude2 = new Dude();
            dude2.Weight = 131;
            
            Assert.Equal(" is bigger than Mobby Dick." , dude2.WeightCheckEnhanced());
        }
        
        [Fact]
        public void Overweight_People_Should_Diet()
        {
            var dude3 = new Dude();
            dude3.Weight = 105;
            
            Assert.Equal(" needs to drop some pounds." , dude3.WeightCheckEnhanced());
        }
        
        [Fact]
        public void Ealthy_People_Are_Fine()
        {
            var dude4 = new Dude();
            dude4.Weight = 79;
            
            Assert.Equal(" is in good shape." , dude4.WeightCheckEnhanced());
        }
        
        [Fact]
        public void Skinny_People_Should_Eat()
        {
            var dude1 = new Dude();
            dude1.Weight = 51;
            
            Assert.Equal(" get your ass to KFC right now!", dude1.WeightCheckEnhanced());
        }
        
    }
}