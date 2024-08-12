using AppShowdoMIlhao.Models;
using CoreNFC;

namespace AppShowdoMIlhao
{
    public partial class App : Application
    {
        List<Perguntas> perguntas_faceis = new()
        {
            new Perguntas
            {
                 Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO"}
                }
            },

            new Perguntas
            {
                Id = 2,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Marechal Deodoro"},
                    new Alternativa { Correta = false, Descricao = "Marquês de Pombal" },
                    new Alternativa { Correta = false, Descricao = "Duque de Caixias" },
                    new Alternativa { Correta = false, Descricao = "Barão de Mauá" }

                }
            },
            new Perguntas
            {
                Id = 3,
                Enunciado = "Qual é o santo casamenteiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "São Pedro" },
                    new Alternativa { Correta = false, Descricao = "São Paulo" },
                    new Alternativa { Correta = true, Descricao = "Santo Antônio" },
                    new Alternativa { Correta = false, Descricao = "São João" }
                }

            },
            new Perguntas
            {
                Id = 4,
                Enunciado = "Qual o nome da namorada do Mickey Mouse?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Margarida"},
                    new Alternativas { Correta = true, Descricao = "Minnie"},
                    new Alternativas { Correta = false, Descricao = "A Pequena Sereia"},
                    new Alternativas { Correta = false, Descricao = "Olívia Palito"}
                }
            },
            new Perguntas
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Cuca"},
                    new Alternativas { Correta = false, Descricao = "Negrinhon do Pastoreio"},
                    new Alternativas { Correta = false, Descricao = "Boitatá" },
                    new Alternativas { Correta = true, Descricao = "Saci Pererê"},
                }
            },
            new Perguntas
            {
                Id = 6,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Gauchinha" },
                    new Alternativas { Correta = false, Descricao = "Paulistinha" },
                    new Alternativas { Correta = true, Descricao = "Pimentinha" },
                    new Alternativas { Correta = false, Descricao = "Andorinha" }
                }
            },
            new Perguntas
            {
                Id = 7,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Jamaica"},
                    new Alternativas { Correta = true, Descricao = "Cuba" },
                    new Alternativas { Correta = false, Descricao = "El Salvador" },
                    new Alternativas { Correta = false, Descricao = "México"},
                }
            },
            new Perguntas
            {
                Id = 8,
                Enunciado = "Quem proclamou a república no Brasil em 1888?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Duque de Caxias"},
                    new Alternativas { Correta = false, Descricao = "Marechal Rodon" },
                    new Alternativas { Correta = true, Descricao = "Dom Pedro II" },
                    new Alternativas { Correta = false, Descricao = "Marechal Deodoro"},
                }
            },
            new Perguntas
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovavav os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Raul Gil"},
                    new Alternativas { Correta = false, Descricao = "Bolinha" },
                    new Alternativas { Correta = false, Descricao = "Flávio Cavalcanti" },
                    new Alternativas { Correta = true, Descricao = "Chacrinha"},
                }
            },
            new Perguntas
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "Monstro"},
                    new Alternativas { Correta = false, Descricao = "Gorila" },
                    new Alternativas { Correta = false, Descricao = "Príncipe" },
                    new Alternativas { Correta = false, Descricao = "Sapo"},
                }
            },
            new Perguntas
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Virgem"},
                    new Alternativas { Correta = false, Descricao = "Aquário" },
                    new Alternativas { Correta = true, Descricao = "Capricórnio" },
                    new Alternativas { Correta = false, Descricao = "Áries"},
                }
            },
            new Perguntas
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de carros Ford?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Harrison Ford"},
                    new Alternativas { Correta = false, Descricao = "Gerald Ford" },
                    new Alternativas { Correta = true, Descricao = "Henry Ford" },
                    new Alternativas { Correta = false, Descricao = "Anna Ford"},
                }
            },
            new Perguntas
            {
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Preta"},
                    new Alternativas { Correta = false, Descricao = "Vermelha" },
                    new Alternativas { Correta = false, Descricao = "Azul" },
                    new Alternativas { Correta = true, Descricao = "Verde"},
                }
            },
            new Perguntas
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "200"},
                    new Alternativas { Correta = true, Descricao = "100" },
                    new Alternativas { Correta = false, Descricao = "170" },
                    new Alternativas { Correta = false, Descricao = "220"},
                }
            },
            new Perguntas
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência no Brasil?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "21 de abril"},
                    new Alternativas { Correta = false, Descricao = "12 de outubro" },
                    new Alternativas { Correta = true, Descricao = "7 de setembro" },
                    new Alternativas { Correta = false, Descricao = "25 de dezembro"},
                }
            },
            new Perguntas
            {
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Veneza" },
                    new Alternativas { Correta = false, Descricao = "Vitória" },
                    new Alternativas { Correta = true, Descricao = "Vaticano" },
                    new Alternativas { Correta = false, Descricao = "Vancouver"},
                }
            },
            new Perguntas
            {
                Id = 17,
                Enunciado = "Quem tem por lema a frase 'Sempre Alerta'?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Médicos"},
                    new Alternativas { Correta = true, Descricao = "Escoteiros" },
                    new Alternativas { Correta = false, Descricao = "Bombeiros" },
                    new Alternativas { Correta = false, Descricao = "Policiais"},
                }
            },
            new Perguntas
            {
                Id = 18,
                Enunciado = "Quem foi o grande amor da vida da Julieta?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "Romeu"},
                    new Alternativas { Correta = false, Descricao = "Orfeu" },
                    new Alternativas { Correta = false, Descricao = "Hamlet" },
                    new Alternativas { Correta = false, Descricao = "Iago"},
                }
            },
            new Perguntas
            {
                Id = 19,
                Enunciado = "Quantos signos formam o zodíaco?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "9"},
                    new Alternativas { Correta = false, Descricao = "10" },
                    new Alternativas { Correta = false, Descricao = "11" },
                    new Alternativas { Correta = true, Descricao = "12"},
                }
            },
            new Perguntas
            {
                Id = 20,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Paraná"},
                    new Alternativas { Correta = false, Descricao = "Santa Catarina" },
                    new Alternativas { Correta = false, Descricao = "São Paulo" },
                    new Alternativas { Correta = true, Descricao = "Bahia"},
                }
            },
            new Perguntas
            {
                Id = 21,
                Enunciado = "Como se chama o lugar onde são armazenadas as balas de um revólver?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Cano"},
                    new Alternativas { Correta = true, Descricao = "Tambor" },
                    new Alternativas { Correta = false, Descricao = "Agulha" },
                    new Alternativas { Correta = false, Descricao = "Gatilho"},
                }
            },
            new Perguntas
            {
                Id = 22,
                Enunciado = "Qual personagem da Turma da Mônica tem apenas cinco fios de cabelo?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Mônica"},
                    new Alternativas { Correta = true, Descricao = "Cebolinha" },
                    new Alternativas { Correta = false, Descricao = "Cascão" },
                    new Alternativas { Correta = false, Descricao = "Magali"},
                }
            },
            new Perguntas
            {
                Id = 23,
                Enunciado = "Qual cantora tinha o apelido de 'Ternurinha' na época da jovem guarda?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Silvinha"},
                    new Alternativas { Correta = true, Descricao = "Wanderléia" },
                    new Alternativas { Correta = false, Descricao = "Gretchen" },
                    new Alternativas { Correta = false, Descricao = "Martinha"},
                }
            },
            new Perguntas
            {
                Id = 24,
                Enunciado = "O churrasco é considerado uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Ceará"},
                    new Alternativas { Correta = true, Descricao = "Rio Grande do Sul" },
                    new Alternativas { Correta = false, Descricao = "Pará" },
                    new Alternativas { Correta = false, Descricao = "Maranhão"},
                }
            },
            new Perguntas
            {
                Id = 25,
                Enunciado = "Qual cantor é pai da dupla Sandy e Júnior?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Leonardo"},
                    new Alternativas { Correta = true, Descricao = "Xororó" },
                    new Alternativas { Correta = false, Descricao = "Zezé di Camargo" },
                    new Alternativas { Correta = false, Descricao = "Chitãozinho"},
                }
            },
            new Perguntas
            {
                Id = 26,
                Enunciado = "Quem foi o criador dos personagens Pedrinho, Narizinho e Emília?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Maurício de Souza"},
                    new Alternativas { Correta = false, Descricao = "Ziraldo" },
                    new Alternativas { Correta = true, Descricao = "Monteiro Lobato" },
                    new Alternativas { Correta = false, Descricao = "Machado de Assis"},
                }
            },
            0new Perguntas
            {
                Id = 27,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Saltão de Brunei"},
                    new Alternativas { Correta = false, Descricao = "Akio Morita" },
                    new Alternativas { Correta = true, Descricao = "Bill Gates" },
                    new Alternativas { Correta = false, Descricao = "Príncipe Charles"},
                }
            },
            new Perguntas
            {
                Id = 28,
                Enunciado = "Qual é o nome dado ao pneu reserva do carro?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Calota"},
                    new Alternativas { Correta = true, Descricao = "Estepe" },
                    new Alternativas { Correta = false, Descricao = "Macaco" },
                    new Alternativas { Correta = false, Descricao = "Chave de Roda"},
                }
            },
            new Perguntas
            {
                Id = 29,
                Enunciado = "Qual é o nome do cachorro medroso do Salsicha?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Floquinho"},
                    new Alternativas { Correta = false, Descricao = "Rin-tin-tin" },
                    new Alternativas { Correta = false, Descricao = "Lassie" },
                    new Alternativas { Correta = true, Descricao = "Scooby-doo"},
                }
            },
            new Perguntas
            {
                Id = 30,
                Enunciado = "Quantas dentições naturais o ser humano tem?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "1"},
                    new Alternativas { Correta = false, Descricao = "2" },
                    new Alternativas { Correta = false, Descricao = "3" },
                    new Alternativas { Correta = false, Descricao = "4"},
                }
            },
            new Perguntas
            {
                Id = 31,
                Enunciado = "Edinho, filho de Pelé, jogou no Santos em que posição?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Zagueiro"},
                    new Alternativas { Correta = true, Descricao = "Goleiro" },
                    new Alternativas { Correta = false, Descricao = "Atacante" },
                    new Alternativas { Correta = false, Descricao = "Armador"},
                }
            },
            new Perguntas
            {
                Id = 32,
                Enunciado = "Qual a pedra preciosa mais dura encontrada na natureza?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Esmeralda"},
                    new Alternativas { Correta = false, Descricao = "Rubi" },
                    new Alternativas { Correta = false, Descricao = "Pérola" },
                    new Alternativas { Correta = true, Descricao = "Diamante"},
                }
            },
            new Perguntas
            {
                Id = 33,
                Enunciado = "Como se chama o lugar onde se guardam vinhos?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Adega"},
                    new Alternativas { Correta = false, Descricao = "Biblioteca" },
                    new Alternativas { Correta = false, Descricao = "Sótão" },
                    new Alternativas { Correta = false, Descricao = "Sala"},
                }
            },
            new Perguntas
            {
                Id = 34,
                Enunciado = "Qual cantor ficou conhecido como 'Rei do Rock'?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Frank Sinatra"},
                    new Alternativas { Correta = false, Descricao = "Little Richard" },
                    new Alternativas { Correta = true, Descricao = "Elvis Presley" },
                    new Alternativas { Correta = false, Descricao = "Richie Valens"},
                }
            },
            new Perguntas
            {
                Id = 35,
                Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Félix"},
                    new Alternativas { Correta = false, Descricao = "Tom" },
                    new Alternativas { Correta = true, Descricao = "Frajola" },
                    new Alternativas { Correta = false, Descricao = "Mingau"},
                }
            },
            new Perguntas
            {
                Id = 36,
                Enunciado = "Joana Prado é o nome verdadeiro de qual artista?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Tiazinha"},
                    new Alternativas { Correta = true, Descricao = "Feiticeira" },
                    new Alternativas { Correta = false, Descricao = "Lady Lu" },
                    new Alternativas { Correta = false, Descricao = "Sheila Melo"},
                }
            },
            new Perguntas
            {
                Id = 37,
                Enunciado = "Quantos dias tem um ano bissexto?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "364"},
                    new Alternativas { Correta = false, Descricao = "365" },
                    new Alternativas { Correta = true, Descricao = "366" },
                    new Alternativas { Correta = false, Descricao = "367"},
                }
            },
             new Perguntas
            {
                Id = 38,
                Enunciado = "Qual é o réptil que muda de cor conforme o lugar em que está?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Sapo"},
                    new Alternativas { Correta = true, Descricao = "Camaleão" },
                    new Alternativas { Correta = false, Descricao = "Lagarto" },
                    new Alternativas { Correta = false, Descricao = "Jacaré"},
                }
            },
              new Perguntas
            {
                Id = 39,
                Enunciado = "Qual é a duração de cada tempo de uma partida de futebol?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "45 minutos"},
                    new Alternativas { Correta = false, Descricao = "90 minutos" },
                    new Alternativas { Correta = false, Descricao = "120 minutos" },
                    new Alternativas { Correta = false, Descricao = "150 minutos"},
                }
            },
               new Perguntas
            {
                Id = 40,
                Enunciado = "Onde fica o centro da indústria cinematográfica dos EUA?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Nova York"},
                    new Alternativas { Correta = false, Descricao = "Las Vegas" },
                    new Alternativas { Correta = false, Descricao = "Nova Orleans" },
                    new Alternativas { Correta = true, Descricao = "Hollywood"},
                }
            },
                new Perguntas
            {
                Id = 41,
                Enunciado = "Qual era o código da identidade secreta de James Bond?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "707"},
                    new Alternativas { Correta = false, Descricao = "907" },
                    new Alternativas { Correta = false, Descricao = "008" },
                    new Alternativas { Correta = true, Descricao = "007"},
                }
            },
                 new Perguntas
            {
                Id = 42,
                Enunciado = "Qual é a fruta associada com a cidade Laranjal?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Melancia"},
                    new Alternativas { Correta = true, Descricao = "Laranja" },
                    new Alternativas { Correta = false, Descricao = "Maçã" },
                    new Alternativas { Correta = false, Descricao = "Uva"},
                }
            },
                  new Perguntas
            {
                Id = 43,
                Enunciado = "Quantos centavos equivalem a um real?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "10"},
                    new Alternativas { Correta = false, Descricao = "1000" },
                    new Alternativas { Correta = true, Descricao = "100" },
                    new Alternativas { Correta = false, Descricao = "50"},
                }
            },
            new Perguntas
            {
                Id = 44,
                Enunciado = "De acordo com a Biblía, qual era o fruto proibido?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Mamão"},
                    new Alternativas { Correta = true, Descricao = "Maçã"},
                    new Alternativas { Correta = false, Descricao = "Uva"},
                    new Alternativas { Correta = false, Descricao = "Abacaxi"},
                }

            },
            new Perguntas
            {
                Id = 45,
                Enunciado = "Como é conhecida a ponte que liga Rio de Janeiro a Niterói?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Golden Gate"},
                    new Alternativas { Correta = true, Descricao = "Rio-Niterói"},
                    new Alternativas { Correta = false, Descricao = "Rio São Francisco"},
                    new Alternativas { Correta = false, Descricao = "Brooklin"},
                }

            },
            new Perguntas
            {
                Id = 46,
                Enunciado = "Em que ano os portugueses descobriram o Brasil?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "1450"},
                    new Alternativas { Correta = true, Descricao = "1500"},
                    new Alternativas { Correta = false, Descricao = "1550"},
                    new Alternativas { Correta = false, Descricao = "1400"},
                }

            },
            new Perguntas
            {
                Id = 47,
                Enunciado = "O que é medido por um termômetro?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Longitude"},
                    new Alternativas { Correta = false, Descricao = "Umidade"},
                    new Alternativas { Correta = true, Descricao = "Temperatura"},
                    new Alternativas { Correta = false, Descricao = "Latitude"},
                }

            },
           new Perguntas
            {
                Id = 48,
                Enunciado = "O rio Amazonas pertence a qual continente?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "Americano"},
                    new Alternativas { Correta = false, Descricao = "Africano"},
                    new Alternativas { Correta = false, Descricao = "Europeu"},
                    new Alternativas { Correta = false, Descricao = "Asiático"},
                }

            },
            new Perguntas
            {
                Id = 49,
                Enunciado = "Quem esculpiu o boneco Pinóquio?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "Gepeto"},
                    new Alternativas { Correta = false, Descricao = "Fada"},
                    new Alternativas { Correta = false, Descricao = "Bruxa"},
                    new Alternativas { Correta = false, Descricao = "Gigante"},
                }

            },
            new Perguntas
            {
                Id = 50,
                Enunciado = "Qual a moeda oficial dos Estados Unidos?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Escudo"},
                    new Alternativas { Correta = false, Descricao = "Coroa"},
                    new Alternativas { Correta = true, Descricao = "Dólar"},
                    new Alternativas { Correta = false, Descricao = "Libra"},
                }

            },
            new Perguntas
            {
                Id = 51,
                Enunciado = "Qual foi o placar no final da Copa de 98, quando o Brasil perdeu para a França?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "2x0"},
                    new Alternativas { Correta = true, Descricao = "3x0"},
                    new Alternativas { Correta = false, Descricao = "4x0"},
                    new Alternativas { Correta = false, Descricao = "5x0"},
                }

            },
            new Perguntas
            {
                Id = 52,
                Enunciado = "Quantas folhas tem um trevo da sorte?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "1"},
                    new Alternativas { Correta = false, Descricao = "2"},
                    new Alternativas { Correta = false, Descricao = "3"},
                    new Alternativas { Correta = true, Descricao = "4"},
                }

            },
            new Perguntas
            {
                Id = 53,
                Enunciado = "Qual é a cidade conhecida como “terra da garoa”?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Rio de Janeiro"},
                    new Alternativas { Correta = false, Descricao = "Porto Alegre"},
                    new Alternativas { Correta = false, Descricao = "Piracicaba"},
                    new Alternativas { Correta = true, Descricao = "São Paulo"},
                }

            },
            new Perguntas
            {
                Id = 54,
                Enunciado = "Qual ator do cinema brasileiro é conhecido por ter unhas enormes?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Penadinho"},
                    new Alternativas { Correta = true, Descricao = "Zé do caixão"},
                    new Alternativas { Correta = false, Descricao = "Zé do Casarão"},
                    new Alternativas { Correta = false, Descricao = "Toninho do diabo"},
                }

            },
            new Perguntas
            {
                Id = 55,
                Enunciado = "O violoncelo é um tipo de instrumento de",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Sopro"},
                    new Alternativas { Correta = true, Descricao = "Cordas"},
                    new Alternativas { Correta = false, Descricao = "Percussão"},
                    new Alternativas { Correta = false, Descricao = "Repercussão"},
                }

            },
            new Perguntas
            {
                Id = 56,
                Enunciado = "Com que fruta a Branca de Neve foi envenenada?",
                Alternativas = new()
                {
                    new Alternativas { Correta = true, Descricao = "Maçã"},
                    new Alternativas { Correta = false, Descricao = "Pêra"},
                    new Alternativas { Correta = false, Descricao = "Melão"},
                    new Alternativas { Correta = false, Descricao = "Laranja"},
                }

            },
            new Perguntas
            {
                Id = 57,
                Enunciado = "Quem foi técnico da Seleção brasileira de futebol na Copa de 98?",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = "Zagallo"},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            new Perguntas
            {
                Id = ,
                Enunciado = "",
                Alternativas = new()
                {
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                    new Alternativas { Correta = false, Descricao = ""},
                }

            },
            
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
