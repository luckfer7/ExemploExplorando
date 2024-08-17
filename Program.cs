using ExemploExplorando.Models;


//pra pessoa reconhecer os parametros do outro arquivo
Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Camilo");
// p1.Nome = "Lucas";
// p1.Sobrenome = "Camilo"; 

Pessoa p2 = new Pessoa(nome: "Carolina", sobrenome: "Camilo");
// p2.Nome = "Carolina";
// p2.Sobrenome = "Camilo";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
