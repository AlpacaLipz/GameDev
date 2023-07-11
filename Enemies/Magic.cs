class MagicFighter  : Enemy
{
  public List<Attack> MagicAttackList{get;set;} = new List<Attack>(); 
  public MagicFighter(string name, List<Attack> magic) : base(name, 80)
  {
    MagicAttackList = magic;
  }
    public void  MagicHeal(Enemy Target, Enemy Health) //List<Attack>
  {
    Target.ModifyHealth(40);
    System.Console.WriteLine($"{Name} Heals {Target.Name}, replenishing {Target.Name}'s health to {Target.Health}!!");
  }
}