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
        Console.WriteLine("Status: " + merchant.Status);
        Console.WriteLine( "==========================================\n");
        
        // Teste de Regra de Negócio (Critérios de Aceitação do Card)
        if (merchant.Status == MerchantStatus.Pending && !string.IsNullOrEmpty(merchant.MerchantId))
        {
            Console.WriteLine( "===================================================================");
            Console.WriteLine("RESULT: TEST PASSED");
            Console.WriteLine("Reason: Entity created correctly ad Pending with a valid ID format");
            Console.WriteLine( "===================================================================");
        }
        else
        {
            Console.WriteLine( "=================================================================");
            Console.WriteLine("RESULT: TEST FAILED");
            Console.WriteLine("Reason: Acceptance criteria not met");
            Console.WriteLine( "=================================================================");
        }
    }
}