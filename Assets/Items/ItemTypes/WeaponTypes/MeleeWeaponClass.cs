using UnityEngine;

namespace Assets.Items.ItemTypes.WeaponTypes
{
    public class MeleeWeaponClass : WeaponClass
    {
        //Zasięg ataku
        public float attackRange;

        //"stożek" do ataku wręcz 
        public float coneRange;

        Transform headTrans;

        Vector3 playerDir;





        void Start()
        {
            headTrans = owner.transform.GetChild(0).GetComponent<Transform>();

        }

        void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                PerformAttack();
            }
        }

        //"virtual" pozwala edytować funkcję w podklasach
        //Wykonaj atak
        public virtual void PerformAttack()
        {
            //Find enemies in range
            Collider[] Enemy_col = Physics.OverlapSphere(headTrans.position, attackRange);
            playerDir = headTrans.forward;
            foreach(Collider enemy in Enemy_col)
            {
                if(enemy.tag == "Enemy")
                { 
                    float angle = Vector3.Angle(playerDir, enemy.ClosestPoint(headTrans.position) - headTrans.position);

                    if (angle <= coneRange)
                    {
                        enemy.GetComponent<Stats>().Health -= damageOnHit;
                        Debug.Log("Hit");
                    }
                }

            }




        }
    }
}
