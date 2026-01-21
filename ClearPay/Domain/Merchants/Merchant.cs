using System.Runtime.Serialization;

namespace ClearPay.Domain.Merchants;

public class Merchant
{
    // Critério de Aceitação: merchantId gerado automaticamente.
    // O private set impede que o campo seja alterado após sua criação.
    public string MerchantId { get; private set; }
    public string LegalName { get; set; }
    public string TradingName { get; set; }
    public string RegistrationNumber { get; private set; }
    public LegalEntityType LegalEntityType { get; private set; }
    public string CountryCode { get; private set; }
    public string Currency { get; private set; }
    public OnboardingType OnboardingType { get; private set; }
    public string PartnerId { get; private set; }
    public MerchantStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
    
    // Construtor para garantir a criação de um objeto válido.
    public Merchant(
        string legalName,
        string tradingName,
        string registrationNumber,
        LegalEntityType legalEntityType,
        string countryCode,
        string currency,
        OnboardingType onboardingType,
        string partnerId)
    {
        // chamando a função que irá gerar o ID unico do merchant
        MerchantIdGenerator idGenerator = new MerchantIdGenerator();
        
        this.MerchantId = idGenerator.Generate();
        this.LegalName = legalName;
        this.TradingName = tradingName;
        this.RegistrationNumber = registrationNumber;
        this.LegalEntityType = legalEntityType;
        this.CountryCode = countryCode;
        this.Currency = currency;
        this.OnboardingType = onboardingType;
        this.PartnerId = partnerId;
        this.Status = MerchantStatus.Pending;
        this.CreatedAt = DateTime.UtcNow;
    }

}