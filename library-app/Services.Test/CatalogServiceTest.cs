using BusinessLayer.Catalog;
using DataAccessLayer.Data;
using Services.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
        
        
    }
}