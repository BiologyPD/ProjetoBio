using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio.Animais
{
    public static class AnimalModels
    {
        public static Animal[] Animals() =>
            typeof(AnimalModels).GetFields(BindingFlags.Static | BindingFlags.Public).Where(field => field.FieldType == typeof(Animal)).Select(an => (Animal)an.GetValue(null)).ToArray();
        /*
            (from FieldInfo field in typeof(AnimalModels).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
             where field.FieldType == typeof(Animal)
             let animal = (Animal)field.GetValue(null)
             orderby animal.Nome
             select animal).ToArray();
        */

        public static readonly Animal Suindara = new Animal()
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
            Filo = Filo.Equinoderma,
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

        public static readonly Animal MorcegoVampiro = new Animal()
        {
            Nome = "Morcego Vampiro",
            NomeCientifico = "Desmodus rotundus",
            Personagem = "Inspiração para a maioria das histórias de morcegos e vampiros devido a sua alimentação a base de sangue.",
            InformacoesInuteis = "",
            Bioma = "Áreas úmidas e secas nos trópicos e subtrópicos.",
            Adaptacoes = "Adaptados para o ambiente aéreo e terrestre, através das asas e membros que os ajudam a andar, escalar e voar.",
            DescricaoMembros = "Membros anteriores transformados em asas.",
            Aparencia = "morcego",
            Habitat = "Florestas, pradarias e regiões montanhosas de até 2400 metros de altitude.",
            RegulacaoAgua = "Possuem rins que são responsáveis pela osmorregulação, que controlam a quantidade de água nos glomérulos renais.",
            Tipo = Tipo.Aereo,
            Filo = Filo.Cordado,
            Respiracao = Respiracao.Pulmonar,
            Alimentacao = new Alimentacao(Filo.Cordado)
            {
                Descricao = "São hematófagos, logo, se alimentam de sangue de outros animais. Caçam de noite, correndo sobre as quatro patas ao longo do solo. Os dentes afiados penetram a veia da vítima, e o morcego bebe o sangue que escorre da presa com a língua.",
                Meio = EMetodoAlimentacao.Cacador,
                Tipo = EAlimentacao.Hematofago,
                DescricaoAnus = "Ânus formado pelo blastóporo e boca feita por uma segunda abertura.",
                DescricaoBoca = "Boca pequena com presas afiadas para perfuração da presa.",
            },
            Defesa = new Defesa()
            {
                Meios = new EDefesa[] { EDefesa.Veneno, EDefesa.Ataque, EDefesa.Mobilidade, },
                Descricao = "Sua estratégia de defesa é o ataque e fuga. Eles atacam sua presa fazendo um rápido corte com suas presas. Em sua saliva há um anestésico que reduz a probabilidade da vítima de sentir algo, fazendo assim o animal ter sua refeição de maneira furtiva.",
            },
            Locomocao = new Locomocao()
            {
                Meio = new ELocomocao[] { ELocomocao.Voar, },
                Descricao = "Capaz de voar, não consegue andar, apenas se rastejar.",
            },
            DevEmbrionario = new DevEmbrionario()
            {
                Meio = EDevEmbrionario.Placenta,
                TipoReproducao = EReproducao.Sexuada,
                Descricao = "Se reproduzem de maneira sexuada, podendo ter de 1 a 2 filhotes por ano.",
                DescricaoCorte = "Para iniciar o acasalamento o macho sobe sobre as costas da fêmea, aperta suas asas com as membranas de voo (patágio) e morde a nuca da fêmea.",
                EpocaReproducao = "É uma espécie sem período definido de reprodução, ou seja, capaz de se reproduzir durante o ano todo.",
            },
        };

        public static readonly Animal CarrapatoEstrela = new Parasita()
        {
            Nome = "Carrapato Estrela",
            NomeCientifico = "Amblyomma cajennense",
            Personagem = "",
            InformacoesInuteis = "",
            Bioma = "O carrapato-estrela é um animal de clima equatorial presente somente no continente americano, sendo muito prevalente em países como o Brasil, México, EUA e etc.",
            Adaptacoes = "Eles possuem adaptações para o clima terrestre como patas.",
            DescricaoMembros = "Oito patas radiais e um corpo oval.",
            Aparencia = "Carrapatos são artrópodes parasitários. Eles são ovais e mais amarronzados, medindo entre 10 e 20 centímetros enquanto adultos.",
            Habitat = "O carrapato-estrela é um animal de clima equatorial presente somente no continente americano, sendo muito prevalente em países como o Brasil, México, EUA e etc.",
            RegulacaoAgua = "Por ser um artrópode, ele possui um exoesqueleto de quitina que evita a perda de água e outros fluídos corporais, porém ele só se alimenta de sangue.",
            Tipo = Tipo.Parasita,
            Filo = Filo.Artropode,
            Respiracao = Respiracao.Traqueal,
            Alimentacao = new Alimentacao(Filo.Artropode)
            {
                Descricao = "Carrapatos são parasitas hematófagos, se alimentando do sangue de seu hospedeiro.",
                Meio = EMetodoAlimentacao.Parasita,
                Tipo = EAlimentacao.Hematofago,
                DescricaoAnus = "empty",
                DescricaoBoca = "Sua boca é dividida em 2 membros, os palpos e o hipostômio; quando o carrapato vai se alimentar, os palpos se abrem para o hipostômio adentrar a pele do hospedeiro, sugando seu sangue.",
            },
            Defesa = new Defesa()
            {
                Meios = new EDefesa[] { EDefesa.Espinhos, EDefesa.Veneno, },
                Descricao = "O carrapato possui diversas farpas em seu tubo de alimentação além de secretar uma substância semelhante ao cimento, as mantendo firmemente presas ao hospedeiro durante sua alimentação. Outra estratégia de defesa são as substâncias analgésicas na saliva do animal, fazendo com que a presa não perceba que foi picada.",
            },
            Locomocao = new Locomocao()
            {
                Meio = new ELocomocao[] { ELocomocao.Andar, },
                Descricao = "Não se move muito, e procura se prender a um hospedeiro para se alimentar.",
            },
            DevEmbrionario = new DevEmbrionario()
            {
                Meio = EDevEmbrionario.Ninfa,
                TipoReproducao = EReproducao.Sexuada,
                Descricao = "Seu ciclo começa com a fêmea botando entre 5.000 e 8.000 ovos, eles eclodem e as larvas, ou micuins, procuram em regiões sombreadas seu primeiro hospedeiro, ficando entre 4 e 5 dias preso até retornar ao solo para realizar a metamorfose, seu próximo estágio é a ninfa, estágio no qual procuram um novo hospedeiro para se agarrar por 5 a 7 dias e se encher de sangue e se preparar para a nova muda, ao completar essa fase e caminhar para a sua última fase, a adulta, ela se enche de sangue mais uma vez de uma nova presa porém para a reprodução desta vez, os adultos macho e fêmea se alimentam juntos e acasalam, após isso a fêmea cheia de ovos sai da vítima para botar os ovos, assim fechando o ciclo.",
                DescricaoCorte = "",
                EpocaReproducao = "",
            },
        };

        public static readonly Animal CoelhoDoMar = new Parasita()
        {
            Nome = "Coelho do Mar",
            NomeCientifico = "Jorunna parva",
            Personagem = "",
            InformacoesInuteis = "",
            Bioma = "Costumam agarrar-se à vegetação submersa e passam a maior parte do tempo no fundo das águas tropicais.",
            Adaptacoes = "<missing>\nÉ possível também que elimine amônia através de seus metanefrídeos(estrutura excretora), já que vive em ambientes onde umidade não é um problema.",
            DescricaoMembros = "Apesar de sua aparência felpuda, seu corpo é revestido por minúsculos bastonetes, chamados de cariofilídeos (ou caryophillidia). Não se sabe ao certo a função dessas estruturas, mas acredita-se que possuem um papel sensorial e auxiliam em sua locomoção.",
            Aparencia = "Jorunna parva, conhecidos popularmente como “Coelhos-do-Mar”, são uma espécie de lesma marinha da família Discodorididae. Ele possui cerca de 2 centímetros de comprimento, simetria bilateral, além de uma pele bem gosmenta.",
            Habitat = "Estão concentrados em áreas onde há abundância de alimentos e onde os recursos são facilmente adquiridos.",
            RegulacaoAgua = "Quanto a regulação de água em seu corpo, é possível terem que ativamente remover sais através das guelras e excretar uma urina concentrada, para assim balancear a perda de água no ambiente extremamente salgado dos mares. Assim, podemos dizer que são animais osmoconformadores, por igualarem sua osmolaridade com seu meio.",
            Tipo = Tipo.Aquatico,
            Filo = Filo.Molusco,
            Respiracao = Respiracao.Branquial,
            Hospedeiro = "",
            HospedeiroIntermediario = "",
            Prevencao = "",
            Contaminacao = "",
            Alimentacao = new Alimentacao(Filo.Molusco)
            {
                Descricao = "Se alimentam principalmente de esponjas da família Chalinidae. Como outros Gastrópodes, sua digestão é extra e intracelular.",
                Meio = EMetodoAlimentacao.Filtrador,
                Tipo = EAlimentacao.Particulas,
                DescricaoAnus = "Origina-se a partir da segunda cavidade formada",
                DescricaoBoca = "Como as demais lesmas-do-mar, apresentam um órgão laminar em sua cavidade oral, chamada rádula. Essa estrutura é muito comum entre outros moluscos, e é revestida por pequenos dentes curvos ou dentículos que os possibilitam raspar o alimento para engolir.",
            },
            Defesa = new Defesa()
            {
                Meios = new EDefesa[] { EDefesa.Veneno, },
                Descricao = "Quando se acasalam, ambos os parceiros trocam esperma por meio de espinhos copulatórios. Realizam fecundação interna (encontro dos gametas e desenvolvimento embrionário ocorrem dentro de seu corpo).",
            },
            Locomocao = new Locomocao()
            {
                Meio = new ELocomocao[] { },
                Descricao = "<missing>",
            },
            DevEmbrionario = new DevEmbrionario()
            {
                Meio = null,
                TipoReproducao = EReproducao.Sexuada,
                Descricao = "São hermafroditas, portanto, possuem tanto órgãos reprodutivos masculinos como femininos. É importante ressaltar que, apesar de hemafroditas, coelhos-do-mar não possuem autofecundação.\nQuando se acasalam, ambos os parceiros trocam esperma por meio de espinhos copulatórios.Realizam fecundação interna(encontro dos gametas e desenvolvimento embrionário ocorrem dentro de seu corpo).",
                DescricaoCorte = "",
                EpocaReproducao = "",
            },
        };


    }
}
