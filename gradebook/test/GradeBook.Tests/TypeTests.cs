using System;
using Xunit;


namespace GradeBook.Tests
{
      public class TypeTests
    {
        
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void IntergerTests()
        {
            var x = GetInt();
            Assert.Equal(3, x);
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");
            Assert.Equal("Book1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book1");
            GetBookSetNameReference(ref book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameReference(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwoVariablesReferenceSameObject()
        {
            var book1 = GetBook("Book1");
            var book2 = book1;
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

    }
}
