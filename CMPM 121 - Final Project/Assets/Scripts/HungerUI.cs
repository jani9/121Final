using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerUI : MonoBehaviour
{
    public GameObject pet;
    public GameObject hungerBar;
    private PetStats stats;

    private int fullBar = -192;
    private int empty = 0;
    private float hungerPercent;

    // Start is called before the first frame update
    void Start()
    {
        hungerBar.transform.position = new Vector2(fullBar, hungerBar.transform.position.y);
        stats = pet.GetComponent<PetStats>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeHungerBar();
    }

    void ChangeHungerBar()
    {

        hungerPercent = stats.currentHunger / 100f;
        Debug.Log(hungerPercent);
        hungerBar.GetComponent<RectTransform>().position = new Vector2(fullBar * hungerPercent, hungerBar.transform.position.y);
        //hungerBar.transform.position = new Vector2 (fullBar * hungerPercent, hungerBar.transform.position.y);

    }
}
