using ExemploExplorando.Models;



// //pra pessoa reconhecer os parametros do outro arquivo
// Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Camilo");
// // p1.Nome = "Lucas";
// // p1.Sobrenome = "Camilo"; 

// Pessoa p2 = new Pessoa(nome: "Carolina", sobrenome: "Camilo");
// // p2.Nome = "Carolina";
// // p2.Sobrenome = "Camilo";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 75.50M;

// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));


// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .4321;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// DateTime data = DateTime.Now;
// //Console.WriteLine(data);

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// DateTime data2 = DateTime.Parse("07/05/1998 15:00");
// Console.WriteLine(data2);


// try {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } catch (Exception ex)
// {
//     Console.WriteLine("Erro ao ler arquivo: " + ex.Message);
// } finally
// {
//     Console.WriteLine("Fim do programa");
// }

new ExemploExcecao().Metodo1();