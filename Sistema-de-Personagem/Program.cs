using Sistema_de_Personagem.model;

MagoDeGelo magoDeGelo = new MagoDeGelo(100, 15, 15, 20, "Homem", "Ataque de Gelo");
magoDeGelo.Status();

MagoEletrico magoEletrico = new MagoEletrico(100, 15, 15, 20, "Homem", "Ataque elétrico");
magoEletrico.Status();

MagoDeFogo magoDeFogo = new MagoDeFogo(100, 15, 15, 20, "Homem", "Ataque de fogo");
magoDeFogo.Status();

SuperMago superMago = new SuperMago(100, 15, 15, 20, "Homem", "Ataque de raio");
superMago.Status();