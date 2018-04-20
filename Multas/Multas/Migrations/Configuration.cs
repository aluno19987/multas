namespace Multas.Migrations
{
    using Multas.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MultasDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MultasDb context)
        {

            //*********************************************************************
            // adiciona AGENTES
            var agentes = new List<Agentes> {
               new Agentes {ID=1, Nome="Tânia Vieira", Esquadra="Ourém", Fotografia="TaniaVieira.jpg" },
               new Agentes {ID=2, Nome="António Rocha", Esquadra="Ourém", Fotografia="AntonioRocha.jpg" },
               new Agentes {ID=3, Nome="André Silveira", Esquadra="Abrantes", Fotografia="AndreSilveira.jpg" },
               new Agentes {ID=4, Nome="Lurdes Vieira", Esquadra="Leiria", Fotografia="LurdesVieira.jpg" },
               new Agentes {ID=5, Nome="Cláudia Pinto", Esquadra="Porto", Fotografia="ClaudiaPinto.jpg" },
               new Agentes {ID=6, Nome="Rui Vieira", Esquadra="Tomar", Fotografia="RuiVieira.jpg" },
               new Agentes {ID=7, Nome="Paulo Vieira", Esquadra="Torres Novas", Fotografia="PauloVieira.jpg" },
               new Agentes {ID=8, Nome="Augusto Carvalho", Esquadra="Lisboa", Fotografia="AugustoCarvalho.jpg" },
               new Agentes {ID=9, Nome="Beatriz Pinto", Esquadra="Porto", Fotografia="BeatrizPinto.jpg" },
               new Agentes {ID=10, Nome="José Alves", Esquadra="Alcanena", Fotografia="JoseAlves.jpg" }
            };
            agentes.ForEach(aa => context.Agentes.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona VIATURAS
            var viaturas = new List<Viaturas> {
               new Viaturas {ID=1, Matricula="AT-47-45",  Marca="Ford",  Modelo="Focus WRC", Cor="Branco",  NomeDono="Tiago Lopes",  MoradaDono="Rua de Coimbra",  CodPostalDono="2300-471 TOMAR" },
               new Viaturas {ID=2, Matricula="BM-72-65",  Marca="Seat",  Modelo="Toledo", Cor="Preto",  NomeDono="Henrique Soares",  MoradaDono="Azinhaga de Bacelos",  CodPostalDono="2300-439 TOMAR" },
               new Viaturas {ID=3, Matricula="CI-57-04",  Marca="Ferrari",  Modelo="Testarossa", Cor="Vermelho",  NomeDono="Luciano Fernandes",  MoradaDono="Travessa dos Arcos",  CodPostalDono="2300-602 TOMAR" },
               new Viaturas {ID=4, Matricula="CQ-07-12",  Marca="Renault",  Modelo="Clio", Cor="Cinzento",  NomeDono="Mara Fernandes",  MoradaDono="Rua da Saboaria",  CodPostalDono="2300-559 TOMAR" },
               new Viaturas {ID=5, Matricula="DM-21-48",  Marca="Ford",  Modelo="Mondeo", Cor="Vermelho",  NomeDono="Luciana Rocha",  MoradaDono="Rua Infantaria 15",  CodPostalDono="2300-583 TOMAR" },
               new Viaturas {ID=6, Matricula="EU-59-11",  Marca="Renault",  Modelo="Espace", Cor="Verde",  NomeDono="Isabel Rosa",  MoradaDono="Rua Paulo Oliveira",  CodPostalDono="2300-514 TOMAR" },
               new Viaturas {ID=7, Matricula="FJ-74-85",  Marca="Audi",  Modelo="TT", Cor="Branco",  NomeDono="Alexandre Vieira",  MoradaDono="Rua do Centro Republicano",  CodPostalDono="2300-359 TOMAR" },
               new Viaturas {ID=8, Matricula="HC-41-61",  Marca="Fiat",  Modelo="Bravo", Cor="Preto",  NomeDono="Guilherme Rodrigues",  MoradaDono="Rua do Teatro",  CodPostalDono="2300-573 TOMAR" },
               new Viaturas {ID=9, Matricula="HO-15-18",  Marca="Renault",  Modelo="Twingo", Cor="Azul",  NomeDono="Paulo Vieira",  MoradaDono="Rua da Cascalheira",  CodPostalDono="2300-464 TOMAR" },
               new Viaturas {ID=10, Matricula="HV-21-24",  Marca="BMW",  Modelo="Serie 5", Cor="Cinzento",  NomeDono="João  Vieira",  MoradaDono="Rua Torres Pinheiro",  CodPostalDono="2300-538 TOMAR" },
               new Viaturas {ID=11, Matricula="KK-71-88",  Marca="Renault",  Modelo="4L", Cor="Vermelho",  NomeDono="João Simões Lopes",  MoradaDono="Rua S. João",  CodPostalDono="2300-001 TOMAR" },
               new Viaturas {ID=12, Matricula="LL-21-07",  Marca="Seat",  Modelo="Marbelha", Cor="Verde",  NomeDono="Henrique Dias",  MoradaDono="Caminho Água das Maias",  CodPostalDono="2300-632 TOMAR" },
               new Viaturas {ID=13, Matricula="MJ-87-82",  Marca="Seat",  Modelo="Ibisa", Cor="Branco",  NomeDono="Tânia Fernandes",  MoradaDono="Avenida Doutor Vieira Guimarães",  CodPostalDono="2300-534 TOMAR" },
               new Viaturas {ID=14, Matricula="NG-96-34",  Marca="Renault",  Modelo="Megane", Cor="Preto",  NomeDono="Guilherme Pinto",  MoradaDono="Rua de Leiria",  CodPostalDono="2300-565 TOMAR" },
               new Viaturas {ID=15, Matricula="NS-21-62",  Marca="Fiat",  Modelo="Panda", Cor="Azul",  NomeDono="Rodrigo Vieira",  MoradaDono="Rua Doutor Oliveira Salazar",  CodPostalDono="2305-123 ASSEICEIRA TMR" },
               new Viaturas {ID=16, Matricula="OI-17-31",  Marca="Fiat",  Modelo="Punto 75 SX", Cor="Cinzento",  NomeDono="Manuel Rodrigues",  MoradaDono="Rua Fernando Lopes Graça",  CodPostalDono="2300-493 TOMAR" },
               new Viaturas {ID=17, Matricula="SM-38-87",  Marca="Porshe",  Modelo="911 Carrera", Cor="Preto",  NomeDono="Simone Vieira",  MoradaDono="Rua 1º de Maio",  CodPostalDono="2300-448 TOMAR" },
               new Viaturas {ID=18, Matricula="TV-35-04",  Marca="Audi",  Modelo="A4", Cor="Verde",  NomeDono="Luciano Vieira",  MoradaDono="Largo da Saboaria",  CodPostalDono="2300-327 TOMAR" },
               new Viaturas {ID=19, Matricula="UE-92-24",  Marca="Audi",  Modelo="A3", Cor="Branco",  NomeDono="Marcos Vieira",  MoradaDono="Avenida Dom Nuno Álvares Pereira",  CodPostalDono="2300-532 TOMAR" },
               new Viaturas {ID=20, Matricula="XD-71-88",  Marca="BMW",  Modelo="Serie3", Cor="Preto",  NomeDono="Renato Vieira",  MoradaDono="Rua do Orfeão Tomarense",  CodPostalDono="2300-480 TOMAR" },
               new Viaturas {ID=21, Matricula="ZG-74-16",  Marca="Skoda",  Modelo="Superb", Cor="Azul",  NomeDono="Fábio Ribeiro",  MoradaDono="Rua Dom Diogo Torralva",  CodPostalDono="2300-477 TOMAR" }
            };
            viaturas.ForEach(vv => context.Viaturas.AddOrUpdate(v => v.Matricula, vv));
            context.SaveChanges();

            //*********************************************************************
            // adiciona CONDUTORES
            var condutores = new List<Condutores> {
                new Condutores {ID=1, Nome=" João Santos", BI="123456", Telemovel="912039720", DataNascimento=new DateTime(1965,2,21), NumCartaConducao="SA-12345", LocalEmissao="Santarém", DataValidadeCarta=new DateTime(2022,1,22) },
                new Condutores {ID=2, Nome=" Daniel Soares", BI="259608283", Telemovel="928155823", DataNascimento=new DateTime(1966,7,19), NumCartaConducao="LX-244056", LocalEmissao="Lisboa", DataValidadeCarta=new DateTime(2029,9,24) },
                new Condutores {ID=3, Nome=" Adriana Rodrigues", BI="588141871", Telemovel="922775155", DataNascimento=new DateTime(1981,12,3), NumCartaConducao="LX-847226", LocalEmissao="Lisboa", DataValidadeCarta=new DateTime(2025,2,9) },
                new Condutores {ID=4, Nome=" Rosa Fernandes", BI="728246437", Telemovel="913055221", DataNascimento=new DateTime(1977,9,24), NumCartaConducao="SA-89573", LocalEmissao="Santarém", DataValidadeCarta=new DateTime(2027,9,6) },
                new Condutores {ID=5, Nome=" Carolina Oliveira", BI="858156342", Telemovel="938070118", DataNascimento=new DateTime(1953,8,17), NumCartaConducao="AC-738163", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2022,8,1) },
                new Condutores {ID=6, Nome=" César Sousa", BI="507261086", Telemovel="916118589", DataNascimento=new DateTime(1964,8,22), NumCartaConducao="FA-321287", LocalEmissao="Faro", DataValidadeCarta=new DateTime(2027,1,26) },
                new Condutores {ID=7, Nome=" Maria Teixeira", BI="618881552", Telemovel="913789865", DataNascimento=new DateTime(1956,3,23), NumCartaConducao="BE-782268", LocalEmissao="Beja", DataValidadeCarta=new DateTime(2025,3,11) },
                new Condutores {ID=8, Nome=" Maria Melo", BI="819229141", Telemovel="939473033", DataNascimento=new DateTime(1955,11,21), NumCartaConducao="EV-409189", LocalEmissao="Évora", DataValidadeCarta=new DateTime(2026,6,15) },
                new Condutores {ID=9, Nome=" Francisco Vieira", BI="468921645", Telemovel="933935364", DataNascimento=new DateTime(1965,8,12), NumCartaConducao="PO-26600", LocalEmissao="Porto", DataValidadeCarta=new DateTime(2021,11,2) },
                new Condutores {ID=10, Nome=" Leonardo Marques", BI="110562475", Telemovel="919566682", DataNascimento=new DateTime(1937,8,19), NumCartaConducao="AC-488808", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2021,11,13) },
                new Condutores {ID=11, Nome=" Fábio Carvalho", BI="241857636", Telemovel="929532699", DataNascimento=new DateTime(1977,4,6), NumCartaConducao="EV-196487", LocalEmissao="Évora", DataValidadeCarta=new DateTime(2026,10,10) },
                new Condutores {ID=12, Nome=" Tiago Vieira", BI="192262426", Telemovel="923560516", DataNascimento=new DateTime(1945,10,4), NumCartaConducao="EV-115244", LocalEmissao="Évora", DataValidadeCarta=new DateTime(2019,3,20) },
                new Condutores {ID=13, Nome=" Rosana Soares", BI="233334917", Telemovel="921904819", DataNascimento=new DateTime(1951,4,4), NumCartaConducao="EV-257116", LocalEmissao="Évora", DataValidadeCarta=new DateTime(2019,10,11) },
                new Condutores {ID=14, Nome=" Rui Freitas", BI="251617767", Telemovel="928275227", DataNascimento=new DateTime(1985,4,25), NumCartaConducao="PO-611668", LocalEmissao="Porto", DataValidadeCarta=new DateTime(2027,1,3) },
                new Condutores {ID=15, Nome=" César Soares", BI="151965324", Telemovel="926122269", DataNascimento=new DateTime(1961,12,4), NumCartaConducao="VI-815500", LocalEmissao="Viseu", DataValidadeCarta=new DateTime(2030,11,2) },
                new Condutores {ID=16, Nome=" Márcio Sousa", BI="74975648", Telemovel="920273918", DataNascimento=new DateTime(1971,6,12), NumCartaConducao="AC-680776", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2019,6,4) },
                new Condutores {ID=17, Nome=" Eduardo Vieira", BI="254872277", Telemovel="911426580", DataNascimento=new DateTime(1973,11,19), NumCartaConducao="FA-812863", LocalEmissao="Faro", DataValidadeCarta=new DateTime(2025,5,24) },
                new Condutores {ID=18, Nome=" Adriana Oliveira", BI="686190303", Telemovel="928341652", DataNascimento=new DateTime(1950,9,16), NumCartaConducao="BE-100918", LocalEmissao="Beja", DataValidadeCarta=new DateTime(2030,9,25) },
                new Condutores {ID=19, Nome=" Beatriz Soares", BI="163679850", Telemovel="919470029", DataNascimento=new DateTime(1985,1,6), NumCartaConducao="AC-374173", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2029,1,13) },
                new Condutores {ID=20, Nome=" Adriana Sousa", BI="845941950", Telemovel="927173964", DataNascimento=new DateTime(1957,6,20), NumCartaConducao="MA-107861", LocalEmissao="Madeira", DataValidadeCarta=new DateTime(2025,6,14) },
                new Condutores {ID=21, Nome=" Patrícia Gonçalves", BI="185717766", Telemovel="914848986", DataNascimento=new DateTime(1934,4,20), NumCartaConducao="MA-949155", LocalEmissao="Madeira", DataValidadeCarta=new DateTime(2023,2,3) },
                new Condutores {ID=22, Nome=" Paula Martins", BI="782184726", Telemovel="920456771", DataNascimento=new DateTime(1984,11,6), NumCartaConducao="BE-743939", LocalEmissao="Beja", DataValidadeCarta=new DateTime(2028,11,23) },
                new Condutores {ID=23, Nome=" Andreia Vieira", BI="994307613", Telemovel="927778208", DataNascimento=new DateTime(1967,10,25), NumCartaConducao="FA-165555", LocalEmissao="Faro", DataValidadeCarta=new DateTime(2027,3,28) },
                new Condutores {ID=24, Nome=" Elisabete Morais", BI="270424301", Telemovel="929350747", DataNascimento=new DateTime(1933,7,26), NumCartaConducao="FA-583994", LocalEmissao="Faro", DataValidadeCarta=new DateTime(2029,11,8) },
                new Condutores {ID=25, Nome=" Marlene Melo", BI="270120676", Telemovel="927108995", DataNascimento=new DateTime(1937,7,14), NumCartaConducao="FA-751427", LocalEmissao="Faro", DataValidadeCarta=new DateTime(2029,4,6) },
                new Condutores {ID=26, Nome=" Marlene Pinto", BI="751512767", Telemovel="915698893", DataNascimento=new DateTime(1942,2,20), NumCartaConducao="LX-963025", LocalEmissao="Lisboa", DataValidadeCarta=new DateTime(2021,12,20) },
                new Condutores {ID=27, Nome=" Luís Lopes", BI="497555127", Telemovel="912266256", DataNascimento=new DateTime(1967,3,15), NumCartaConducao="MA-512423", LocalEmissao="Madeira", DataValidadeCarta=new DateTime(2029,11,7) },
                new Condutores {ID=28, Nome=" Denise Vieira", BI="264427182", Telemovel="923857727", DataNascimento=new DateTime(1977,5,28), NumCartaConducao="PO-887507", LocalEmissao="Porto", DataValidadeCarta=new DateTime(2029,8,2) },
                new Condutores {ID=29, Nome=" Cristina Rosa", BI="461453252", Telemovel="938685713", DataNascimento=new DateTime(1960,10,19), NumCartaConducao="MA-257694", LocalEmissao="Madeira", DataValidadeCarta=new DateTime(2030,9,11) },
                new Condutores {ID=30, Nome=" Carmem Lopes", BI="91728054", Telemovel="913797694", DataNascimento=new DateTime(1942,5,3), NumCartaConducao="SA-324795", LocalEmissao="Santarém", DataValidadeCarta=new DateTime(2025,6,12) },
                new Condutores {ID=31, Nome=" Rosana Carvalho", BI="279887145", Telemovel="933692261", DataNascimento=new DateTime(1956,6,9), NumCartaConducao="LX-182393", LocalEmissao="Lisboa", DataValidadeCarta=new DateTime(2026,8,25) },
                new Condutores {ID=32, Nome=" Paula Silva", BI="372845332", Telemovel="917633750", DataNascimento=new DateTime(1972,5,27), NumCartaConducao="VI-966301", LocalEmissao="Viseu", DataValidadeCarta=new DateTime(2029,4,9) },
                new Condutores {ID=33, Nome=" Mara Vieira", BI="682215833", Telemovel="910890721", DataNascimento=new DateTime(1976,7,3), NumCartaConducao="LX-753375", LocalEmissao="Lisboa", DataValidadeCarta=new DateTime(2026,2,27) },
                new Condutores {ID=34, Nome=" Adão Pinto", BI="263833191", Telemovel="919161492", DataNascimento=new DateTime(1933,9,28), NumCartaConducao="AC-380383", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2024,3,5) },
                new Condutores {ID=35, Nome=" Daniel Rodrigues", BI="785025953", Telemovel="931603084", DataNascimento=new DateTime(1940,2,16), NumCartaConducao="BE-173356", LocalEmissao="Beja", DataValidadeCarta=new DateTime(2022,6,2) },
                new Condutores {ID=36, Nome=" Sandra Rodrigues", BI="639730253", Telemovel="913795825", DataNascimento=new DateTime(1932,7,25), NumCartaConducao="AC-232544", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2022,11,13) },
                new Condutores {ID=37, Nome=" Cláudio Vieira", BI="556447530", Telemovel="916327284", DataNascimento=new DateTime(1982,4,2), NumCartaConducao="AC-488152", LocalEmissao="Açores", DataValidadeCarta=new DateTime(2029,8,25) }
            };
            condutores.ForEach(cc => context.Condutores.AddOrUpdate(c => c.Nome, cc));
            context.SaveChanges();


            //*********************************************************************
            // adiciona MULTAS
            var multas = new List<Multas> {
                new Multas {ID=7, LocalDaMulta="Abrantes", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,3,9), ViaturaFK=10, CondutorFK=17, AgenteFK=1 },
                new Multas {ID=23, LocalDaMulta="Abrantes", Infracao="Cond. sob influ. álcool (mais de 1,8)", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,8,9), ViaturaFK=15, CondutorFK=23, AgenteFK=1 },
                new Multas {ID=26, LocalDaMulta="Abrantes", Infracao="Cond. sob influ. álcool (mais de 1,8)", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,8,18), ViaturaFK=17, CondutorFK=6, AgenteFK=1 },
                new Multas {ID=64, LocalDaMulta="Abrantes", Infracao="Circular em sentido contrário", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,3,24), ViaturaFK=5, CondutorFK=16, AgenteFK=1 },
                new Multas {ID=14, LocalDaMulta="Tomar", Infracao="Cond. sob influ. álcool (de 0,5 a 1,2)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,2,12), ViaturaFK=9, CondutorFK=15, AgenteFK=2 },
                new Multas {ID=20, LocalDaMulta="Tomar", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,4,27), ViaturaFK=11, CondutorFK=29, AgenteFK=2 },
                new Multas {ID=46, LocalDaMulta="Tomar", Infracao="Cond. sob influ. álcool (mais de 1,8)", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,5,3), ViaturaFK=9, CondutorFK=22, AgenteFK=2 },
                new Multas {ID=65, LocalDaMulta="Tomar", Infracao="Inverter marcha em Autoestrada", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,3,18), ViaturaFK=6, CondutorFK=25, AgenteFK=2 },
                new Multas {ID=67, LocalDaMulta="Tomar", Infracao="Excesso de velocidade (<20 Km)", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,20), ViaturaFK=19, CondutorFK=2, AgenteFK=2 },
                new Multas {ID=113, LocalDaMulta="Tomar", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,8,27), ViaturaFK=6, CondutorFK=22, AgenteFK=2 },
                new Multas {ID=52, LocalDaMulta="Leiria", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,8,16), ViaturaFK=18, CondutorFK=2, AgenteFK=3 },
                new Multas {ID=61, LocalDaMulta="Leiria", Infracao="Não respeitar prioridade", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,1,19), ViaturaFK=13, CondutorFK=13, AgenteFK=3 },
                new Multas {ID=77, LocalDaMulta="Leiria", Infracao="Excesso de ocupantes", ValorMulta=200.00M, DataDaMulta=new DateTime(2017,5,6), ViaturaFK=11, CondutorFK=10, AgenteFK=3 },
                new Multas {ID=109, LocalDaMulta="Leiria", Infracao="Inverter marcha em Autoestrada", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,6,15), ViaturaFK=16, CondutorFK=23, AgenteFK=3 },
                new Multas {ID=4, LocalDaMulta="Lisboa", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,9,15), ViaturaFK=11, CondutorFK=17, AgenteFK=4 },
                new Multas {ID=15, LocalDaMulta="Lisboa", Infracao="Inverter marcha em Autoestrada", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,8,12), ViaturaFK=18, CondutorFK=5, AgenteFK=4 },
                new Multas {ID=19, LocalDaMulta="Lisboa", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,2,7), ViaturaFK=18, CondutorFK=18, AgenteFK=4 },
                new Multas {ID=28, LocalDaMulta="Lisboa", Infracao="Estacionamento em cima do passeio", ValorMulta=30.00M, DataDaMulta=new DateTime(2017,7,9), ViaturaFK=3, CondutorFK=3, AgenteFK=4 },
                new Multas {ID=36, LocalDaMulta="Lisboa", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,5,7), ViaturaFK=17, CondutorFK=17, AgenteFK=4 },
                new Multas {ID=45, LocalDaMulta="Lisboa", Infracao="Cond. sob influ. álcool (de 0,5 a 1,2)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,26), ViaturaFK=18, CondutorFK=14, AgenteFK=4 },
                new Multas {ID=92, LocalDaMulta="Lisboa", Infracao="Não parar em sinal STOP", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,22), ViaturaFK=16, CondutorFK=6, AgenteFK=4 },
                new Multas {ID=12, LocalDaMulta="Alcanena", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,3,24), ViaturaFK=6, CondutorFK=19, AgenteFK=5 },
                new Multas {ID=31, LocalDaMulta="Alcanena", Infracao="Excesso de velocidade (<20 Km)", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,4,16), ViaturaFK=11, CondutorFK=1, AgenteFK=5 },
                new Multas {ID=44, LocalDaMulta="Alcanena", Infracao="Excesso de velocidade (<20 Km)", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,9,15), ViaturaFK=19, CondutorFK=17, AgenteFK=5 },
                new Multas {ID=47, LocalDaMulta="Alcanena", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,13), ViaturaFK=9, CondutorFK=28, AgenteFK=5 },
                new Multas {ID=55, LocalDaMulta="Alcanena", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,2), ViaturaFK=11, CondutorFK=21, AgenteFK=5 },
                new Multas {ID=72, LocalDaMulta="Alcanena", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,17), ViaturaFK=1, CondutorFK=7, AgenteFK=5 },
                new Multas {ID=90, LocalDaMulta="Alcanena", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,21), ViaturaFK=4, CondutorFK=29, AgenteFK=5 },
                new Multas {ID=105, LocalDaMulta="Alcanena", Infracao="Circular com pneus inválidos", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,4,16), ViaturaFK=6, CondutorFK=11, AgenteFK=5 },
                new Multas {ID=5, LocalDaMulta="Leiria", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,22), ViaturaFK=11, CondutorFK=13, AgenteFK=6 },
                new Multas {ID=6, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (> 40 Km)", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,8,2), ViaturaFK=16, CondutorFK=5, AgenteFK=6 },
                new Multas {ID=43, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (<20 Km)", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,5), ViaturaFK=2, CondutorFK=6, AgenteFK=6 },
                new Multas {ID=48, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (> 40 Km)", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,6,20), ViaturaFK=3, CondutorFK=12, AgenteFK=6 },
                new Multas {ID=50, LocalDaMulta="Leiria", Infracao="Circular com pneus inválidos", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,1,6), ViaturaFK=16, CondutorFK=15, AgenteFK=6 },
                new Multas {ID=53, LocalDaMulta="Leiria", Infracao="Estacionamento em cima do passeio", ValorMulta=30.00M, DataDaMulta=new DateTime(2017,4,7), ViaturaFK=15, CondutorFK=16, AgenteFK=6 },
                new Multas {ID=54, LocalDaMulta="Leiria", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,8,21), ViaturaFK=11, CondutorFK=4, AgenteFK=6 },
                new Multas {ID=66, LocalDaMulta="Leiria", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,6,28), ViaturaFK=10, CondutorFK=3, AgenteFK=6 },
                new Multas {ID=70, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,14), ViaturaFK=18, CondutorFK=26, AgenteFK=6 },
                new Multas {ID=80, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,1,16), ViaturaFK=1, CondutorFK=27, AgenteFK=6 },
                new Multas {ID=81, LocalDaMulta="Leiria", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,9,22), ViaturaFK=19, CondutorFK=18, AgenteFK=6 },
                new Multas {ID=85, LocalDaMulta="Leiria", Infracao="Não respeitar prioridade", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,27), ViaturaFK=17, CondutorFK=10, AgenteFK=6 },
                new Multas {ID=1, LocalDaMulta="Leiria", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,2,4), ViaturaFK=14, CondutorFK=8, AgenteFK=7 },
                new Multas {ID=25, LocalDaMulta="Leiria", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,6,21), ViaturaFK=6, CondutorFK=11, AgenteFK=7 },
                new Multas {ID=34, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,4,10), ViaturaFK=8, CondutorFK=11, AgenteFK=7 },
                new Multas {ID=40, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (<20 Km)", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,8,24), ViaturaFK=14, CondutorFK=17, AgenteFK=7 },
                new Multas {ID=83, LocalDaMulta="Leiria", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,5,15), ViaturaFK=8, CondutorFK=13, AgenteFK=7 },
                new Multas {ID=106, LocalDaMulta="Leiria", Infracao="Uso incorrecto de luzes", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,8,21), ViaturaFK=16, CondutorFK=15, AgenteFK=7 },
                new Multas {ID=17, LocalDaMulta="Lisboa", Infracao="Excesso de velocidade (> 40 Km)", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,4,10), ViaturaFK=13, CondutorFK=28, AgenteFK=8 },
                new Multas {ID=29, LocalDaMulta="Lisboa", Infracao="Circular com pneus inválidos", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,23), ViaturaFK=19, CondutorFK=10, AgenteFK=8 },
                new Multas {ID=63, LocalDaMulta="Lisboa", Infracao="Circular em sentido contrário", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,8,26), ViaturaFK=10, CondutorFK=24, AgenteFK=8 },
                new Multas {ID=68, LocalDaMulta="Lisboa", Infracao="Não respeitar prioridade", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,24), ViaturaFK=14, CondutorFK=13, AgenteFK=8 },
                new Multas {ID=82, LocalDaMulta="Lisboa", Infracao="Não parar em sinal STOP", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,7), ViaturaFK=8, CondutorFK=11, AgenteFK=8 },
                new Multas {ID=89, LocalDaMulta="Lisboa", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,4,10), ViaturaFK=19, CondutorFK=19, AgenteFK=8 },
                new Multas {ID=95, LocalDaMulta="Lisboa", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,7,16), ViaturaFK=10, CondutorFK=8, AgenteFK=8 },
                new Multas {ID=96, LocalDaMulta="Lisboa", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,3,23), ViaturaFK=8, CondutorFK=22, AgenteFK=8 },
                new Multas {ID=9, LocalDaMulta="Alcanena", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,18), ViaturaFK=5, CondutorFK=6, AgenteFK=9 },
                new Multas {ID=21, LocalDaMulta="Alcanena", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,8,14), ViaturaFK=7, CondutorFK=8, AgenteFK=9 },
                new Multas {ID=73, LocalDaMulta="Alcanena", Infracao="Cond. sob influ. álcool (de 0,5 a 1,2)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,5), ViaturaFK=19, CondutorFK=6, AgenteFK=9 },
                new Multas {ID=74, LocalDaMulta="Alcanena", Infracao="Cond. sob influ. álcool (mais de 1,8)", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,2,25), ViaturaFK=19, CondutorFK=22, AgenteFK=9 },
                new Multas {ID=99, LocalDaMulta="Alcanena", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,8), ViaturaFK=18, CondutorFK=11, AgenteFK=9 },
                new Multas {ID=102, LocalDaMulta="Alcanena", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,3,25), ViaturaFK=13, CondutorFK=21, AgenteFK=9 },
                new Multas {ID=3, LocalDaMulta="Lisboa", Infracao="Circular em sentido contrário", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,8,3), ViaturaFK=18, CondutorFK=3, AgenteFK=10 },
                new Multas {ID=13, LocalDaMulta="Lisboa", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,1,9), ViaturaFK=5, CondutorFK=17, AgenteFK=10 },
                new Multas {ID=32, LocalDaMulta="Lisboa", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,20), ViaturaFK=12, CondutorFK=17, AgenteFK=10 },
                new Multas {ID=41, LocalDaMulta="Lisboa", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,5,13), ViaturaFK=1, CondutorFK=25, AgenteFK=10 },
                new Multas {ID=42, LocalDaMulta="Lisboa", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,6,1), ViaturaFK=19, CondutorFK=14, AgenteFK=10 },
                new Multas {ID=56, LocalDaMulta="Lisboa", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,3,5), ViaturaFK=17, CondutorFK=5, AgenteFK=10 },
                new Multas {ID=11, LocalDaMulta="Porto", Infracao="Uso incorrecto de luzes", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,8,14), ViaturaFK=6, CondutorFK=13, AgenteFK=4 },
                new Multas {ID=18, LocalDaMulta="Porto", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,1,5), ViaturaFK=4, CondutorFK=7, AgenteFK=4 },
                new Multas {ID=38, LocalDaMulta="Porto", Infracao="Uso incorrecto de luzes", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,7,9), ViaturaFK=9, CondutorFK=30, AgenteFK=4 },
                new Multas {ID=51, LocalDaMulta="Porto", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,2,28), ViaturaFK=7, CondutorFK=19, AgenteFK=4 },
                new Multas {ID=76, LocalDaMulta="Porto", Infracao="Estacionamento em 2a. fila", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,2,10), ViaturaFK=15, CondutorFK=4, AgenteFK=4 },
                new Multas {ID=108, LocalDaMulta="Porto", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,2), ViaturaFK=11, CondutorFK=20, AgenteFK=4 },
                new Multas {ID=62, LocalDaMulta="Ourém", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,5,12), ViaturaFK=10, CondutorFK=26, AgenteFK=6 },
                new Multas {ID=86, LocalDaMulta="Ourém", Infracao="Cond. sob influ. álcool (de 0,5 a 1,2)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,2,13), ViaturaFK=2, CondutorFK=7, AgenteFK=6 },
                new Multas {ID=33, LocalDaMulta="Ourém", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,8,9), ViaturaFK=7, CondutorFK=7, AgenteFK=7 },
                new Multas {ID=60, LocalDaMulta="Ourém", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,4,28), ViaturaFK=13, CondutorFK=13, AgenteFK=7 },
                new Multas {ID=79, LocalDaMulta="Ourém", Infracao="Cond. sob influ. álcool (de 0,5 a 1,2)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,8), ViaturaFK=15, CondutorFK=3, AgenteFK=7 },
                new Multas {ID=84, LocalDaMulta="Ourém", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,9,20), ViaturaFK=4, CondutorFK=7, AgenteFK=7 },
                new Multas {ID=87, LocalDaMulta="Ourém", Infracao="Cond. sob influ. álcool (mais de 1,8)", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,5,15), ViaturaFK=12, CondutorFK=22, AgenteFK=7 },
                new Multas {ID=91, LocalDaMulta="Ourém", Infracao="Excesso de velocidade (> 40 Km)", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,4,28), ViaturaFK=7, CondutorFK=27, AgenteFK=7 },
                new Multas {ID=94, LocalDaMulta="Ourém", Infracao="Uso incorrecto de luzes", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,5), ViaturaFK=5, CondutorFK=4, AgenteFK=7 },
                new Multas {ID=100, LocalDaMulta="Ourém", Infracao="Circular com pneus inválidos", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,9,23), ViaturaFK=17, CondutorFK=13, AgenteFK=7 },
                new Multas {ID=107, LocalDaMulta="Ourém", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,4,9), ViaturaFK=11, CondutorFK=3, AgenteFK=7 },
                new Multas {ID=112, LocalDaMulta="Ourém", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,4,18), ViaturaFK=11, CondutorFK=6, AgenteFK=7 },
                new Multas {ID=27, LocalDaMulta="Torres Novas", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,3,21), ViaturaFK=15, CondutorFK=15, AgenteFK=7 },
                new Multas {ID=111, LocalDaMulta="Torres Novas", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,8,22), ViaturaFK=3, CondutorFK=7, AgenteFK=7 },
                new Multas {ID=30, LocalDaMulta="Torres Novas", Infracao="Excesso de velocidade (> 40 Km)", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,6,23), ViaturaFK=4, CondutorFK=16, AgenteFK=10 },
                new Multas {ID=75, LocalDaMulta="Torres Novas", Infracao="Cond. sob influ. álcool (mais de 1,8)", ValorMulta=500.00M, DataDaMulta=new DateTime(2017,5,20), ViaturaFK=8, CondutorFK=20, AgenteFK=10 },
                new Multas {ID=2, LocalDaMulta="Torres Novas", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,7,1), ViaturaFK=6, CondutorFK=26, AgenteFK=9 },
                new Multas {ID=8, LocalDaMulta="Torres Novas", Infracao="Uso incorrecto de luzes", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,6,9), ViaturaFK=5, CondutorFK=3, AgenteFK=5 },
                new Multas {ID=57, LocalDaMulta="Torres Novas", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,4,28), ViaturaFK=1, CondutorFK=15, AgenteFK=9 },
                new Multas {ID=59, LocalDaMulta="Torres Novas", Infracao="Uso incorrecto de luzes", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,4,2), ViaturaFK=10, CondutorFK=24, AgenteFK=5 },
                new Multas {ID=71, LocalDaMulta="Torres Novas", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,8,4), ViaturaFK=9, CondutorFK=19, AgenteFK=9 },
                new Multas {ID=101, LocalDaMulta="Torres Novas", Infracao="Excesso de velocidade (<20 Km)", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,7,16), ViaturaFK=8, CondutorFK=18, AgenteFK=5 },
                new Multas {ID=110, LocalDaMulta="Torres Novas", Infracao="Não parar em semáforo Vermelho", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,5,25), ViaturaFK=3, CondutorFK=27, AgenteFK=9 },
                new Multas {ID=114, LocalDaMulta="Torres Novas", Infracao="Não parar em semáforo Vermelho", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,3,8), ViaturaFK=14, CondutorFK=28, AgenteFK=5 },
                new Multas {ID=16, LocalDaMulta="Lisboa", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,9,13), ViaturaFK=6, CondutorFK=15, AgenteFK=3 },
                new Multas {ID=24, LocalDaMulta="Lisboa", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,8,15), ViaturaFK=19, CondutorFK=28, AgenteFK=3 },
                new Multas {ID=58, LocalDaMulta="Lisboa", Infracao="Não parar em semáforo Vermelho", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,3,28), ViaturaFK=6, CondutorFK=20, AgenteFK=3 },
                new Multas {ID=69, LocalDaMulta="Lisboa", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,9,25), ViaturaFK=5, CondutorFK=14, AgenteFK=3 },
                new Multas {ID=88, LocalDaMulta="Lisboa", Infracao="Utilizar telemóvel em condução", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,6,1), ViaturaFK=1, CondutorFK=6, AgenteFK=3 },
                new Multas {ID=93, LocalDaMulta="Lisboa", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,1,14), ViaturaFK=14, CondutorFK=30, AgenteFK=3 },
                new Multas {ID=98, LocalDaMulta="Lisboa", Infracao="Não parar na Passadeira de Peões", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,8,24), ViaturaFK=8, CondutorFK=23, AgenteFK=3 },
                new Multas {ID=104, LocalDaMulta="Lisboa", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,5,18), ViaturaFK=19, CondutorFK=17, AgenteFK=3 },
                new Multas {ID=22, LocalDaMulta="Leiria", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,5,1), ViaturaFK=15, CondutorFK=3, AgenteFK=8 },
                new Multas {ID=35, LocalDaMulta="Leiria", Infracao="Excesso de velocidade (>20 Km e < 40 Km)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,5,17), ViaturaFK=10, CondutorFK=26, AgenteFK=8 },
                new Multas {ID=37, LocalDaMulta="Leiria", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,3,3), ViaturaFK=2, CondutorFK=17, AgenteFK=8 },
                new Multas {ID=39, LocalDaMulta="Leiria", Infracao="Cond. sob influ. álcool (de 1,2 a 1,8)", ValorMulta=2500.00M, DataDaMulta=new DateTime(2017,9,19), ViaturaFK=8, CondutorFK=11, AgenteFK=8 },
                new Multas {ID=49, LocalDaMulta="Leiria", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,9,17), ViaturaFK=5, CondutorFK=22, AgenteFK=8 },
                new Multas {ID=78, LocalDaMulta="Leiria", Infracao="Cond. sob influ. álcool (de 0,5 a 1,2)", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,3,13), ViaturaFK=5, CondutorFK=14, AgenteFK=8 },
                new Multas {ID=10, LocalDaMulta="Santarém", Infracao="Pisar traço contínuo", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,2,18), ViaturaFK=11, CondutorFK=19, AgenteFK=8 },
                new Multas {ID=103, LocalDaMulta="Santarém", Infracao="Excesso de velocidade (> 40 Km)", ValorMulta=250.00M, DataDaMulta=new DateTime(2017,8,28), ViaturaFK=12, CondutorFK=5, AgenteFK=8 },
                new Multas {ID=97, LocalDaMulta="Tomar", Infracao="Desrespeito da obrigação de parar", ValorMulta=100.00M, DataDaMulta=new DateTime(2017,7,8), ViaturaFK=6, CondutorFK=26, AgenteFK=6 },
                new Multas {ID=115, LocalDaMulta="Tomar", Infracao="Não respeitar prioridade", ValorMulta=50.00M, DataDaMulta=new DateTime(2017,8,4), ViaturaFK=3, CondutorFK=4, AgenteFK=6 }
            };
            multas.ForEach(mm => context.Multas.AddOrUpdate(m => m.ID, mm));
            context.SaveChanges();



        }
    }
}
