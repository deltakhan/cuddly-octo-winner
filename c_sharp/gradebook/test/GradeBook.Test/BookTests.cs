using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        //[Fact]
        public void CanNotAddBadGrades(){
            var book = new Book("Book1");

            book.AddGrade(-5);
            book.AddGrade(110);
            book.AddGrade(-5.5);
            book.AddGrade(100.5);
            book.AddGrade(0.5);
            book.AddGrade(88.67);

            var result = book.GetStatistics();

            Assert.Equal(2, result.Length);
        }

        [Fact]
        public void BookCalculatesAnAverageGrade(){
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
           Assert.Equal(85.6, result.Average, 1);
        }

        [Fact]
        public void BookCalculatesTheHighestGrade(){
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
           Assert.Equal(90.5, result.High, 1);
        }
        
        [Fact]
        public void BookCalculatesTheLowestGrade(){
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
           Assert.Equal(77.3, result.Low, 1);
        }

        [Fact]
        public void findLetterGrade(){
            //Given
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            //When
            var result = book.GetStatistics();
            //Then
            Assert.Equal('B', result.Letter);
        }
    }
}
