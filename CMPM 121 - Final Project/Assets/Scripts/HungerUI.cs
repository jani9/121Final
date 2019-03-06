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

    // Start is called before the first frame update
    void Start()
    {
        hungerBar.transform.localPosition = new Vector2(fullBar, hungerBar.transform.localPosition.y);
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
        //hungerBar.GetComponent<RectTransform>().position = new Vector2(fullBar * hungerPercent, hungerBar.transform.position.y);
        hungerBar.transform.localPosition = new Vector2 (fullBar * hungerPercent, hungerBar.transform.localPosition.y);

    }


}
