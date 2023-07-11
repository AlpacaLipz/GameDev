
public class Attack
{
  public string Name{get; set;}
  public int DamageAmount{get; set;}

  // Attack(){}


  public Attack(string name, int damage)
  {
    Name = name;
    DamageAmount = damage;
  }
}
