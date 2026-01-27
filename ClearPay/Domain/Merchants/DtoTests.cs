namespace ClearPay.Domain.Merchants;
using ClearPay.Application.DTO;

public class DtoTests
{
    public void RunDtoSimulationTest()
    {
        CreateMerchantRequest request = new CreateMerchantRequest();
        request.LegalName = "Diego Tech Ltd";
        request.RegistrationNumber = "99988877";
            
        // Preenchendo a parte interna de contato
        request.Contact = new ContactDto();
        request.Contact.ContactName = "Diego Oliveira";
        request.Contact.Email = "diego@test.com";

        // Preenchendo a parte interna de endereço
        request.Address = new AddressDto();
        request.Address.City = "Dublin";
        request.Address.CountryCode = "IE";


        Console.WriteLine("== SIMULATION: RECEIVING API DTO ==");
        Console.WriteLine("Merchant Name: " + request.LegalName);
        Console.WriteLine("Contact Person: " + request.Contact.ContactName);
        Console.WriteLine("City: " + request.Address.City);
        Console.WriteLine("===================================");

        if (request.Contact != null & request.Address != null)
        {
            Console.WriteLine("RESULT: DTO structure is correct!");
        }
        
    }
}