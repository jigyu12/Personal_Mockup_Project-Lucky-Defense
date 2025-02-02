using UnityEngine;

[CreateAssetMenu(fileName = "HeroData", menuName = "Scriptable Object/HeroData")]
public class HeroData : ScriptableObject
{
    [SerializeField] private int heroID;

    public int HeroID => heroID;
    
    [SerializeField] private int stringKey;

    public int StringKey => stringKey;
    
    [SerializeField] private HeroGrade grade;
    
    public HeroGrade Grade => grade;
    
    [SerializeField] private HeroAttackType atkType;

    public HeroAttackType AtkType => atkType;
    
    [SerializeField] private float atkRange;

    public float AtkRange => atkRange;
    
    [SerializeField] private int heroDamage;

    public int HeroDamage => heroDamage;
    
    [SerializeField] private float atkSpeed;

    public float AtkSpeed => atkSpeed;
    
    [SerializeField] private int heroSkill;

    public int HeroSkill => heroSkill;
    
    [SerializeField] private int blockCost;
    
    public int BlockCost => blockCost;
    
    [SerializeField] private int saleType;
    
    public int SaleType => saleType;
    
    [SerializeField] private int saleQuantity;
    
    public int SaleQuantity => saleQuantity;
}

public class HeroCsvData
{
    public int HeroID { get; set; }
    public int StringKey { get; set; }
    public int Grade { get; set; }
    public HeroAttackType AtkType { get; set; }
    public float AtkRange { get; set; }
    public int HeroDamage { get; set; }
    public float AtkSpeed  { get; set; }
    public int HeroSkill { get; set; }
    public int BlockCost { get; set; }
    public int SaleType { get; set; }
    public int SaleQuantity { get; set; }
}