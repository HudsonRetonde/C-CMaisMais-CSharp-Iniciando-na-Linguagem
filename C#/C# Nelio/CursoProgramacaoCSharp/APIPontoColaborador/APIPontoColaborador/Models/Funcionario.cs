using System.Collections.ObjectModel;

namespace APIPontoColaborador.Models;

public class Funcionarios
{
    public Funcionarios() 
    {
        Liderancas = new Collection<Liderancas>();
        Equipes = new Collection<Equipes>();
        Ponto = new Collection<Ponto>();
    }
    
    public int FuncionarioId { get; set; }
    public string NomeDoFuncionario { get; set; }
    public string Cpf { get; set; }
    public DateTime NascimentoFuncionario { get; set; }
    public DateTime DataDeAdmissao { get; set; }
    public string CelularFuncionario { get; set; }
    public string EmailFuncionario { get; set; }
    public int CargoId { get; set; }
    public Cargos Cargos { get; set; }

    public ICollection<Liderancas> Liderancas { get; set; }
    public ICollection<Equipes> Equipes { get; set; }
    public ICollection<Ponto> Ponto { get; set; }

}
