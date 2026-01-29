using ClearPay.Application.DTO;
using ClearPay.Application.UseCases;
using ClearPay.Domain.Merchants;

namespace ClearPay.Tests.Application.UseCases;

public class FakeMerchantRepository : IMerchantRepository
{
    public void Add(Merchant merchant)
    {
        
    }
}

public class CreateMerchantUseCaseTests
{
    [Fact]
    public void Should_Process_Merchant_Successfully()
    {
        //1. Criando os dados para injetar no UseCase
        var repository = new FakeMerchantRepository();
        var useCase = new CreateMerchantUseCase(repository);
        var request = new CreateMerchantRequest
        {
            LegalName = "Diego Alves Tech Ltd",
            LegalEntityType = "Company",
            OnboardingType = "Direct"
        };
        
        //2. Enviando os dados para o metodo de criação do merchant
        var result = useCase.Handle(request);
        
        //3. Assert validando se o Merchant foi realmente criado.
        Assert.NotNull(result);
        Assert.Equal("Diego Alves Tech Ltd", result.LegalName);
        Assert.NotNull(result.MerchantId);
    }
}