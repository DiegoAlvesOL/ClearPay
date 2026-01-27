namespace ClearPay.Application.DTO;

public class AddressDto
{
    public string AddressLine1 { get; set; }
    
    public string City { get; set; }
    
    public string State { get; set; }
    
    public string PostalCode { get; set; }
    
    // o CountryCode deve ser no formato ISO 3166-1 (ex. IE, GB ou FR). 
    public string CountryCode { get; set; }
} 