using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Items;
using Assets.Items.ItemTypes;
using Assets.Items.ItemTypes.WeaponTypes;
using Assets.Items.ItemTypes.WeaponTypes.MeleeWeapons;


public class Equipment : MonoBehaviour
{
    public List<GameObject> eq = new List<GameObject>();
    public GameObject[] slots1 = new GameObject[12];
    public GameObject[] slots2 = new GameObject[12];
    public GameObject[] slots3 = new GameObject[12];
    public GameObject panelEq;
    public GameObject Slots1;
    public GameObject Slots2;
    public GameObject Slots3;
    public PlayerMovement playerMovement;
    int PageNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        AddItemToEq(Sword());    //just for debbuging
        panelEq.SetActive(false);
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
        #region SwitchingPages
        switch (PageNumber)
        {
            case 1:
                {
                    Slots1.SetActive(true);
                    Slots2.SetActive(false);
                    Slots3.SetActive(false);
                    break;
                }
            case 2:
                {
                    Slots1.SetActive(false);
                    Slots2.SetActive(true);
                    Slots3.SetActive(false);
                    break;
                }
            case 3:
                {
                    Slots1.SetActive(false);
                    Slots2.SetActive(false);
                    Slots3.SetActive(true);
                    break;
                }
            default:
                break;
        }
        #endregion


    }

    public void NextBtn()
    {
        if (PageNumber < 3)
            PageNumber++;
    }
    public void PreviousBtn()
    {
        if (PageNumber > 1)
            PageNumber--;
    }

    public GameObject Sword() //create sword item
    {
        GameObject itemSword = new GameObject();
        itemSword.name = "Test Sword";
        itemSword.AddComponent<SwordClass>().attackRange = 1;
        itemSword.GetComponent<SwordClass>().coneRange = 45;
        itemSword.GetComponent<SwordClass>().attackSpeed = 1;
        itemSword.GetComponent<SwordClass>().weight = 1;
        itemSword.GetComponent<SwordClass>().value= 1;
        itemSword.GetComponent<SwordClass>().damageOnHit= 1;
        itemSword.GetComponent<SwordClass>().description= "Just a test sword";
        itemSword.GetComponent<SwordClass>().itemName= "Test Sword";
        return itemSword;
    }
    public void AddItemToEq(GameObject item) //add item to eq
    {
        #region TO;DO
        //if (currWeight <= MaxWeight)     //checking if weight isn't passed
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
        #endregion //
        item.GetComponent<ItemClass>().owner = this.gameObject;
        eq.Add(item);


    }
    void OnMouseOver()
    {
        
    }

    public void ShowItemInfo(string name, string description, float value, float weight, float amount)
    {
        //show normal item panel with info in arguments in position of cursor
    }
    public void ShowMeleeItemInfo(string name, string description, float value, float weight, float amount, float usage, float damage,
                                  float attackSpeed, float attackRange)
    {
        //show melee item panel with info in arguments in position of cursor
    }
    public void ShowRangeItemInfo(string name, string description, float value, float weight, float amount, float usage,
                                  projectileType projectile, FiringMode firingMode, int magazineSize)
    {
        //show range item panel with info in arguments in position of cursor
    }

    public void ShowingItem() //not finished, must add loop(foreach?)
    {
        slots1[0].GetComponent<Image>().sprite = eq[0].GetComponent<Image>().sprite;
    }
            
}
                        //TO;DO: finish script and maybe another class for collisions(?)
                        //Script by Daniel Grala 
