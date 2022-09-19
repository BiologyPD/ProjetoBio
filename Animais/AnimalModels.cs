using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio.Animais
{
    public static class AnimalModels
    {
        public static Animal Suindara { 
            get
            {
                return new Animal()
                {
                    Nome = "Suindara",
                    NomeCientifico = "Tyto furcata",
                    Personagem = "“Soren” do filme A Lenda dos Guardiões.",
                    Adaptacoes = "Adaptação para voo com a presença de penas e asas, ausência de bexiga urinária, excreção de ácido úrico e ossos ocos.",
                    DescricaoMembros = "Possui duas asas e duas patas com garras.",
                    Aparencia = "COJURA!",
                    InformacoesInuteis = "tem uma baita lenda sobre como se ela passar na sua casa alguém vai morrer, e corujas não tem penas a prova d'água, como a maioria das aves, pois isso as permite voar silenciosamente e atacar despercebidas. Por causa disso, corujas molhadas são um tanto engraçadas. Além disso, corujas NÃO são pássaros. Corujas são aves.",
                    Bioma = "Amazônico/Equatorial.",
                    Habitat = "Margem sul do rio Amazonas até a Terra do Fogo (arquipélago na extremidade sul da América do Sul) e nas Ilhas Maldivas.",
                    RegulacaoAgua = "Para economia de água no organismo, excretam ácido úrico, já que não possuem bexiga.",
                    Tipo = Tipo.Aereo,
                    Filo = Filo.Cordado,
                    Respiracao = Respiracao.Pulmonar,
                    Alimentacao = new Alimentacao(Filo.Cordado)
                    {
                        Descricao = "Se alimentam de insetos, pequenos marsupiais, morcegos, roedores, anfíbios, répteis e aves.",
                        Meio = EMetodoAlimentacao.Cacador,
                        Tipo = EAlimentacao.Carnivoro,
                        DescricaoAnus = "Cloaca",
                        DescricaoBoca = "Bico",
                    },
                    Defesa = new Defesa()
                    {
                        Meios = new EDefesa[] { EDefesa.Camuflagem },
                        Descricao = "Costumam se esconder muito bem durante o dia, valendo-se da camuflagem que lhes proporcionam suas penas mescladas, de vários tons de marrom, cinza, branco e preto, em meio aos galhos e troncos de árvores."
                                + "\nSe perturbadas, balançam o corpo lateralmente. Se encurraladas, jogam-se de barriga para cima, enfrentando o perigo com as poderosas garras que lançam para frente.",
                    },
                    Locomocao = new Locomocao()
                    {
                        Meio = new ELocomocao[] { ELocomocao.Voar, ELocomocao.Andar, ELocomocao.Escalar },
                        Descricao = "ela... voa? e eu acho que ela escala", // MISSING
                    },
                    DevEmbrionario = new DevEmbrionario()
                    {
                        Meio = EDevEmbrionario.OvoCalcificado,
                        TipoReproducao = EReproducao.Sexuada,
                        Descricao = "Desenvolvimento direto e fecundação interna. Dentro do ovo haverá um zigoto que se desenvolverá em uma pequena ave a partir da incubação de ambos os pais.",
                        DescricaoCorte = "Um roncar é emitido no período de acasalamento, entoado em dueto pelo casal, a fêmea responde nos intervalos que o macho intercala.",
                        EpocaReproducao = "Até 22/04/2018, somente entre os meses de janeiro e março, não houveram registros de ninhos ativos, o que talvez indique que o período reprodutivo da espécie seja bastante prolongado.",
                    },
                };
            }
        }
    }
}
