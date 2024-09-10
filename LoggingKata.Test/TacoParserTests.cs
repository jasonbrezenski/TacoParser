using System;
using System.Runtime.InteropServices;
using NuGet.Frameworks;
using Xunit;

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
        [InlineData("34.035985, -84.683302, Taco Bell Acworth...", -84.683302)]
        [InlineData("32.571331, -85.499655, Taco Bell Auburn...",-85.499655)]
        [InlineData("33.524131, -86.724876, Taco Bell Birmingham...", -86.724876)]
        [InlineData("33.168176, -87.521815, Taco Bell Tuscaloosa...", -87.521815)]
        [InlineData("30.478469, -87.206052, Taco Bell Pensacola...", -87.206052)]
        //DONE-TODO-Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // DONE-TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //DONE-TODO: Create a test called ShouldParseLatitude
        
        [Theory]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", 34.047374)]
        [InlineData("34.795116, -86.97191, Taco Bell Athens...", 34.795116)]
        [InlineData("30.654113, -87.912144, Taco Bell Daphn...", 30.654113)]
        [InlineData("34.741158, -86.662532, Taco Bell Huntsville...", 34.741158)]
        [InlineData("32.364153, -86.269979, Taco Bell Montgomery...", 32.364153)]
        [InlineData("30.192338, -85.83407, Taco Bell Panama City Beach...", 30.192338)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();
            
            //Act
            var actual = tacoParser.Parse(line);
            
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
