using System;
using Xunit;
using Xunit.Sdk;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.944183,-85.22637,Taco Bell Fort Oglethorp...", -85.22637)]
        [InlineData("33.24722,-84.273798,Taco Bell Griffi...", -84.273798)]
        
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
           
            var tacoParser = new TacoParser();
            //Arrange
            var actual = tacoParser.Parse(line).Location.Longitude;
            //Act
           Assert.Equal(expected, actual);
            //Assert
            
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("30.448367,-86.638431,Taco Bell Fort Walton Beach...", 30.448367)]
        [InlineData("33.24722,-84.273798,Taco Bell Griffi...", 33.24722)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var tacoParse = new TacoParser();

            var actual = tacoParse.Parse(line).Location.Latitude;

            Assert.Equal(expected, actual);
        }
    }
}
