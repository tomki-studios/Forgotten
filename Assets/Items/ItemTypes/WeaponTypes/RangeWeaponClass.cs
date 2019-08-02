using UnityEngine;

namespace Assets.Items.ItemTypes.WeaponTypes
{
    public enum projectileType
    {
        arrow, bullet, laser 
    }

    public enum FiringMode
    {
        automatic, semiAutomatic
    }

    public class RangeWeaponClass : WeaponClass
    {
        public projectileType projType;
        public FiringMode fireMode;
        public int magazineSize;

        public void Shot()
        {

        }

        public void Reload()
        {

        }

        void Update()
        {
            if(Input.GetMouseButtonDown(1) && fireMode == FiringMode.semiAutomatic)
            {
                Shot();
            }
        }
    }
}
