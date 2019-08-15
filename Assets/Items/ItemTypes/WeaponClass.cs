namespace Assets.Items.ItemTypes
{
    public class WeaponClass : ItemClass
    {
        public bool isEquipped;
        //Obrażenia
        public float damageOnHit;
        //Zużycie
        public float usage = 100f;
        //Zużycie na atak
        public float usagePerAttack;
        //Prędkość ataku
        public float attackSpeed;
        

    }
}
