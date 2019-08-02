using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Items;
using Assets.Items.ItemTypes;
using Assets.Items.ItemTypes.WeaponTypes;
using Assets.Items.ItemTypes.WeaponTypes.MeleeWeapons;


public class Equipment : MonoBehaviour
{
    public List<ItemClass> eq = new List<ItemClass>();
    public GameObject panelEq;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        AddItemToEq(Sword());    //just for debbuging
    }

    // Update is called once per frame
    void Update()
    {
        #region OpeningPanelEq
        if (Input.GetKeyDown(KeyCode.E)) //checking if E pressed
        {
            Debug.Log("pressed E");
            if (panelEq.activeInHierarchy == true) //close EqPanel
            {
                Debug.Log("panel active");
                panelEq.SetActive(false);
                playerMovement.enabled = true;
            }
            else                                  //open EqPanel
            {
                Debug.Log("panel disable");
                panelEq.SetActive(true);
                playerMovement.enabled = false;
            }
        }
        #endregion

    }

    public SwordClass Sword() //create sword item
    {
        SwordClass itemSword = new SwordClass();
        itemSword.attackRange = 1;
        itemSword.coneRange = 45;
        itemSword.attackSpeed = 1;
        itemSword.weight = 1;
        itemSword.value= 1;
        itemSword.damageOnHit= 1;
        itemSword.description= "Just a test sword";
        itemSword.itemName= "Test Sword";
        return itemSword;
    }
    public void AddItemToEq(ItemClass item) //add item to eq
    {
        #region TO;DO
        //if (actualWeight <= MaxWeight)     //checking if weight isn't passed
        //{
        //switch (EqLvl)                    //checking actual Eq level and restricting list to specific size
        //{
        //    0:
        //        if (eq.Count < 10)
        //        {
        //            eq.Add(Sword());
        //        }
        //        break;
        //    1:
        //        if (eq.Count < 15)
        //        {
        //            eq.Add(Sword());
        //        }
        //        break;
        //    2:
        //        if (eq.Count < 20)
        //        {
        //            eq.Add(Sword());
        //        }
        //        break;
        //    3:
        //        if (eq.Count < 25)
        //        {
        //            eq.Add(Sword());
        //        }
        //        break;
        //    4:
        //        if (eq.Count < 30)
        //        {
        //            eq.Add(Sword());
        //        }
        //        break;
        //    5:
        //        if (eq.Count < 35)
        //        {
        //            eq.Add(Sword());
        //        }
        //        break;
        //    default:
        //        break;
        //}

        // }
        #endregion
        eq.Add(item);


    }
    public void ShowingItem()
    {
        //TO;DO showing panel with item variables
    }
            
}
                        //Script by Daniel Grala
