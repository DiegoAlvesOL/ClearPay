namespace ClearPay.Application.DTO;

public class CreateMerchantRequest
{
    public string LegalName {  get; set; }
    
    public string TradingName { get; set; }
    
    public string RegistrationNumber { get; set; }

    public string LegalEntityType { get; set; }

    // o CountryCode deve ser no formato ISO 3166-1 (ex. IE, GB ou FR). 
    public string CountryCode { get; set; }
    
    public string Currency { get; set; }

    public string OnboardingType { get; set; }
    
    public string PartnerId { get; set; }
    
    public ContactDto Contact { get; set; }
    
    public AddressDto Address { get; set; }
    
    public FiscalDto Fiscal { get; set; }
    
    public FinancialDto Financial { get; set; }
    
    public BankAccountDto BankAccount { get; set; }
}
