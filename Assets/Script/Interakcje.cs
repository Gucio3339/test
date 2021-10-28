using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interakcje : MonoBehaviour
{
    public Transform player;
    public GameObject[] Pickable_Items;
    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    private void Start()
    {

        slotFull = false;
         Pickable_Items =GameObject.FindGameObjectsWithTag("Interactable") ;


    }

    private void Update()
    {

        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.F) && !slotFull) PickUp();


        if (equipped && Input.GetKeyDown(KeyCode.G)) Drop();
    }

    private void PickUp()
    {
        equipped = true;
        slotFull = true;

        for (int i = 0; i <Pickable_Items.Length; i++)
        { float dist = Vector3.Distance(Pickable_Items[i].transform.position, transform.position);
            Debug.Log("objekt " + Pickable_Items[i].name + "distance: " + dist);
           

        }

        // transform.localPosition = Vector3.zero;
        // transform.localRotation = Quaternion.Euler(Vector3.zero);
        // transform.localScale = Vector3.one;



    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;


        transform.SetParent(null);






    }
}
