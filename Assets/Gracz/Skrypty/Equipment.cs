using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public List<GameObject> eq = new List<GameObject>();
    public GameObject panelEq;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        AddSword();    //just for debbuging
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

    public GameObject Sword() //create sword item
    {
        GameObject itemSword = new GameObject();
        itemSword.AddComponent<MeleeClass>().attackSpeed = 1;
        itemSword.GetComponent<MeleeClass>().weight = 1;
        itemSword.GetComponent<MeleeClass>().value= 1;
        itemSword.GetComponent<MeleeClass>().dmg= 1;
        itemSword.GetComponent<MeleeClass>().description= "Just a test sword";
        itemSword.GetComponent<MeleeClass>().name= "Test Sword";
        return itemSword;
    }
    public void AddSword() //add item to eq
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
        eq.Add(Sword());


    }
    public void ShowingItem()
    {
        //TO;DO showing panel with item variables
    }
            
}
                        //Script by Daniel Grala
