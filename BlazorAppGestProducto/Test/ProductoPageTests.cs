using BlazorAppGestProducto.Components.Pages;
using BlazorAppGestProducto.Models;
using BlazorAppGestProducto.Servicios;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class ProductoPageTests : TestContext
{
    // Mock del servicio IProductoService
    private readonly Mock<IProductoService> _productoServiceMock;

    public ProductoPageTests()
    {
        _productoServiceMock = new Mock<IProductoService>();

        // Configurar el servicio para devolver una lista de productos vacía
        _productoServiceMock.Setup(service => service.GetProductos())
            .ReturnsAsync(new List<Producto>());

        // Registrar el servicio simulado en el contexto de pruebas
        Services.AddSingleton(_productoServiceMock.Object);
    }

    [Fact]
    public void ValidacionCamposVacios_NoSeEnvianDatos()
    {
        // Act: Renderizar el componente ProductoPage
        var component = RenderComponent<Home>();

        // Act: Dejar los campos vacíos y hacer clic en el botón de agregar
        var submitButton = component.Find("button");
        submitButton.Click();

        // Assert: Verificar que no se llama al servicio para agregar el producto
        _productoServiceMock.Verify(service => service.AddProducto(It.IsAny<Producto>()), Times.Never);

        // Assert: Verificar que se muestran los mensajes de validación
        var validationMessages = component.FindAll("div.validation-message");

        // Depuración: Imprime los mensajes de validación para revisar qué mensajes se están mostrando
        foreach (var message in validationMessages)
        {
            Console.WriteLine(message.TextContent);
        }

        // Asegúrate de que haya tres mensajes de validación
        Assert.Equal(3, validationMessages.Count); // Asegúrate de que haya tres mensajes de error
    }




}
