use minions;
/*Aulas-Primetro*/
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Perimetros',1,'Perimetro 1','https://flic.kr/p/tWK4pC','https://youtu.be/_CJryeE0ZX0');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Perimetros',2,'Perimetro 2','https://flic.kr/p/thufQX','https://youtu.be/Q3eBfZKBqYs');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Perimetros',3,'Perimetro 3','https://flic.kr/p/tWTc8P','https://youtu.be/5IVm-Y5EqF4');

/*Aulas-Area*/
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Areas',1,'Area 1','https://flic.kr/p/thuh6H','https://youtu.be/EObGAJe2QOw');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Areas',2,'Area 2','https://flic.kr/p/thiX7w','https://youtu.be/loVU24nvc5o');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Areas',3,'Area 3','https://flic.kr/p/uevtAT','https://youtu.be/pKdAuCQiIQU');

/*Aula-MedidasComprimento*/

insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Medidas',1,'Medidas de Comprimento 1','https://flic.kr/p/thiW37','https://youtu.be/0HxYMq_dx0Q');
insert into Aulas(Tema,GrauDif,Titulo,URLImagem,URLVideo) values ('Medidas',2,'Medidas de Comprimento 2','https://flic.kr/p/uc1bjo','https://youtu.be/5wBpuwrxoGk');

/*Exercicios */
insert into Exercicios(GrauDif,Tema,URLImagem) values (1,'Perimetros','https://flic.kr/p/uc3GgU');
insert into Exercicios(GrauDif,Tema,URLImagem) values (2,'Perimetros','https://flic.kr/p/thmuhU');
insert into Exercicios(GrauDif,Tema,URLImagem) values (3,'Perimetros','https://flic.kr/p/thmuhU');
insert into Exercicios(GrauDif,Tema,URLImagem) values (1,'Areas','https://flic.kr/p/uc3GgU');
insert into Exercicios(GrauDif,Tema,URLImagem) values (2,'Areas','https://flic.kr/p/thnDDY');
insert into Exercicios(GrauDif,Tema,URLImagem) values (3,'Areas','https://flic.kr/p/tWVGHB');
insert into Exercicios(GrauDif,Tema,URLImagem) values (1,'Medidas','https://flic.kr/p/thwRrM');
insert into Exercicios(GrauDif,Tema,URLImagem) values (2,'Medidas','https://flic.kr/p/tWMEJb');

/* Dúvidas- Perimetro*/
/*insert into Duvidas(Descricao,URLVideo,Exercicio) values ('Exercicio sobre Perimetros','https://youtu.be/0uauWawzgcU',1);
insert into Duvidas(Descricao,URLVideo,Exercicio) values ('Exercicios sobre Perimetros','https://youtu.be/Lp2mBsGN9dI',2);
insert into Duvidas(Descricao,URLVideo,Exercicio) values ('Exercicios sobre Perimetros','https://youtu.be/dXbRepTkpTo',3);

/* Dúvidas- Area*/
insert into Duvidas(Descricao,URLVideo,Exercicio_ExercicioID) values ('Exercicio sobre Áreas','https://youtu.be/1d7IFhly4II',4);
insert into Duvidas(Descricao,URLVideo,Exercicio_ExercicioID) values ('Exercicio sobre Áreas','https://youtu.be/Ade73hv-LzU',5);
insert into Duvidas(Descricao,URLVideo,Exercicio_ExercicioID) values ('Exercicio sobre Áreas','https://youtu.be/_CVrt0V7J68',6);
*/
/*Perguntas*/
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Considere este triângulo com 3 lados iguais (equilátero), sendo x = 3 cm. Qual o valor do perímetro?. Descobre a opção correta e assinala a verdadeira:','https://flic.kr/p/uc3GgU','9 cm',1);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro do retângulo, sendo y = 5 cm e x = 4 cm.','https://flic.kr/p/udZhwu','18 cm',1);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Calcule o perímetro do círculo, com raio, x = 1 cm.','https://flic.kr/p/thnDDY','2π cm',1);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro da figura. Tem atenção, que é um triângulo isósceles, com x = 5 cm e y = 3 cm.','https://flic.kr/p/thnDSo','13 cm',2);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro, sendo x = 5 cm e y = 3 cm.','https://flic.kr/p/thmuhU','16 cm',2);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre o perímetro, sendo x = 1 dm','https://flic.kr/p/thnDDY','2π dm',2);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O Sr. Barroso quer vedar uma porção de terreno para atividades das festas da vila. Quantos metros de rede tem de comprar o Sr. Barroso?','https://flic.kr/p/ue4USs','30 m',3);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O filho do Sr. Barroso quer construir uma casa no terreno que está a branco, descobre o perímetro do terreno a cinzento.','https://flic.kr/p/ue4USs','10 m',3);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O filho do Sr. Barroso precisava de saber o perímetro do terreno que vai ser usado para a casa, para mandar vedar por causa dos animais selvagens. Calcula o perímetro so quadrado branco.','https://flic.kr/p/ue4USs','20 m',3);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Qual das figuras tem exatamente 28 m2?','https://flic.kr/p/thnEo3','A',4);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área deste pequeno retângulo, sendo y = 5 cm e x = 3 cm.','https://flic.kr/p/udZhwu','15 cm2',4);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área deste triângulo, sendo x = 3 cm e h = 4 cm.','https://flic.kr/p/uc3GgU','6 cm2',4);


insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área do triângulo, sendo x = 2 cm e h = 1 dm.','https://flic.kr/p/uc3GgU','20 cm2',5);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Descobre a área da circunferência, com raio = 2 cm.','https://flic.kr/p/thnDDY','4π cm2',5);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Será que serás capaz de descobrir qual destas 3 figuras têm a maior área?','https://flic.kr/p/tWVGmp','B',5);

insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O Sr. Pinto da Costa decidiu que a relva dos campos da academia do clube estavam a precisar de ser renovados, para isso ele tem de saber exatamente a área. Será que és tu que o vais ajudar? Que valor obtiveste como resultado?','https://flic.kr/p/tWVGHB','1200 m2',6);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('A empresa do Sr. Pinto quer comprar a relva para colocar no campo. Calcula a área em dam2','https://flic.kr/p/tWVGHB','12 dam2',6);
insert into Perguntas(Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('se o Sr. Pinto não tiver verbas, e quiser mudar a relva só a um campo, qual será a sua área?','https://flic.kr/p/tWVGHB','600 m2',6);

insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Estás a ver o comprimento do carro? Descobre o comprimento em metros.','https://flic.kr/p/uey1BB','3.88 m',7);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Aqui temos uma torre bastante conhecida, será que podias ajudar o João a transformar a altura de metros para decâmetros?','https://flic.kr/p/thwRrM','32.4 dam',7);


insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('O prof. Manuel comprou um móvel e quer pô-lo no seu gabinete, mas para isso precisa de saber se tem espaço para o pôr. O que ele sabe é que no seu gabinete tem 10 m2 livres e o móvel tem 100 dm2. Podes ajudar a fazer a transformação da área do móvel para m2, para ajudares o professor com a sua compra? ','https://flic.kr/p/uey2Pr','A',8);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Esta é a minha casa, podias - me dizer quantos cm2 tem a minha cozinha?','https://flic.kr/p/uey2Pr','87100 cm2',8);
insert into Perguntas (Descricao, URLImagem, RespCerta,Exercicio_ExercicioID) values ('Queria ver se tinha espaço para pôr 20 cartazes deste filme na parede do meu quarto. Sabendo que os 20 cartazes fazem uma área de 10000 cm2, e que a parede do meu quarto tem 500 dm2. Converte as duas medidas para m2, primeiro dos cartazes depois da parede, para me ajudares no meu problema.','https://flic.kr/p/tWMEJb','1 m2 e 5 m2',8);

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




