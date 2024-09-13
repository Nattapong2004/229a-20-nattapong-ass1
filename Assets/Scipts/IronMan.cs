using UnityEngine;


class IronMan
{

    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;

    // Constructor
    public IronMan(string newName,int newHp,string newSuitColor)
    {
        Name = newName;
        Hp = newHp; 
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void Fly()
    {
        Debug.Log($"------{Name} is flying");
    }

    public void ShootLeser()
    {
        Debug.Log($"======{Name} is shooting lesers");
    }

    public void UpdateArmorStrenght(float strenght)
    {
        armorStrength += strenght;
        Debug.Log($"****** {Name} update their strength to {armorStrength}");
    }

    public void Takedamege(int damege)
    {
        damege = UnityEngine.Random.Range(10, 21);
        Hp -= damege;

        Debug.Log($"{Name} take damege : {damege}");
        Debug.Log($"{Name} Hp is : {Hp}");

        IsDead();

    }

    public bool IsDead()
    { return Hp > 0;
        Debug.Log($"{Name} is dead");
    }
}
