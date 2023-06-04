using FactoryMethod;

Creater creater = new Creater();

Game atari = creater.FactoryMethod(GamePlatforms.Atari);
Game pc = creater.FactoryMethod(GamePlatforms.PC);
Game ps = creater.FactoryMethod(GamePlatforms.PS);

atari.Platform();
ps.Platform();
pc.Platform();