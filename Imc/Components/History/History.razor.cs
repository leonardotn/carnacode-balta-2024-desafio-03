namespace Imc.Components.History;

public partial class History {
    private List<Models.Historico> historicos = new();

    protected async override Task OnInitializedAsync()
    {
        await RetornaHistoricos();
    }

    private async Task RetornaHistoricos()
    {
        historicos = await LocalStorageService.GetItemAsync<List<Models.Historico>>("historicos") ?? [];
    }

    private static string RetornaDataFormatada(DateTime dataInclusao)
    {
        int comparacaoDatas = DateTime.Compare(dataInclusao, DateTime.Now);

        return comparacaoDatas > 0 ? dataInclusao.ToString("dd/MM/yyyy") : FormataHora(dataInclusao);
    }

    private static string FormataHora(DateTime dataInclusao)
    {
        var diferencaoHoras = (DateTime.Now - dataInclusao);
        return diferencaoHoras.TotalMinutes > 59 ? $"{diferencaoHoras.Hours} horas atrás" : $"{diferencaoHoras.Minutes} minutos atrás";
    }
}