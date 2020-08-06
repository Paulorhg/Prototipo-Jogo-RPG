﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensManager : MonoBehaviour
{

    //[SerializeField]
    //Item[] weapons = new Item[5];
    //[SerializeField]
    //Item[] shields = new Item[5];
    //[SerializeField]
    //Item[] armor = new Item[5];
    //[SerializeField]
    //Item[] potions = new Item[5];

    GameObject weaponEquipped;
    GameObject shieldEquipped;
    GameObject armorEquipped;

    //private int itensCount = 0;
    //Dictionary<int, Item> itensEmJogo = new Dictionary<int, Item>();


    GameObject weaponArm;
    GameObject shieldArm;
    GameObject chest;



    // Start is called before the first frame update
    void Start()
    {
        weaponArm = GameObject.FindGameObjectWithTag("Weapon");
        shieldArm = GameObject.FindGameObjectWithTag("Shield");
        chest = GameObject.FindGameObjectWithTag("Armor");

        //if (weaponArm.transform.childCount == 0)
        //{
        //    GameObject newWeapon = Instantiate(weapons[0].gameObject, weaponArm.transform);
        //    Item scrNewWeapon = newWeapon.GetComponent<Item>();
        //    scrNewWeapon.pickedUp = true;
        //    scrNewWeapon.allItensId = itensCount;
        //    itensEmJogo[itensCount] = scrNewWeapon;
        //    itensCount++;

        //}
        //if (shieldArm.transform.childCount == 0)
        //{

        //    GameObject newShield = Instantiate(shields[0].gameObject, shieldArm.transform);
        //    Item scrNewShield = newShield.GetComponent<Item>();
        //    scrNewShield.pickedUp = true;
        //    scrNewShield.allItensId = itensCount;
        //    itensEmJogo[itensCount] = scrNewShield;
        //    itensCount++;
        //}
    }

    // Update is called once per frame
    //void Update()
    //{
    //if (Input.GetKeyDown(KeyCode.Alpha1))
    //{
    //    ChangeWeapon(1);
    //}
    //}


    public void ChangeWeapon(int newId)
    {
        if(newId == 404)
        {
            if (weaponEquipped != null)
            {
                weaponEquipped.SetActive(false);
            }
            weaponEquipped = null;
        }

        for(int i = 0; i < weaponArm.transform.childCount; i++)
        {
            if(weaponArm.transform.GetChild(i).GetComponent<Item>().id == newId)
            {
                
                if(weaponEquipped != null)
                {
                    weaponEquipped.SetActive(false);
                }
                weaponEquipped = weaponArm.transform.GetChild(i).gameObject;
                weaponEquipped.SetActive(true);
                break;
            }
        }
    }

    public void ChangeShield(int newId)
    {
        if (newId == 404)
        {
            if (shieldEquipped != null)
            {
                shieldEquipped.SetActive(false);
            }
            shieldEquipped = null;
        }

        for (int i = 0; i < shieldArm.transform.childCount; i++)
        {
            if (shieldArm.transform.GetChild(i).GetComponent<Item>().id == newId)
            {

                if (shieldEquipped != null)
                {
                    shieldEquipped.SetActive(false);
                }
                shieldEquipped = shieldArm.transform.GetChild(i).gameObject;
                shieldEquipped.SetActive(true);
                break;
            }
        }
    }

    public void ChangeArmor(int newId)
    {
        if (newId == 404)
        {
            if (armorEquipped != null)
            {
                armorEquipped.SetActive(false);
            }
            armorEquipped = null;
        }

        for (int i = 0; i < chest.transform.childCount; i++)
        {
            if (chest.transform.GetChild(i).GetComponent<Item>().id == newId)
            {

                if (armorEquipped != null)
                {
                    armorEquipped.SetActive(false);
                }
                armorEquipped = chest.transform.GetChild(i).gameObject;
                armorEquipped.SetActive(true);
                break;
            }
        }
    }
}
