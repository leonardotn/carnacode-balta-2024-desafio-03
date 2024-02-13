namespace Imc.Components.Result;
﻿using Microsoft.AspNetCore.Components;
public partial class Result {
[Parameter]
public string Resultado { get; set; }
public bool ResultadoImc { get; set; }

public Result() {
    ResultadoImc = Resultado == "True" ? true : false;
}
    private void AvancarProximaPagina(string rota) => NavigationManager.NavigateTo(rota);
}