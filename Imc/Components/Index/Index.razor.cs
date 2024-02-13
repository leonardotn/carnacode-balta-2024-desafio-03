using Imc.Models;

namespace Imc.Components.Index;
public partial class Index {
    private CalculoImc calculo = new();
    private async Task CalcularImc() {
        double imc = Double.Parse(calculo.Peso) / (Double.Parse(calculo.Altura) * Double.Parse(calculo.Altura));
        bool resultado = imc < 24.9;
        NavigationManager.NavigateTo($"/result/{resultado}");
    }
}