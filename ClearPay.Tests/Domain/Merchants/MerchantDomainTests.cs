using ClearPay.Application.DTO;
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

        [Fact]
        public void Should_Create_Merchant_Assigned_With_SoleTrader(){
            //1. Passando os dados de entrada
            var request = new CreateMerchantRequest();
            string expectedType = "SoleTrader";
            
            //2. passando a informação para o método.
            request.LegalEntityType = expectedType;
            
            //3. Assert validação
            Assert.Equal(expectedType, request.LegalEntityType);


        }
        [Fact]
        public void Should_Create_Merchant_Assigned_With_Company(){
            //1. Passando os dados de entrada
            var request = new CreateMerchantRequest();
            string expectedType = "Company";
            
            //2. passando a informação para o método.
            request.LegalEntityType = expectedType;
            
            //3. Assert validação
            Assert.Equal(expectedType, request.LegalEntityType);
            
        }
        [Fact]
        public void Should_Create_Merchant_Assigned_With_Individual(){
            //1. Passando os dados de entrada
            var request = new CreateMerchantRequest();
            string expectedType = "Individual";
            
            //2. passando a informação para o método.
            request.LegalEntityType = expectedType;
            
            //3. Assert validação
            Assert.Equal(expectedType, request.LegalEntityType);
            
        }
        

    }
}