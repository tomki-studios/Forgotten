using UnityEngine;

namespace Assets.Items
{
    public class ItemClass : MonoBehaviour
    {
        //Posiadacz
        public GameObject owner;
        //Nazwa
        public string itemName;
        //Opis
        public string description;
        //Pozycja w eq
        public int eqPosition;
        //Ilość
        public float amount = 1f;
        //Waga
        public float weight;
        //Wartość
        public float value;
    }
}
