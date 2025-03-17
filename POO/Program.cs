using POO.model;

Veiculo obj = new Veiculo("Ford", "Ka", 2011, 330.00);
obj.Acelerar();
obj.Freiar();

Carro carro = new Carro("Ford", "Ka", 2011, 330.00, true, 4);
carro.AbrirPortas();

Moto moto = new Moto("Kawasaki", "Ninja", 2011, 330.00, true, true);
moto.Empinar();