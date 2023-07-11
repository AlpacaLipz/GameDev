class RangedFighter : Enemy
{
  public int Distance{get;set;} = 5;
  public List<Attack> RangedAttackList{get;set;} = new List<Attack>();

  public RangedFighter(string name,int distance,List<Attack> range) : base(name, 100)
  {
    Distance = distance;
    RangedAttackList = range;
  }
    public void PerformAttack(Enemy Target,Attack ChosenAttack) 
    {
      if (Distance > 10)
      {
        base.PerformAttack(Target, ChosenAttack);
      }
      else 
      {
        System.Console.WriteLine("You need to get further away.");
      }

    }
    public void  Dash() //List<Attack>
  {
    this.Distance = Distance + 20;
    System.Console.WriteLine($"{Name} Dashes {Distance} increases the distance from her enemy !!");
  }
}