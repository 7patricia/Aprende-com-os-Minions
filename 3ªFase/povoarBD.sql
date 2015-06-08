use minions;
/*Aulas-Primetro*/
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Perimetros',1,'Perimetro 1','\images\aula - perimetro - grau1.png','\images\aula_perimetro_grau_1');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Perimetros',2,'Perimetro 2','\images\aula - perimetro - grau2.png','\images\aula_perimetro_grau_2');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Perimetros',3,'Perimetro 3','\images\aula - perimetro - grau3.png','\images\aula_perimetro_grau_3');

/*Aulas-Area*/
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Areas',1,'Area 1','\images\aula - area - grau1.png','\images\aula_areas_grau_1');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Areas',2,'Area 2','\images\aula - area - grau2.png','\images\aula_areas_grau_2');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Areas',3,'Area 3','\images\aula - area - grau3.png','\images\aula_areas_grau_3');

/*Aula-MedidasComprimento*/

insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Medidas',1,'Medidas de Comprimento 1','\images\aula - transformacoes - grau1.png','\images\aula_transformacoes_comprimento');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Medidas',2,'Medidas de Comprimento 2','\images\aula - transformacoes - grau2.png','\images\aula_transformacoes_areas');

/*Exercicios */
insert into Exercicios(GrauDif,Tema,URLImagem,DuvidaURL) values (1,'Perimetros','\images\Ex_Permitero_grau1.png','\images\exercicio_perimetro_grau_1');
insert into Exercicios(GrauDif,Tema,URLImagem,DuvidaURL) values (2,'Perimetros','\images\Ex_Permitero_grau2.png','\images\exercicio_perimetro_grau_2');
insert into Exercicios(GrauDif,Tema,URLImagem,DuvidaURL) values (3,'Perimetros','\imagesEx_Permitero_grau3.png','\images\exercicio_perimetro_grau_3');
insert into Exercicios(GrauDif,Tema,URLImagem,DuvidaURL) values (1,'Areas','\images\Ex_Aula_grau1.png','\images\exercicios_areas_grau_1');
insert into Exercicios(GrauDif,Tema,URLImagem,DuvidaURL) values (2,'Areas','\images\Ex_Aula_grau2.png','\images\exercicios_areas_grau_2');
insert into Exercicios(GrauDif,Tema,URLImagem,DuvidaURL) values (3,'Areas','\images\Ex_Aula_grau3.png','\images\exercicios_areas_grau_3');
insert into Exercicios(GrauDif,Tema,URLImagem) values (1,'Medidas','\images\Ex_Transf_grau1');
insert into Exercicios(GrauDif,Tema,URLImagem) values (2,'Medidas','\images\Ex_Transf_grau2');

/*Testes*/
insert into Testes(GrauDif,Tema,URL) values (1,'Perimetros','\images\Teste_Permitero_grau1');
insert into Testes(GrauDif,Tema,URL) values (2,'Perimetros','\images\Teste_Permitero_grau2');
insert into Testes(GrauDif,Tema,URL) values (3,'Perimetros','\images\Teste_Permitero_grau3');
insert into Testes(GrauDif,Tema,URL) values (1,'Areas','\images\Teste_Area_grau1');
insert into Testes(GrauDif,Tema,URL) values (2,'Areas','\images\Teste_Area_grau2');
insert into Testes(GrauDif,Tema,URL) values (3,'Areas','\images\Teste_Area_grau3');
insert into Testes(GrauDif,Tema,URL) values (1,'Medidas','\images\Teste_Transf_grau1');
insert into Testes(GrauDif,Tema,URL) values (2,'Medidas','\images\Teste_Transf_grau2');
insert into Testes(GrauDif,Tema,URL) values (3,'Medidas','\images\Teste_Transf_grau3')

/*Perguntas*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Considere este triângulo com 3 lados iguais (equilátero), sendo x = 3 cm. Qual o valor do perímetro?. Descobre a opção correta e assinala a verdadeira:','\images\perimetro','9 cm',1);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro do retângulo, sendo y = 5 cm e x = 4 cm.','\images\Ex_Permitero_grau1','18 cm',1);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Calcule o perímetro do círculo, com raio, x = 1 cm.','\images\Ex_Aula_grau3','2π cm',1);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro da figura. Tem atenção, que é um triângulo isósceles, com x = 5 cm e y = 3 cm.','\images\Ex_Permitero_grau2','13 cm',2);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro, sendo x = 5 cm e y = 3 cm.','\images\perimetro4','16 cm',2);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro, sendo x = 1 dm','\images\Ex_Aula_grau3','2π dm',2);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O Sr. Barroso quer vedar uma porção de terreno para atividades das festas da vila. Quantos metros de rede tem de comprar o Sr. Barroso?','\images\areaTeste4','30 m',3);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O filho do Sr. Barroso quer construir uma casa no terreno que está a branco, descobre o perímetro do terreno a cinzento.','\images\areaTeste4a','10 m',3);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O filho do Sr. Barroso precisava de saber o perímetro do terreno que vai ser usado para a casa, para mandar vedar por causa dos animais selvagens. Calcula o perímetro so quadrado branco.','\images\areaTeste4','20 m',3);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Qual das figuras tem exatamente 28 m2?','\images\areaTeste1','A',4);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área deste pequeno retângulo, sendo y = 5 cm e x = 3 cm.','\images\area1','15 cm2',4);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área deste triângulo, sendo x = 3 cm e h = 4 cm.','\images\perimetro','6 cm2',4);


insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área do triângulo, sendo x = 2 cm e h = 1 dm.','\images\perimetro','20 cm2',5);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área da circunferência, com raio = 2 cm.','\images\Ex_Aula_grau3','4π cm2',5);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Será que serás capaz de descobrir qual destas 3 figuras têm a maior área?','\images\areas2','B',5);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O Sr. Pinto da Costa decidiu que a relva dos campos da academia do clube estavam a precisar de ser renovados, para isso ele tem de saber exatamente a área. Será que és tu que o vais ajudar? Que valor obtiveste como resultado?','\images\Ex_Aula_grau3','1200 m2',6);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('A empresa do Sr. Pinto quer comprar a relva para colocar no campo. Calcula a área em dam2','\images\Ex_Aula_grau3','12 dam2',6);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('se o Sr. Pinto não tiver verbas, e quiser mudar a relva só a um campo, qual será a sua área?','\images\Ex_Aula_grau3','600 m2',6);

insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Estás a ver o comprimento do carro? Descobre o comprimento em metros.','\images\Ex_Transf_grau1','3.88 m',7);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Aqui temos uma torre bastante conhecida, será que podias ajudar o João a transformar a altura de metros para decâmetros?','\images\Transf1','32.4 dam',7);


insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O prof. Manuel comprou um móvel e quer pô-lo no seu gabinete, mas para isso precisa de saber se tem espaço para o pôr. O que ele sabe é que no seu gabinete tem 10 m2 livres e o móvel tem 100 dm2. Podes ajudar a fazer a transformação da área do móvel para m2, para ajudares o professor com a sua compra? ','\images\Ex_Transf_grau2','A',8);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Esta é a minha casa, podias - me dizer quantos cm2 tem a minha cozinha?','\images\Ex_Transf_grau2','87100 cm2',8);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Queria ver se tinha espaço para pôr 20 cartazes deste filme na parede do meu quarto. Sabendo que os 20 cartazes fazem uma área de 10000 cm2, e que a parede do meu quarto tem 500 dm2. Converte as duas medidas para m2, primeiro dos cartazes depois da parede, para me ajudares no meu problema.','\images\Transf3','1 m2 e 5 m2',8);
/*
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O Sr. Serafim está a fazer um estudo para descobrir qual o edifício que mais área ocupa na cidade de Lustosa. Para isso, teve que fazer um cálculo a todos os edifícios dessa cidade e foi filtrando até que ficou com 4 edifícios com uma área muita parecida. Visto que ele tem que apresentar este estudo ao município, e tem pouco tempo para o fazer, ele espera que o ajudes a dar a resposta correta.
Sempre consegues ajudar o Sr. Serafim?','https://flic.kr/p/tWVMKv','A',9);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Vimos pedir-te ajuda para o planeamento da cidade, transformando as medidas para m2, é só converter o edifício A e C:','https://flic.kr/p/tWVMKv','100m2 e 50m2',9);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Segundo ordens do presidente da câmara, será demolido um edifício para a construção de uma escola, é necessário 50 m2, indica o edifico com as medidas mais próximas:','https://flic.kr/p/tWVMKv','C',9);	
*/
/*Perguntas - Testes*/
/*Parimetro 1*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Descobre o perímetro do retângulo:','\images\perimetroTeste1','60 cm',1);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Descobre o perímetro desta figura:','\images\Teste_Perimetro_grau1','62 cm',1);	
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Descobre o perímetro da circunferência, com raio de 1 cm:','\images\Ex_Aula_grau3','2π cm',1);	

/*Parimetro 2*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Qual destas figuras tem um maior perímetro?','\images\exercicios_areas_grau_1','B',2);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Descobre o perímetro, com x = 600 mm, y = 7 dm, z = 8 cm:','\images\Teste_Permitero_grau2','138 cm',2);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('O Francisco gostaria saber o perímetro da sua casa, será que o podias ajudar?','\images\Teste_Area_grau2','19 m',2);	

/*Parimetro 3*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('O Sr. Zé Manel quer vedar os terrenos que tem, com rede ou com grades, mas isso tudo depende dos custos, para isso ele precisa da tua ajuda para calcular o perímetro dos 2 terrenos. Será que podes ajudar o Sr. Zé para ele fazer a sua opção, entre rede e grades?','\images\Teste_Permitero_grau3','34 m',3);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Calcula o perímetro do terreno de comprimento 6 m:','\images\Teste_Permitero_grau3','22 m',3);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('O Sr. Zé comprou mais um pouco de terreno, agora o terreno que tem de lado 4 m, passou a ter 5 com a nova compra. Descobre o perímetro total:','\images\Teste_Permitero_grau3','360 dm',3);

/*Area 1*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Qual a figura que tem 28 m2?','\images\perimetroTeste3','A',4);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Descobre a área, sendo x = 5 cm e h = 5cm.','\images\perimetro','12.5 cm2',4);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('O Sr. Manuel tem um Ferrari, e por curiosidade gostava de saber a área das rodas, tendo em atenção que o raio da roda é 10 cm. Podes matar a curiosidade ao Sr. Manuel?','\images\Teste_Area_grau1','20π cm2',4);

/*Area 2*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Vamos ver se sabes calcular a área deste retângulo: ','\images\areaTeste3','200 cm2',5);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Descobre qual a área da figura acima:','\images\Ex_Perimetro_grau3','38 m2',5);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Calcula a área da casa do Francisco, tendo o telhado 2 m de altura:','\images\areaTeste5','2500 dm2',5);

/*Area 3*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('O Sr. Pedro Duarte comprou um terreno em sociedade com o Sr. Miguel Pinto, a parte do Sr. Pedro é a parte retangular e a do Sr. Miguel é a triangular. Além de serem amigos, amigos negócios à parte, o Sr. Pedro decidiu vedar a sua parte do terreno, e decidiu pedir ajuda a um especialista sobre o assunto, foste o escolhido.','\images\Teste_Area_grau3','40 m2',6);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Visto que o terreno do Sr. Pedro estava vedado, uns vagabundos começaram a libertar lixo no terreno do Sr. Miguel, o que levou a vedar também, e precisará da tua ajuda:','\images\Teste_Area_grau3','80 m2',6);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('No mês passado saiu uma lei de planeamento de terrenos, e a câmara tem que renovar todos os terrenos do seu município. Por isso, agora até a câmara precisa da tua ajuda. Estarás pronto em dar a tua ajuda para um estudo tão importante?','\images\Teste_Area_grau3','120 m2',6);

/*Medidas 1*/
insert into Perguntas(Descricao, RespCerta,Teste_TesteID) values ('Da casa do Miguel à casa do João são 207 m, qual é a distância em cm?','20700 cm',7);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('O presidente do Valadares está a pensar fazer bancadas, mas precisa do perímetro do campo em dam, visto que o campo tem 123 m, qual o valor em dam?','\images\Teste_Transf_grau1','12.3 dam',7);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Este edifício encontra-se nos Estados Unidos, mais concretamente New York. Qual a sua altura em dm?','\images\TransfTeste2','3810 dm',7);

/*Medidas 2*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Aqui temos um exemplo de um autocarro da AAUM, a associação quer fazer uma garagem para os guardar, para não os deixar ao tempo, mas precisam do comprimento do autocarro em dm.','\images\Teste_Transf_grau2','120 dm',8);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Sabendo que o autocarro tem de área 48 m2, qual das garagens que servia de abrigo para o autocarro?','\images\Teste_Transf_grau2','4800 dm2',8);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Para o Enterro da Gata foi disponibilizado um parque com 1000m2, como o que vemos na figura, para calcular quantos autocarros podem estacionar nesse parque, a associação precisa que passes as medidas para hm2.','\images\TransfTeste4','0.1 hm2',8);

/*Medidas 3*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('Na freguesia de Gualtar querem construir um condomínio de luxo, na realização do projeto sabem que cada prédio tem 123.5 m2, mas o arquiteto precisa das medidas em dm2, para depois melhorar o projeto em função do terreno','\images\Teste_Transf_grau3','12350 dm2',9);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('A imobiliária que está a tratar de vender o terreno, infelizmente disponibilizou as medidas do terreno em dam2, o arquiteto precisa da tua ajuda para converteres para as mesmas unidades dos prédios, isto é, passar de dam2 para dm2.
Os dados que a imobiliária disponibilizou foi a área do terreno, 1.2 dam2.','\images\Teste_Transf_grau3','12000 dm2',9);
insert into Perguntas(Descricao, URLImagem, RespCerta,Teste_TesteID) values ('A imobiliária propôs uma outra hipótese de terrenho à beira mar, com uma área de 1 km2, visto que o sitio seria vantajoso para negócios futuros, o arquiteto para tentar enquadrar o projeto nesse terreno precisa da sua área em dam2, serás tu capaz de o ajudar?','\images\Teste_Transf_grau3','10000 dam2',9);	

/*Respostas*/

/*Perimetros 1*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('9 cm','7.5 cm','10 cm','5 cm',1);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('20 cm','10 cm','18 cm','9 cm',2);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('2π cm','2 cm','3.14π cm','π cm',3);
/*Perimetros 2 */
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('13 dm','15 cm','13 cm','13 m',4);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('16 mm','20 cm','15 dm','16 cm',5);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('2π dm','2π cm','2 dm','π cm',6);
/*Perimetros 3*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('30 m','20 m','25 m','26 m',7);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('80 dm','120 dm','120 cm','10 m',8);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('11 m','110 dm','20 m','22 dm',9);
/*Areas 1*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('A','B','C','D',10);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('8 cm2','16 cm2','10 cm2','15 cm2',11);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('12 cm2','9 cm2','6 cm2','16cm2',12);
/*Areas 2*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('20 cm2','20 dm2','10 dm2','10 cm2',13);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('2π cm2','4π dm2','4π cm2','2 cm2',14);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('A','B','C','D',15);
/*Areas 3*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('1200 m2','300 m2','600 m2','100m2',16);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('6 dam2','60 dam2','0.6 dam2','30 dam2',17);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('600 dm2','6000 cm2','600 m2','60 m2',18);
/*Medidas 1*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('180 m','1800 m','180 dm','1.8 m',19);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('38.8 m','388 m','3.88 m','3.88 dm',20);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('11 m','110 dm','20 m','22 dm',21);
/*Medidas 2*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('32.4 dm','324 dam','32.4 dam','3240 cm',22);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('10 m2','0.1 m2','10 m2','100 m2',23);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('8.71 cm2','871 cm2','8710 cm2','87100 cm2',24);
/*Medidas 3*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('A','B','C','D',25);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('100 m2 e 500 m2','10 m2 e 50m2','100m2 e 50m2','1 m2 e 5 m2',26);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('A','B','C','D',27);



/*Respostas - Testes*/

/*Perimetros 1*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('100 cm','200 cm','60 cm','80 cm',54);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('62 cm','60 cm','48 cm','54 cm',55);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('2π cm','1π cm','2 cm','1 cm',56);

/*Perimetros 2 */
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('A','B','C','D',57);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('138 cm','138 dm','100 cm','138 mm',58);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('64 m','64 dm','19 m','19 dm',59);

/*Perimetros 3*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('34 m','34 dm','34 mm','340 cm',60);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('12 m','20 m','24 m','22 m',61);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('34 dm','360 dm','340 m','340 cm',62);

/*Areas 1*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('A','B','C','D',63);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('12.5cm2','25 cm2','5 cm2','20 cm2',64);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('20π cm2','20π dm2','20 cm2','2π cm2',65);

/*Areas 2*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('200 cm2','200 dm2','20 dm2','2 m2',66);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('30 m2','8 m2','38 m2','380 dm2',67);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('25 m2','2500 dm2','250 m2','25 dm2',68);

/*Areas 3*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('10 m2','40 dm2','40 m2','400 cm2',69);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('200 m2','200 dm2','100 dm2','80 m2',70);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('120 m2','1200 dm2','12 m2','1200 cm2',71);

/*Medidas 1*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('20.7 cm','2070 cm','207 dm','20700 cm',72);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('123 dam','1230 dam','12.3 dam','1.23 dam',73);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('3810 dm','38.1 dm','38100 dm','381 dm',74);

/*Medidas 2*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('12 dm','120 dm','1.2 dm','1200 dm',75);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('47 m2','480 dm2','4800 dm2','4800 cm2',76);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('100 hm2','10 hm2','1 hm2','0.1 hm2',77);

/*Medidas 3*/
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('12350 dm2','1.235 dm2','1235 dm2','123.5 dm2',78);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('12 dm2','120 dm2','1200 dm2','12000 dm2',79);
insert into Respostas(RespA,RespB,RespC,RespD,Pergunta_PerguntaID)values ('100 dam2','10 dam2','1000 dam2','10000 dam2',80);


