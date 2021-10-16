using System;

namespace ExerciciosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
           bool continuar = true;
           do
           {
                Console.Clear();
                Console.WriteLine("LISTA DE EXERCÍCIOS:");
                Console.WriteLine("1 - Exercício: IMC");
                Console.WriteLine("2 - Exercício: Salário Mínimo");
                Console.WriteLine("3 - Exercício: Volume da Esfera");
                Console.WriteLine("4 - Exercício: Média do Aluno");
                Console.WriteLine("5 - Exercício: Animais");

                Console.WriteLine("\nDigite o exercício desejado:");
                int exercicioEscolhido = Convert.ToInt32(Console.ReadLine());

                switch (exercicioEscolhido)
                {
                    case 1:
                        //EXERCÍCIO 1:
                        Console.Clear();
                        Console.WriteLine("EXERCÍCIO 1:");
                        double peso, altura, imc;

                        Console.WriteLine("Digite o seu peso (Kg):");

                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a sua altura (em centímetros):");

                        altura = Convert.ToDouble(Console.ReadLine());
                        
                        altura /= 100;
                        imc = peso / (altura * altura);

                        Console.WriteLine("\nSeu IMC é {0}.", string.Format("{0:0.00}", imc));

                        if (imc < 20)
                        {
                            Console.WriteLine("Você está abaixo do peso.");
                        }
                        else if (imc < 25)
                        {
                            Console.WriteLine("Você está no peso ideal.");
                        }
                        else
                        {
                            Console.WriteLine("Você está acima do peso.");
                        }

                        break;
                        //FIM EXERCÍCIO 1.
                    case 2:
                        //EXERCÍCIO 2:
                        Console.Clear();
                        Console.WriteLine("EXERCÍCIO 2:");

                        double salario, salarioMinimo, qtdeSalarios;

                        Console.WriteLine("Digite o seu salário:");
                        salario = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o salário mínimo atual:");
                        salarioMinimo = Convert.ToDouble(Console.ReadLine());

                        qtdeSalarios = salario / salarioMinimo;

                        Console.WriteLine("\nVocê recebe {0} salário(s) mínimo(s).", string.Format("{0:0}", qtdeSalarios));

                        break;
                        //FIM EXERCÍCIO 2.
                    case 3:
                        //EXERCÍCIO 3:
                        Console.Clear();
                        Console.WriteLine("EXERCÍCIO 3:");

                        double raio, volume;
                        const double pi = 3.14159;

                        Console.WriteLine("Digite o raio (R) da esfera:");
                        raio = Convert.ToDouble(Console.ReadLine());

                        volume = (4 * pi * Math.Pow(raio, 3)) / 3;

                        Console.WriteLine("\nO Volume da esfera é {0} m3.", string.Format("{0:0.00}", volume));

                        break;
                        //FIM EXERCÍCIO 3.
                    case 4:
                        //EXERCÍCIO 4:
                        Console.Clear();
                        Console.WriteLine("EXERCÍCIO 4:");

                        double nota1, nota2, nota3;
                        double media;

                        Console.WriteLine("Digite a primeira nota: ");
                        nota1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite a segunda nota: ");
                        nota2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a terceira nota: ");
                        nota3 = Convert.ToDouble(Console.ReadLine());

                        media = (nota1 + nota2 + nota3) / 3;

                        if (media >= 7)
                        {
                            Console.WriteLine("\nAprovado!\nSua média foi de {0}.", string.Format("{0:0.0}", media));
                        } else
                        {
                            double notaExame;
                            
                            Console.WriteLine("\nDigite sua nota do exame: ");
                            notaExame = Convert.ToDouble(Console.ReadLine());

                            double novaMedia = (media + notaExame) / 2;

                            if (novaMedia >= 5)
                            {
                                Console.WriteLine("\nAprovado!\nSua média foi de {0}.", string.Format("{0:0.0}", novaMedia));
                            }
                            else
                            {
                                Console.WriteLine("\nReprovado!\nSua média foi de {0}.", string.Format("{0:0.0}", novaMedia));
                            }
                        }
                        break;
                        //FIM EXERCÍCIO 4.
                    case 5:
                        //EXERCÍCIO 5:
                        Console.Clear();
                        Console.WriteLine("EXERCÍCIO 5:");

                        string animalNome, animalTipo;
                        int cachorroContador = 0, gatoContador = 0, peixeContador = 0;

                        //Processo do PRIMEIRO animal:
                        Console.Clear();
                        Console.WriteLine("\nDigite o NOME do primeiro animal:");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("\nDigite o TIPO do primeiro animal:");
                        animalTipo = Console.ReadLine();

                        Animal animal1 = new Animal(animalNome, animalTipo);
               
                        if (animal1.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador ++;
                        }
                        else if (animal1.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        //Processo do SEGUNDO animal:
                        Console.Clear();
                        Console.WriteLine("\nDigite o NOME do segundo animal:");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("\nDigite o TIPO do segundo animal:");
                        animalTipo = Console.ReadLine();

                        Animal animal2 = new Animal(animalNome, animalTipo);

                        if (animal2.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal2.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        //Processo do TERCEIRO animal:
                        Console.Clear();
                        Console.WriteLine("\nDigite o NOME do terceiro animal:");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("\nDigite o TIPO do terceiro animal:");
                        animalTipo = Console.ReadLine();

                        Animal animal3 = new Animal(animalNome, animalTipo);

                        if (animal3.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal3.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        //Processo do QUARTO animal:
                        Console.Clear();
                        Console.WriteLine("\nDigite o NOME do quarto animal:");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("\nDigite o TIPO do quarto animal:");
                        animalTipo = Console.ReadLine();

                        Animal animal4 = new Animal(animalNome, animalTipo);

                        if (animal4.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal4.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        //Processo do QUINTO animal:
                        Console.Clear();
                        Console.WriteLine("\nDigite o NOME do quinto animal:");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("\nDigite o TIPO do quinto animal:");
                        animalTipo = Console.ReadLine();

                        Animal animal5 = new Animal(animalNome, animalTipo);

                        if (animal5.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal5.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        //Saída:
                        Console.Clear();
                        Console.WriteLine("\nVocê digitou:");
                        Console.WriteLine("{0} cachorro(s);\n{1} gato(s);\n{2} peixe(s).", cachorroContador, gatoContador, peixeContador);

                        break;
                        //FIM EXERCÍCIO 5.
                }

                //SE O USUÁRIO DESEJA VER OUTRO EXERCÍCIO:
                Console.WriteLine("\nTecle ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Deseja visualizar outro exercício?");
                Console.WriteLine("0 - NÃO");
                Console.WriteLine("1 - SIM");
                int validacao = Convert.ToInt32(Console.ReadLine());

                if(validacao == 1)
                {
                    continuar = true;
                } else if (validacao == 0)
                {
                    continuar = false;
                } else
                {
                    continuar = false;
                    Console.WriteLine("\nDesculpe, essa opção não existe.");
                }
           } while (continuar == true);
            Console.WriteLine("Fim do programa."); 
        }
    }
}
