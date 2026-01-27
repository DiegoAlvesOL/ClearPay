using ClearPay.Application.DTO;

namespace ClearPay.Tests.Application.DTO;

public class CreateMerchantDtoTests
{
    [Fact]
    public void Should_Maintain_Data_In_Request_Dto()
    {
        //1. Passando os dados de entrada
        string legalName = "Diego Alves de Oliveira Ltd";
        string tradingName = "Diego Alves Tech";
        string registrationNumber = "1234567A";
        string email = "diego@diegotech.ie";
        string city = "Dublin";
        
        //2. Populando o DTO, como se fosse a entrada de uma API
        CreateMerchantRequest request = new CreateMerchantRequest();
        request.LegalName = legalName;
        request.TradingName = tradingName;
        request.RegistrationNumber = registrationNumber;
        
        //Criando e populando o objeto de contato aninhado.
        request.Contact = new ContactDto();
        request.Contact.ContactName = "Diego Alves";
        request.Contact.Email = email;
        
        //Criando e populando o objeto de endereço.
        request.Address = new AddressDto();
        request.Address.City = city;
        request.Address.CountryCode = "IE";
        
        //3. Assert - Validando se o DTO está funcionando.
        Assert.Equal(legalName, request.LegalName);
        Assert.Equal(registrationNumber, request.RegistrationNumber);
        
        //Validando as estruturas aninhadas.
        Assert.NotNull(request.Contact);
        Assert.Equal(email, request.Contact.Email);
        
        Assert.NotNull(request.Address);
        Assert.Equal(city, request.Address.City);

    }
}