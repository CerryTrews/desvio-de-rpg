public class Trident : Weapons
{
    public Trident()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Trident";
        CoinType = "GP";
        Price = 5;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 4;
        Properties1 = "Thrown"; // range 20/60
        Properties2 = "Versatile"; // 1d8 
        Properties2 = string.Empty;
        Properties2 = string.Empty;
    }
}