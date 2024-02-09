using BusinessLayer.Catalog;
using DataAccessLayer.Data;
using Services.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessObjects.Entity;

namespace Services.Test
{
    [TestClass]
    public class CatalogServiceTest
    {
        [TestMethod]
        public async Task ShowCatalog_Should_Call_DisplayCatalog()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for DisplayCatalog method
            Mock.Get(catalogManagerMock).Setup(cm => cm.DisplayCatalog()).Returns(Task.CompletedTask);

            // Act
            await catalogService.ShowCatalog();

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.DisplayCatalog(), Times.Once);
        }


        [TestMethod]
        public async Task FindBook_Should_Call_FindBook()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for FindBook method
            Mock.Get(catalogManagerMock).Setup(cm => cm.FindBook(It.IsAny<int>())).Returns(Task.FromResult(new Book()));

            // Act
            await catalogService.FindBook(1);

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.FindBook(It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public async Task GetFantasyBooks_Should_Call_GetFantasyBooks()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for GetFantasyBooks method
            Moq.Language.Flow.IReturnsResult<ICatalogManager> returnsResult = Mock.Get(catalogManagerMock)
                .Setup(cm => cm.GetFantasyBooks())
                .Returns(Task.FromResult<IEnumerable<Book>>(new List<Book>()));

            // Act
            await catalogService.GetFantasyBooks();

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.GetFantasyBooks(), Times.Once);
        }

        [TestMethod]
        public async Task GetBetterGradeBook_Should_Call_GetBetterGradeBook()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for GetBetterGradeBook method
            Mock.Get(catalogManagerMock).Setup(cm => cm.GetBetterGradeBook())
                .Returns(Task.FromResult(new Book()));

            // Act
            await catalogService.GetBetterGradeBook();

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.GetBetterGradeBook(), Times.Once);
        }

        [TestMethod]
        public async Task GetBooks_Should_Call_GetBooks()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for GetBooks method
            Mock.Get(catalogManagerMock).Setup(cm => cm.GetBooks())
                .Returns(Task.FromResult<IEnumerable<Book>>(new List<Book>()));

            // Act
            await catalogService.GetBooks();

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.GetBooks(), Times.Once);
        }

        [TestMethod]
        public async Task GetBooksByType_Should_Call_GetBooksByType()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for GetBooksByType method
            Mock.Get(catalogManagerMock).Setup(cm => cm.GetBooksByType(It.IsAny<string>()))
                .Returns(Task.FromResult<IEnumerable<Book>>(new List<Book>()));

            // Act
            await catalogService.GetBooksByType("Fantasy");

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.GetBooksByType(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public async Task UpdateBook_Should_Call_UpdateBook()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for UpdateBook method
            Mock.Get(catalogManagerMock).Setup(cm => cm.UpdateBook(It.IsAny<Book>()))
                .Returns(Task.FromResult(true));

            // Act
            await catalogService.UpdateBook(new Book());

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.UpdateBook(It.IsAny<Book>()), Times.Once);
        }

        [TestMethod]
        public async Task DeleteBook_Should_Call_DeleteBook()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for DeleteBook method
            Mock.Get(catalogManagerMock).Setup(cm => cm.DeleteBook(It.IsAny<int>()))
                .Returns(Task.FromResult(true));

            // Act
            await catalogService.DeleteBook(1);

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.DeleteBook(It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public async Task AddBook_Should_Call_AddBook()
        {
            var catalogManagerMock = Mock.Of<ICatalogManager>();
            var catalogService = new CatalogService(catalogManagerMock);

            // Set up the behavior for AddBook method
            Mock.Get(catalogManagerMock).Setup(cm => cm.AddBook(It.IsAny<Book>()))
                .Returns(Task.FromResult(true));

            // Act
            await catalogService.AddBook(new Book());

            // Assert
            Mock.Get(catalogManagerMock).Verify(cm => cm.AddBook(It.IsAny<Book>()), Times.Once);
        }
    }
}