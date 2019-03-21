using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CleanUI : MonoBehaviour
{
    public GameObject pet;
    public Image cleanBar;
    private PetStats stats;

    private int fullBar = 192;
    private int empty = 0;
    private float cleanPercent;

    void Start()
    {
        cleanBar.transform.localPosition = new Vector2(fullBar, cleanBar.transform.localPosition.y);
        stats = pet.GetComponent<PetStats>();
    }

    void Update()
    {
        ChangeCleanBar();
    }

    void ChangeCleanBar()
    {
        cleanPercent = stats.currentClean / 100f;
        cleanBar.transform.localPosition = new Vector2(fullBar * cleanPercent, cleanBar.transform.localPosition.y);
    }
}
