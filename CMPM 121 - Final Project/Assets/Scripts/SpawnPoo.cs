using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnPoo : MonoBehaviour
{
    public GameObject pet;
    public GameObject poop;
    private PetStats stats;
    private bool poopSet = false;

   void Start()
    {
        stats = pet.GetComponent<PetStats>();
    }

   void Update()
    {
        SpawnPoop();
    }

    void SpawnPoop()
    {
        if(stats.currentClean == 50 && poopSet == false)
        {
            poop.SetActive(true);
            poopSet = true;
        }

        if(stats.currentClean > 50 && poopSet == true)
        {
            poop.SetActive(false);
            poopSet = false;
        }
    }
}
