using ClearPay.Application.UseCases;
using ClearPay.Domain.Merchants;

var builder = WebApplication.CreateBuilder(args);

//1. Registrando o Controller para que a API funcione
builder.Services.AddControllers();

//2. Registra o caso de uso (Injeção de denpendência)
builder.Services.AddScoped<CreateMerchantUseCase>();

//3. Registra uma implementação temporária do Repositório (Fake)
builder.Services.AddSingleton<IMerchantRepository, FakeRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
public class FakeRepository : IMerchantRepository 
{ 
    public void Add(Merchant merchant) { /* Não faz nada por enquanto */ } 
}