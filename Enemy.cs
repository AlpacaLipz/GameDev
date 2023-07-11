

public class Enemy
{
  public string Name { get; set; }
  public int Health { get; set; }
  public List<Attack> AttackList { get; set; } = new List<Attack>();


  // Enemy(){}
  public Enemy(string name, int health)
  {
    Name = name;
    Health = health;
  }
  public Enemy(string name, int health, List<Attack> attack)
  {
    Name = name;
    Health = health;
    AttackList = attack;

  }
  public void EnemyAttacks() //List<Attack>
  {
    Random rand = new Random();
    int hurt = rand.Next(this.AttackList.Count);
    System.Console.WriteLine(this.AttackList[hurt].Name);
  }
  // Inside of the Enemy class
  public void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    Target.Health = Target.Health - ChosenAttack.DamageAmount;
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
  }
  public void ModifyHealth(int amount)
  {
    Health = Health + amount;
  }
}