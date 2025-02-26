using Business.Interfaces;
using MainApp.Dialogs;
using Moq;

namespace MainApp.Tests.Dialogs;

public class MenuDialog_Tests
{
	private readonly Mock<IProductService> _productServiceMock;
    private readonly MenuDialogs _menuDialogs;

	public MenuDialog_Tests()
	{
		_productServiceMock = new Mock<IProductService>();
		_menuDialogs = new MenuDialogs(_productServiceMock.Object);
	}

	[Fact]
	public void CreateMenu_ShouldCreateNewProduct()
	{
        // Arrange
        var input = new StringReader("1\nProduct 1\n99.99\n");
        Console.SetIn(input);

        // Act
        var result = _menuDialogs.CreateMenu();

		// Assert
		Assert.True(result);
	}
}
