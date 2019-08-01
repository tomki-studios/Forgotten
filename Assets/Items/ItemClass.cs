using UnityEngine;

namespace Assets.Items
{
    public class ItemClass : MonoBehaviour
    {
        public int eqPosition;
        public float amount;
        public float weight;
        public float value;

        public ItemClass(int eqPosition, float amount, float weight, float value)
        {
            eqPosition = this.eqPosition;
            amount = this.amount;
            weight = this.weight;
            value = this.value;
        }
    }
}
