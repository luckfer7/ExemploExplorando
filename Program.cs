using ExemploExplorando.Models;
using Newtonsoft.Json;




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

//new ExemploExcecao().Metodo1();


// Queue<int> fila = new Queue<int>();

// fila.Enqueue(10);
// fila.Enqueue(29);
// fila.Enqueue(49);
// fila.Enqueue(37);

// foreach (int Item in fila) {
//     Console.WriteLine(Item);
// }
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(254);

// foreach (int Item in fila) {
//     Console.WriteLine(Item);
// }


// Stack<string> bagunça = new Stack<string>();

// bagunça.Push("cuecas");
// bagunça.Push("bermudas");
// bagunça.Push("meias");
// bagunça.Push("camisas");

// foreach (string roupa in bagunça) {
//     Console.WriteLine(roupa);
// }
// Console.WriteLine($"dobrando as {bagunça.Pop()}");

// foreach (string roupa in bagunça) {
//     Console.WriteLine(roupa);
// } 

// Dictionary<string, string> nomes = new Dictionary<string, string>();

// nomes.Add("LC", "Lucas Camilo");
// nomes.Add("AF", "Andressa Fernandes");
// nomes.Add("RV", "Renata Vasconcelos");

// foreach(var nome in nomes) {
//     Console.WriteLine($"Abreviação {nome.Key} é {nome.Value}");
// }

// Console.WriteLine("-------------------------");

// nomes.Remove("AF");
// nomes["RV"] = "Renata Vaz";

// foreach(var nome in nomes) {
//     Console.WriteLine($"Abreviação {nome.Key} é {nome.Value}");
// }

//TUPLAS

//primeira maneira
// (int, string, string) tupla = (1, "Lucas", "Camilo");
// Console.WriteLine($"id:{tupla.Item1}");
// Console.WriteLine($"Nome:{tupla.Item2}");
// Console.WriteLine($"Sobrenome:{tupla.Item3}");

// //segunda maneira
// ValueTuple<int, string, string> tuplaDois = (1, "Lucas", "Camilo");
// Console.WriteLine(tuplaDois);

// //terceira maneira
// var tuplaTres = Tuple.Create (1, "Lucas", "Camilo");
// Console.WriteLine(tuplaTres);


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasDoArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso) {
//     //Console.WriteLine("Quantidade de linhas do arquivo:" + QuantidadeDeLinhasDoArquivo);
//     foreach(string linha in linhasDoArquivo) {
//         Console.WriteLine(linha);
//     }
// } 
// else {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

//DESCONSTRUTOR

// Pessoa p1 = new Pessoa("Lucas", "Camilo");
// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


//TERNARIO

// int numero = 71;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

//SERIALIZAÇÃO 

// using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda (1, "Materia de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda (2, "hardware", 1000.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

// DESERIALIZAÇÃO

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"id:{venda.Id}, Produto: {venda.Produto}, " + $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
    
}