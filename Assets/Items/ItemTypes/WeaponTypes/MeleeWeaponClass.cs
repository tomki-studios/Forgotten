

namespace Assets.Items.ItemTypes.WeaponTypes
{
    public class MeleeWeaponClass : WeaponClass
    {
        //Zasięg ataku
        public float attackRange;

        //"stożek" do ataku wręcz 
        public int coneRange; 


        //"virtual" pozwala edytować funkcję w podklasach
        public virtual void Attack()
        {

        }
    }
}
