namespace cadastroPessoa

{
    public class PessoaJurica : Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }

        public override void pagarImposto(float salario)
        {
            
        }
    }
}