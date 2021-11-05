using System;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaFisica novaPf = new PessoaFisica();
            Endereco end = new Endereco();

            end.logradouro = "Ayrton Senna";
            end.numero = 100;
            end.complemento = "";
            end.enderecoComercial = false;

            novaPf.endereco = end;
            novaPf.cpf = "123456789";
            novaPf.nome = "Pessoa Fisica";
            novaPf.dataNascimento = new DateTime(2000, 06, 15);

            Console.WriteLine($@"Rua: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");
            
            bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);

            if (idadeValida == true) {

                Console.WriteLine($"Cadastro aprovado!");
                
            } else {
                Console.WriteLine($"Cadastro não aprovado!");
                
            }
        }
    }
}
