using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Items.ItemTypes.WeaponTypes
{
    public enum projectileType
    {
        arrow, bullet, laser 
    }

    public class RangeWeapon : WeaponClass
    {
        public projectileType projType;
        public int magazineSize;

       

        
        public RangeWeapon( 
            int eqPosition, 
            float amount, 
            float weight, 
            float value, 
            float damageOnHit, 
            float usage, 
            float attackSpeed, 
            projectileType projType, 
            int magazineSize
        ) : base(eqPosition, amount, weight, value, damageOnHit, usage, attackSpeed)

        {
            projType = this.projType;
            magazineSize = this.magazineSize;
        }

    }
}
