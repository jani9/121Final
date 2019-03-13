using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HappyUI : MonoBehaviour
{
    public GameObject pet;
    public Image happyBar;
    private PetStats stats;

    private int fullBar = 192;
    private int empty = 0;
    private float happyPercent;

    void Start()
    {
        happyBar.transform.localPosition = new Vector2(fullBar, happyBar.transform.localPosition.y);
        stats = pet.GetComponent<PetStats>();
    }

    void Update()
    {
        ChangeHappyBar();
    }

    void ChangeHappyBar()
    {
        happyPercent = stats.currentHappy / 100f;
        happyBar.transform.localPosition = new Vector2(fullBar * happyPercent, happyBar.transform.localPosition.y);
    }
}
