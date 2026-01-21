namespace ClearPay.Domain.Merchants;

public class MerchantTests
{
    public void RunCreateMerchantTest()
    {
        Merchant merchant = new Merchant(
            "Diego Alves de Oliveira Ltd",
            "Diego Tech",
            "1234567A",
            LegalEntityType.Company,
            "IE",
            "EUR",
            OnboardingType.Partner,
            "partner-001"
        );
        
        Console.WriteLine("=== VALIDATION: MERCHANT DOMAIN ENTITY ===");
        Console.WriteLine("Generator ID: " + merchant.MerchantId);
        Console.WriteLine("Legal Entity type: " + merchant.LegalEntityType);
        Console.WriteLine("Onboarding Type: " + merchant.OnboardingType);
        Console.WriteLine(" Status: " + merchant.Status);
    }
}