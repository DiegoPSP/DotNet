using ExemploFundamentos.Models.Calculadora;
using ExemploFundamentos.Models.Pessoa;

//  string opcao;
//  bool exibirMenu = true;

//  do{
//      Console.WriteLine("Digite a sua opção:");
//      Console.WriteLine("1 - Cadastrar cliente.");
//      Console.WriteLine("2 - Buscar cliente.");
//      Console.WriteLine("3 - Apagar cliente.");
//      Console.WriteLine("4 - Encerrar.");

//      opcao = Console.ReadLine();

//      switch(opcao)
//      {
//          case "1":
//              Console.WriteLine("\nCadastro de cliente.\n");
//              break;
//          case "2": 
//              Console.WriteLine("\nBusca de cliente.\n");
//              break;
//          case "3":
//              Console.WriteLine("\nApagar cliente.\n");
//              break;
//          case "4":
//              Console.WriteLine("\nEncerrar.\n");
//              exibirMenu = false;
//              //Environment.Exit(0); Encerra o programa;
//              break;
//          default:
//              Console.WriteLine("Opção Inválida!");
//              break;
//      }

//  }while(exibirMenu);
//  Console.Write("Programa encerrado!");






















// int soma = 0, numero;

// do 
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

















// int numero = 4;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }




















// int numero = 3;
// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }















// Calculadora calc = new Calculadora();

// calc.Somar(5, 6);
// calc.Subtrair(15, 20);
// calc.Dividir(18, 3);
// calc.Multiplicar(4, 6);
// calc.Potencia(3, 4);
// calc.Coseno(30);
// calc.Seno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine($"Incrementando o número {numeroIncremento}");

// numeroIncremento++;

// Console.WriteLine(numeroIncremento);
// int numeroDecremento = 1;

// Console.WriteLine(numeroDecremento);

// Console.WriteLine($"Decrementando o número {numeroDecremento}");

// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

















// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine($"Vou pedalar!");
// }
// else
// {
//     Console.WriteLine($"Vou pedalar um outro dia!");
// }




















// bool possuiPresencaMinima = false;
// double media = 7;

// if (possuiPresencaMinima && media >= 7)
// {//Operador lógico que precisa que todas as verificações sejam verdadeiras;
//     Console.WriteLine($"Aluno aprovado!");
// }
// else
// {
//     Console.WriteLine($"Aluno Reprovado!");
// }













// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//{//Operador lógico OU ao menos uma das verificações precisa ser verdadeira;
//     Console.WriteLine($"Entrada não liberada!");
// }
// else
//{
//     Console.WriteLine($"Entrada não liberada!");
// }











// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine() ?? string.Empty;

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"Vogal.");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }










// int quantidadeEmEstoque = 20;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}.");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}.");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}.\n");

// if(quantidadeCompra == 0){
//     Console.WriteLine($"Venda inválida!");
// }
// else if (possivelVenda){
//     Console.WriteLine($"Venda realizada!\n");
// }
// else{
//     Console.WriteLine($"Desculpe, mas não temos essa quantia em estoque!\n");
// }










// string a = "15-";

// int b = 0;

// bool v = int.TryParse(a, out int b);
// Cria uma bool se deu certo ou não a conversão, depois utilza a função TryParse que espera;
// um erro, mas continua a execução;

// Console.WriteLine(v);
// Console.WriteLine(b);
// Console.WriteLine($"Conversão realizada com sucesso!");







// Cast - Casting
// int a = Convert.ToInt32("5"); //Convert é uma classe que converte para diversos tipos, ToInt32 é um método que recebe uma str e tranforma em int;
// int b = int.Parse("13");
// Convert apresenta o valor "0" quando o retorno é nulo;
// Parse não reconhece e encerra o programa caso o retorno seja nulo;
// Console.WriteLine(a);
// Console.WriteLine(b);







// DateTime dataAtual = DateTime.Now.AddDays(3); //Recupera a data atual que está registrada na máquina, adiciona X dias na data atual;
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); //Formata a data solicitada de acordo com a sua preferência;






// string apresentacao = "Hello, welcome!";

// int quantidade = 1;

// double altura = 1.90; //Tipo de variável utilizado para números decimais mais precisos;

// decimal preco = 2.00M; //Tipo de variável utilizado para questões monetárias, no final do valor precisa colocar o "M";

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Valor da variável quantidade: {quantidade}");
// Console.WriteLine($"Valor da variável altura: " + altura.ToString("0.00"));// Como o tipo é Double, precisa adicionar ".ToString" para aparecer as casas que você quer;
// Console.WriteLine($"Valor da variável preço: {preco}");
// Console.WriteLine($"Valor da variável condição: {condicao}");

//Pessoa pessoa1 = new("Pereira", 23);
//Pessoa pessoa2 = new("Paulo", 22);
//pessoa1.Apresentar();
//pessoa2.Apresentar();
