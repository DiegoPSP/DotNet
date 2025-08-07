using ExemploExplorando.Models;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Models;
using Newtonsoft.Json;

// int numero = 10;
// bool par = false;

// //IF Ternário
// par = numero.EhPar();

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");

// Console.WriteLine(mensagem);











// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(22);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("22 também mas como string");

// Console.WriteLine(arrayString[0]);

















// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");








// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }












// var tipoAnonimo = new { Nome = "Diego", Sobrenome = "Pereira", Idade = 22, Altura = 1.94 };

// Console.WriteLine($"Nome: " + tipoAnonimo.Nome);
// Console.WriteLine($"Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine($"Idade: " + tipoAnonimo.Idade);
// Console.WriteLine($"Altura: " + tipoAnonimo.Altura);








// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.id}, Produto: {venda.Produto}, " +
//                     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, " +
//                     $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }













// bool? desejaReceberEmail = null;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }












// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 220.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);










// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par!");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar!");
// }













// Pessoa p1 = new Pessoa("Diego", "Pereira");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");











// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// //Quando um parâmetro da tupla não é utilizado, basta colocar "_" em sua posição para descartar essa informação;
// //var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }














// (int Id, string Nome, string Sobrenome, decimal Altura) = (1, "Diego", "Pereira", 1.94M);

// //ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Diego", "Pereira", 1.94M);
// //var outroExemploTuplaCreate = Tuple.Create(1, "Diego", "Pereira", 1.94M);

// Console.WriteLine($"Id: {Id}");
// Console.WriteLine($"Nome: {Nome}"); 
// Console.WriteLine($"Sobrenome: {Sobrenome}");
// Console.WriteLine($"Altura: {Altura}");




















// // O primeiro elemento é chave e o segundo é o valor;
Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");
// estados.Add("RJ", "Rio de Janeiro");

// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} -> Valor: {item.Value}");
// }

// Console.WriteLine(new string('-', 40));
// estados.Remove("BA");
// estados["RJ"] = "Rio de Janeiro - Valor Alterado";

// //Console.Write("");
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} -> Valor: {item.Value}");
// }


string chave = "MG";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"O valor existe: {chave}");
}
else
{
    Console.WriteLine($"O valor não exite. É seguro adicionar a chave: {chave}");
}









// Stack<int> pilha = new Stack<int>();

// pilha.Push(0);
// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o topo da Pilha: {pilha.Pop()}");

// pilha.Push(45);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }














// Queue<int> fila = new Queue<int>();

// fila.Enqueue(3);
// fila.Enqueue(5);
// fila.Enqueue(7);
// fila.Enqueue(9);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); 

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }











// new ExemploExcecao().Metodo1();










// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo.Diretório não encontrado. {ex.Message}");
// }catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }finally 
// {
//     Console.WriteLine("Chegou até aqui!");
// }








// string dataString = "2024-12-12 04:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                             "yyyy-MM-dd HH:mm", 
//                             CultureInfo.InvariantCulture, 
//                             DateTimeStyles.None, out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }









//Validação da data, se a data não for válida o Parse retorna um Excessão;
// DateTime data = DateTime.Parse("40/11/2024 21:00");

// Console.WriteLine(data);







// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());









//Altera a Cultura do sistema para a que for passada nos parâmetros;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 2482.40M;
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// //Console.WriteLine(valorMonetario.ToString("C8"));

// double porcentagem = .3567;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 6213;
// Console.WriteLine(numero.ToString("##-##-##"));







// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);







// Pessoa p1 = new Pessoa(nome: "Diego", sobrenome: "Pereira");
// Pessoa p2 = new Pessoa(nome: "Sergio", sobrenome: "Neris");

// Curso cursoDeIngles = new Curso("Inglês");
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarALuno(p1);
// cursoDeIngles.AdicionarALuno(p2);
// cursoDeIngles.ListarALunos();






// p1.Apresentar();
// Pessoa p1 = new Pessoa();
// p1.Nome = "Diego";
// p1.Idade = -22;
// p1.Sobrenome = "Pereira";

// p1.Apresentar();

