using System;
using ClearPay.Application.DTO;
using ClearPay.Domain.Merchants;

namespace ClearPay.Application.UseCases;

/// <summary>
/// Coordena o fluxo de negócios para a criação de um novo comerciante.
/// </summary>
public class CreateMerchantUseCase
{
    private readonly IMerchantRepository _merchantRepository;

    /// <summary>
    /// /// Gerencia o processo de criação de merchant convertendo dados DTO em uma Entidade de Domínio.
    /// </summary>
    /// <param name="merchantRepository">A interface que define como salvar o Merchant</param>
    public CreateMerchantUseCase(IMerchantRepository merchantRepository)
    {
        _merchantRepository = merchantRepository;
    }

    /// <summary>
    /// Método principal que processa a criação.
    /// </summary>
    /// <param name="request">O formulário (DTO) vindo da API externa.</param>
    /// <returns>A entidade Merchant com ID gerado e status definido.</returns>
    public Merchant Handle(CreateMerchantRequest request)
    {

        LegalEntityType legalType = Enum.Parse<LegalEntityType>(request.LegalEntityType);
        OnboardingType onboardingType = Enum.Parse<OnboardingType>(request.OnboardingType);


        Merchant newMerchant = new Merchant(
            request.LegalName,
            request.TradingName,
            request.RegistrationNumber,
            legalType,
            request.CountryCode,
            request.Currency,
            onboardingType,
            request.PartnerId);

        _merchantRepository.Add(newMerchant);

        return newMerchant;
    }
}
