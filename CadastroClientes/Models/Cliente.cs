using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Models;

public class Cliente
{
    public int Id {get; set;}

[Required] // Campo Obrigatorio
[StringLength(100)]//Tamanho maximo do texto em caracter
    public string Nome {get; set;} = string.Empty;
[StringLength(14)]
    public string? CPF {get; set;} // ? = ACEITA NAO SER PREENCHIDO
    [Phone]//identifica campo tel
    [StringLength(20)]
    public string? Telefone {get; set;}
    [StringLength(100)]
    public string? Cidade {get; set;} 
    [StringLength(200)]

    public string? Endereco {get; set;}
[EmailAddress] // Identifica campo email
[StringLength(150)] // tamanho maximo com 150 caracteres
    public string? Email {get; set;}
    [StringLength(2)]
    public string? UF {get; set;}
    [DataType(DataType.Date)]
    [Display(Name =  "Data De Nascimento")]
    public DateTime DataNascimento {get; set;}
    public bool Ativo {get; set;} = true;




}