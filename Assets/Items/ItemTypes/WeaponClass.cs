using Assets.Items;

namespace Assets.Items.ItemTypes
{
    public class WeaponClass : ItemClass
    {
        public float damageOnHit;
        public float usage;
        public float attackSpeed;

        public WeaponClass(
            int eqPosition, 
            float amount,
            float weight, 
            float value, 
            float damageOnHit, 
            float usage, 
            float attackSpeed
        ) : base(eqPosition, amount, weight, value)
        {
            damageOnHit = this.damageOnHit;
            usage = this.usage;
            attackSpeed = this.attackSpeed;
        }
    }
}
