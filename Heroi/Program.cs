using Heroi.model;

Guerreiro obj = new Guerreiro("Acertou o inimigo!", "se protege de todos os ataques durante 10 segundos");
obj.Atacar();
obj.Especial();

Mago mago = new Mago("Acertou o inimigo!", "");
mago.Atacar();
mago.Especial();

Arqueiro arqueiro = new Arqueiro("Acertou o inimigo!", "");
arqueiro.Atacar();
arqueiro.Especial();