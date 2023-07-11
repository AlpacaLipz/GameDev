class MeleeFighter  : Enemy
{
  public List<Attack> MeleeAttackList{get;set;} = new List<Attack>();
  public MeleeFighter(string name, List<Attack> melee) : base(name, 120)
  {
    MeleeAttackList = melee;
  }
  public void  Rage(Enemy Target) //List<Attack>
  {
    Random rand = new Random();
    int index = rand.Next(AttackList.Count);
    Attack randAttack = MeleeAttackList[index];
    int damage = randAttack.DamageAmount + 10;
    Target.ModifyHealth(-damage);
    System.Console.WriteLine($"{Name} Rages probably hooked on that meth towards {Target.Name}, Striking them with {randAttack.Name}'s damage to {Target.Health}!!");
  }
}