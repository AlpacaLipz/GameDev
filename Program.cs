

// Attack TittyTwister = new Attack("Titty Twister", 25);
// Attack BrokenBeerBottle = new Attack("Broken Beer Bottle", 15);
// Attack ThePeoplesElbow = new Attack("The People's Elbow", 20);

// melee
Attack SenateFloor = new Attack("Litigation", 15);
Attack BleachBit = new Attack("No Prosecution!", 20);
Attack LostServer = new Attack("So lost it hurts.", 25);

// ranged
Attack ShootGun = new Attack("Shoot'em UP", 20);
Attack WomansScorn = new Attack("Like a stab but from range", 15);

// magic
Attack  LightningFryingPan = new Attack("Never even saw the pan coming", 20);
Attack  GreaseThrow = new Attack("Should'nt have pissed off an old woman cooking", 25);
Attack  OlOneTwoForYaBoi = new Attack("Madea hits em wit the ol' one two", 10);

List<Attack> rangedAttacks = new List<Attack>()
{
  ShootGun, WomansScorn
};
List<Attack> magicAttacks = new List<Attack>()
{
  LightningFryingPan, GreaseThrow, OlOneTwoForYaBoi
};
List<Attack> meleeAttacks = new List<Attack>()
{
  SenateFloor, BleachBit, LostServer
};

MeleeFighter Senator = new MeleeFighter("Hillary Clinton", meleeAttacks);
MagicFighter TylerPerry = new MagicFighter("Madea", magicAttacks);
RangedFighter Woman = new RangedFighter("Aileen Wuornos", 5, rangedAttacks);

Senator.PerformAttack(TylerPerry, SenateFloor);
Senator.Rage(TylerPerry);
Woman.PerformAttack(Senator, ShootGun);
Woman.Dash();
Woman.PerformAttack(Senator, ShootGun);
TylerPerry.PerformAttack(Senator, GreaseThrow);
TylerPerry.MagicHeal(Woman, Woman);
TylerPerry.MagicHeal(TylerPerry, TylerPerry);

// Enemy MyEnemy = new Enemy("Dahli Llama", 100, new List<Attack>(){TittyTwister, BrokenBeerBottle, ThePeoplesElbow});
// System.Console.WriteLine();
// MyEnemy.EnemyAttacks();









// RIP LT gone too soon man