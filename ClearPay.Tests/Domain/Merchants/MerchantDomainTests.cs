using ClearPay.Domain.Merchants;

namespace ClearPay.Tests.Domain.Merchants;

public class MerchantDomainTests
{
    public class MerchantDomaninTeste
    {
        [Fact]
        public void Should_Create_Merchant_Initial_State()
        {
            //1 . Passando os dados de entrada
            string LegalName = "Diego Alves de Oliveira Ltd";
            string TradingName = "Diego Tech";
            string RegistrationNumber = "1234567A";
            string CountryCode = "IE";
            string Currency = "EUR";
            string PartnerId = "partner-001";
            
            //2. Criando a entidade 
            Merchant merchant = new Merchant(
                LegalName,
                TradingName,
                RegistrationNumber,
                LegalEntityType.Company,
                CountryCode,
                Currency,
                OnboardingType.Partner,
                PartnerId
            );
            
            //3. Assert - Validações
            Assert.Equal(MerchantStatus.Pending, merchant.Status);
            Assert.NotNull(merchant.MerchantId);
            Assert.Contains("-", merchant.MerchantId);
            Assert.True(merchant.MerchantId.Length ==13);
        }
    }
}