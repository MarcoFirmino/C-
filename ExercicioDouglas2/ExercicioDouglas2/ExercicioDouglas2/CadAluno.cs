

namespace ExercicioDouglas2
{
    class CadAluno
    {
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Numero { get; set; }
            public string Cep { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Tel { get; set; }
            public string Curso { get; set; }
            public string Turma { get; set; }

        public CadAluno()
        {
            
        }

        public CadAluno(string nome, string endereco, string numero, string cep, 
                        string bairro, string cidade, string estado, string tel, 
                        string curso, string turma)
        {
            Nome = nome;
            Endereco = endereco;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Tel = tel;
            Curso = curso;
            Turma = turma;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
