using System;

namespace devMessenger
{
  class Ezh
  {
    public string name;
    public int age;
    public  Ezh()
    {
      name="Неизвестно";
      age=18;
    }
    public Ezh(string _name)
    {
      name=_name;
      age=18;
    }
    public Ezh(string _name, int _age)
    {
      name=_name;
      age=_age;
    }
    public void Dislay()
    {
      string str1 = "Ёжика зовут: " + name + "\n" +
                    "Ёжику " + age + " лет";
      Console.WriteLine(str1);

    }
    public override string ToString()
    {
      return String.Format($"Ёжика зовут: {name} \n" +
                           $"Ёжику  {age} лет");
    }
  }
  class megaEzh : Ezh
  {
    public int health;
    public int damage;
    string weapon;
    public megaEzh(int health, int demange, string weapon)
    {
      this.health = health;
      this.damage = demange;
      this.weapon = weapon;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Ezh ezh1 = new Ezh();   //пример классов с разными конструкторами
      Ezh ezh2 = new Ezh("Алихана");   //пример классов с разными конструкторами
      Ezh ezh3 = new Ezh("Русаков", 36);   //пример классов с разными конструкторами 
      //ezh1.Dislay();
      //ezh2.Dislay();
      //ezh3.Dislay();
      Console.WriteLine(ezh1.ToString());
      Console.WriteLine(ezh2);
      Console.WriteLine(ezh3);
    }
  }
}
