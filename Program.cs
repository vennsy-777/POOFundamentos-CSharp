// varia     
// TIPO NOME

using POO_Fundamentos;

//Instanciar
Carro carroDoEdu  = new Carro();

carroDoEdu.Modelo = "HB20S";
carroDoEdu.Marca = "Hyundai";
carroDoEdu.Ano = 2024;

carroDoEdu.ExibirInformacoes();

Carro CarroDoCauan = new Carro();
CarroDoCauan.Modelo = "Ka";
CarroDoCauan.Marca = "Ford";
CarroDoCauan.Ano = 2001;

CarroDoCauan.ExibirInformacoes();



//classe pedido
// NomeDoCliente, Item, Quantidade, Preco


Pedido pedidoDoEdu = new Pedido();

pedidoDoEdu.CName = "Eduardo";
pedidoDoEdu.Item = "Hamburger";
pedidoDoEdu.Quantidade = 2;
pedidoDoEdu.Preco = 100;

pedidoDoEdu.ExibirPedido();


Pessoa pessoaeduardo = new Pessoa();

pessoaeduardo.Nome = "Bruno";
pessoaeduardo.Idade = 2;


pessoaeduardo.Apresentar();

Pessoa pessoaSenais = new Pessoa();

pessoaSenais.Nome = "Matheus";
pessoaSenais.Idade = 7;

pessoaSenais.Apresentar();


Retangulo eduRetangulo = new Retangulo();

eduRetangulo.Largura = 5;
eduRetangulo.Altura = 3;

eduRetangulo.mostrar();

//double apresentar = eduRetangulo.CalcularArea;
//double apresentar2 = eduRetangulo.CalcularPerimetro;



