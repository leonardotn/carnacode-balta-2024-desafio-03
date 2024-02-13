using Imc.Enums;
namespace Imc.Models;

public class Historico
{
    public StatusPeso StatusPeso { get; set; }
    public DateTime DataInclusao { get; set; } 
    public string Descricao { get; set; }

    public Historico()
    {
        
    }
    public Historico(bool ehPesoIdeal)
    {
        StatusPeso = ehPesoIdeal ? StatusPeso.PesoIdeal : StatusPeso.SobrePeso;
        DataInclusao = DateTime.Now;
        Descricao = PreencheDescricao();
    }

    private string PreencheDescricao() {
        return StatusPeso == StatusPeso.PesoIdeal ?
            "Parabéns, você está no seu peso ideal, continue mantendo este estilo!" :
            "Estamos quase lá! Faça alguns ajustes para ficar no peso ideal!";

    }
}