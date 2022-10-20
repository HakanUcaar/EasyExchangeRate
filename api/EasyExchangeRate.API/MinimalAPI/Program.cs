using EasyExchangeRate;
using EasyExchangeRate.Localization.NumberToWord;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder =>
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddSwaggerGen(gen =>
{
    gen.SwaggerDoc("v1", new OpenApiInfo { Title = "EasyExchangeRate", Version = "v1" });
    gen.ParameterFilter<AdapterParameterFilter>();
    gen.ParameterFilter<LanguageParameterFilter>();
});


var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT");
app.Urls.Add("http://*:" + port);

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");


app.MapGet("/currencies", (AdapterList adapter) =>
{
    switch (adapter)
    {
        case AdapterList.EuropeAdapter:
            return ExchangeRate.EuropeAdapter.Currencies;
        case AdapterList.TurkeyAdapter:
            return ExchangeRate.TurkeyAdapter.Currencies;
        case AdapterList.DenmarkAdapter:
            return ExchangeRate.DenmarkAdapter.Currencies;
        case AdapterList.IsraelAdapter:
            return ExchangeRate.IsraelAdapter.Currencies;
        case AdapterList.RussiaAdapter:
            return ExchangeRate.RussiaAdapter.Currencies;
        case AdapterList.AustraliaAdapter:
            return ExchangeRate.AustraliaAdapter.Currencies;
        case AdapterList.PolandAdapter:
            return ExchangeRate.PolandAdapter.Currencies;
        case AdapterList.CanadaAdapter:
            return ExchangeRate.CanadaAdapter.Currencies;
        default:
            break;
    }
    return null;
})
.WithName("GetCurrencies")
.WithMetadata(new SwaggerOperationAttribute("Get all available currencies", "Get all available currencies"));

app.MapGet("/getRates", (AdapterList adapter) =>
{
    switch (adapter)
    {
        case AdapterList.EuropeAdapter:
            return ExchangeRate.EuropeAdapter.GetRates();
        case AdapterList.TurkeyAdapter:
            return ExchangeRate.TurkeyAdapter.GetRates();
        case AdapterList.DenmarkAdapter:
            return ExchangeRate.DenmarkAdapter.GetRates();
        case AdapterList.IsraelAdapter:
            return ExchangeRate.IsraelAdapter.GetRates();
        case AdapterList.RussiaAdapter:
            return ExchangeRate.RussiaAdapter.GetRates();
        case AdapterList.AustraliaAdapter:
            return ExchangeRate.AustraliaAdapter.GetRates();
        case AdapterList.PolandAdapter:
            return ExchangeRate.PolandAdapter.GetRates();
        case AdapterList.CanadaAdapter:
            return ExchangeRate.CanadaAdapter.GetRates();
        default:
            break;
    }
    return null;
})
.WithName("GetRates")
.WithMetadata(new SwaggerOperationAttribute("Get all available rates", "Get all available rates"));

app.MapGet("/numberToWord", (LanguageList language, long value) =>
{
    switch (language)
    {
        case LanguageList.English:
            return EnglishNumberToWordsConverter.New().Convert(value);
        case LanguageList.Turkish:
            return TurkishNumberToWordConverter.New().Convert(value);
        default:
            break;
    }
    return null;
})
.WithName("numberToWord")
.WithMetadata(new SwaggerOperationAttribute("Number to word convert", "Number to word convert"));

app.Run();

enum AdapterList
{
    EuropeAdapter = 0,
    TurkeyAdapter = 1,
    DenmarkAdapter = 2,
    IsraelAdapter = 3,
    RussiaAdapter = 4,
    AustraliaAdapter = 5,
    PolandAdapter = 6,
    CanadaAdapter = 7
};

enum LanguageList
{
    English = 0,
    Turkish = 1,
};

public class AdapterParameterFilter : IParameterFilter
{
    readonly IServiceScopeFactory _serviceScopeFactory;

    public AdapterParameterFilter(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
    {
        if (parameter.Name.Equals("adapter", StringComparison.InvariantCultureIgnoreCase))
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                parameter.Schema.Enum = Enum.GetNames(typeof(AdapterList)).Select(p => new OpenApiString(p)).ToList<IOpenApiAny>();
            }
        }
    }
}

public class LanguageParameterFilter : IParameterFilter
{
    readonly IServiceScopeFactory _serviceScopeFactory;

    public LanguageParameterFilter(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
    {
        if (parameter.Name.Equals("language", StringComparison.InvariantCultureIgnoreCase))
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                parameter.Schema.Enum = Enum.GetNames(typeof(LanguageList)).Select(p => new OpenApiString(p)).ToList<IOpenApiAny>();
            }
        }
    }
}



