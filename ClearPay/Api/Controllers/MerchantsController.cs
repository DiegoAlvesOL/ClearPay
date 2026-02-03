using ClearPay.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using ClearPay.Application.DTO;
using ClearPay.Application.UseCases;
using ClearPay.Domain.Merchants;
namespace ClearPay.Api.Controllers;


/// <summary>
/// PROPÓSITO: Este arquivo é a "porta de entrada" da nossa aplicação para o mundo externo (Web).
/// Ele escuta as requisições HTTP, recebe os dados em formato JSON e os repassa para o UseCases.
/// </summary>
[ApiController]
[Route("api/merchants")]
public class MerchantsController : ControllerBase
{
    private readonly CreateMerchantUseCase _createMerchantUseCase;

    /// <summary>
    /// Na iInjeção de dependência, o Controller não cria o UserCase com "new". Ele pede para o sistema entregar um pronto.
    /// esté é apenas a porta de entrada para que sistema parceiros envie os dados de seus clientes
    /// </summary>
    /// <param name="createMerchantUseCase">O "gerente" que sabe como criar um merchant.</param>
    public MerchantsController(CreateMerchantUseCase createMerchantUseCase)
    {
        _createMerchantUseCase = createMerchantUseCase;
    }

    
    /// <summary>
    /// Ação de responder a requisição HTTP POST. 
    /// </summary>
    /// <param name="request">O JSON que o cliente enviou é transformado automaticamente neste objeto DTO.</param>
    /// <returns>Retorna um Status Code 201 (Created), que é a resposta padrão de sucesso para criações,
    /// junto com um objeto anônimo contendo apenas o que o contrato da API exige.</returns>
    [HttpPost]
    public IActionResult Create([FromBody] CreateMerchantRequest request)
    {
        //1.  Aqui é chamado o "Handle" do UseCases, passando o formulário (resquest)
        // neste ponto o controle sai da API e entra na camada de Aplicação/Negócio.
        Merchant merchant = _createMerchantUseCase.Handle(request);


        //2. Monta a resposta de sucesso conforme a documentação do projeto
        return CreatedAtAction(nameof(Create), new
        {
            merchantId = merchant.MerchantId,
            status = merchant.Status.ToString(),
            createdAt = DateTime.UtcNow
        });
    }
}