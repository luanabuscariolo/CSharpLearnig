public class Servico
{
    public string Nome {get; set;}
    public Servico(){
    
        Nome = "Pendente";
    }
    public Servico(string nome){
        if(nome == null)
        {
            throw new Exception("Nome não pode ser null");
        }
        Nome = nome;
    }
   
}

// var s1 = new Servico()
//s1.Nome é null quando construtor é implicito ou quando é implicito mas não define valor
//s1.Nome é "Pendente" quando o contrutor explicito define um valor "Pendente" para Nome



//var s2 = Servico("Bomboeiro");
//s2.Nome é "Bombeiro"

//var s3 = Servico(null); Dá erro prq o metodo construtor Servico(string nome) diz que é obrigatorio informar o nome.
01
