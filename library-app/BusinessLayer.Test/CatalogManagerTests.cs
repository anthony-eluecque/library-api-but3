using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using Moq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace BusinessLayer.Test
{
    [TestClass]
    public class CatalogManagerTests
    {
        private Mock<IRepository<Book>> _catalogManagerMock;
        private readonly ICatalogManager _catalogManager;
        private readonly IEnumerable<Book> _book;

        public CatalogManagerTests()
        {
            _catalogManagerMock = new Mock<IRepository<Book>>();
            _catalogManager = new CatalogManager(_catalogManagerMock.Object);
            _book = CreateFakeData();
        }

        [TestMethod]
        public async Task DisplayCatalog_Should_Call_GetAll()
        {

            // on setup
            _catalogManagerMock.Setup(x => x.GetAll()).Returns(Task.FromResult<List<Book>>( _book.ToList()));

            // Act
            await _catalogManager.DisplayCatalog();

            // Assert
            _catalogManagerMock.VerifyAll();
        }


        [TestMethod]
        public async Task FindBook_Should_Call_GetAll()
        {
            _catalogManagerMock.Setup(x => x.GetAll()).Returns(Task.FromResult<List<Book>>(_book.ToList()));
            
            // Act
            Task<Book> task = _catalogManager.FindBook(1);

            // Assert
            _catalogManagerMock.Verify(x => x.Get(1), Times.Once);
        }

        [TestMethod]
        public async Task GetFantasyBooks_Should_Call_GetAll()
        {
            _catalogManagerMock.Setup(x => x.GetAll()).Returns(Task.FromResult<List<Book>>(_book.ToList()));

            // Act
            Task task = _catalogManager.GetFantasyBooks();

            // Assert
            Assert.AreEqual(2, _book.Count());
        }

        [TestMethod]
        public async Task GetBetterGradeBook_Should_Call_GetAll()
        {
            _catalogManagerMock.Setup(x => x.GetAll()).Returns(Task.FromResult<List<Book>>(_book.ToList()));

            // Act 
            Task task = _catalogManager.GetBetterGradeBook();
            
            // Assert
            Assert.AreEqual(5, _book.First().Rate);
        }

        private IEnumerable<Book> CreateFakeData()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Name = "Book 1", Pages = 100, Rate = 5, Type = BookTypes.FANTASY, Id_Author = 1 },
                new Book { Id = 1, Name = "Book 2", Pages = 100, Rate = 2, Type = BookTypes.FANTASY, Id_Author = 1 }
            };

            return books;
        }
    }
}