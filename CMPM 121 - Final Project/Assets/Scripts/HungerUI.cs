using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HungerUI : MonoBehaviour
{
    public GameObject pet;
    public Image hungerBar;
    private PetStats stats;

    private int fullBar = 192;
    private int empty = 0;
    private float hungerPercent;

    void Start()
    {
        hungerBar.transform.localPosition = new Vector2(fullBar, hungerBar.transform.localPosition.y);
        stats = pet.GetComponent<PetStats>();
    }

    void Update()
    {
        ChangeHungerBar();
    }

    void ChangeHungerBar()
    {

        hungerPercent = stats.currentHunger / 100f;
        hungerBar.transform.localPosition = new Vector2 (fullBar * hungerPercent, hungerBar.transform.localPosition.y);

    }

}
