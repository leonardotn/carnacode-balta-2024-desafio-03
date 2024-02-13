using Blazored.LocalStorage;
using Imc.Models;

namespace Imc.Components.Index;
public partial class Index {
    private CalculoImc calculo = new();
    private async Task CalcularImc() {
        double imc = Double.Parse(calculo.Peso) / (Double.Parse(calculo.Altura) * Double.Parse(calculo.Altura));
        bool ehPesoIdeal = imc < 24.9;
        IncluiNovoHistorico(ehPesoIdeal);
        NavigationManager.NavigateTo($"/result/{ehPesoIdeal}");
    }

    private async Task IncluiNovoHistorico(bool ehPesoIdeal)
    {
        var historicos = await LocalStorageService.GetItemAsync<List<Models.Historico>>("historicos") ?? [];
        historicos.Add(new Historico(ehPesoIdeal));
        await LocalStorageService.SetItemAsync<List<Models.Historico>>("historicos", historicos);
    }
}