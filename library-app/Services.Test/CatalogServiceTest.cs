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
    }
}