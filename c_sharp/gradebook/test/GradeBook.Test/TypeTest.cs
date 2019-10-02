using System;
using Xunit;

namespace GradeBook.Test
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTest
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod(){
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string ReturnMessage(string message){
            count++;
            return message;
        }
        string IncrementCount(string message){
            count++;
            return message.ToLower();
        }

        [Fact]
        public void StringsBehaveLikeValueTypes(){
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string paramater){
            return paramater.ToUpper();
        }

        [Fact]
        public void ChangeXbyOut(){
            var x = GetInt();
            SetInt(out x);

            Assert.Equal(42, x);
        }

        private void SetInt(out int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPasssByRef(){
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name"); 

            // act
            
            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        
        [Fact]
        public void CSharpPasssByValue(){
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name"); 

            // act
            
            // assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        
        [Fact]
        public void CanSetNameFromReference(){
            // arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name"); 

            // act
            
            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects(){
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act
            
            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        
        [Fact]
        public void TwoVarsCanReferenceSameObject(){
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act
            
            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
        Book GetBook(string name){
            return new Book(name);
        }
    }
}
