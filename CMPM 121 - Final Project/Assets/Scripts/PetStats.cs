using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    //UI Text
    public Text hungerText;
    public Text happyText;

    //Hunger
    public int currentHunger;
    public int maxHunger = 100;
    public int hungerRate = 5;
    public int foodBuff = 10;

    //Happiness
    public int currentHappy;
    public int maxHappy = 100;
    public int happyRate = 2;
    public int playBuff = 10;

    //Time
    private float time = 0f;
    private float rate = 2f;

    void Start()
    {
        currentHunger = maxHunger;
        currentHappy = maxHappy;
        Debug.Log(currentHunger);
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time > rate)
        {
            time = 0;
            LowerStats();
            Debug.Log(currentHunger);
        }
        SetText();
    }

    void SetText()
    {
        hungerText.text = "Hunger: " + currentHunger.ToString();
        happyText.text = "Happy: " + currentHappy.ToString();
    }

    void LowerStats()
    {
        currentHunger = Mathf.Clamp(currentHunger - hungerRate, 0, maxHunger);
        currentHappy = Mathf.Clamp(currentHappy - happyRate, 0, maxHappy);

    }

    public void FeedPet()
    {
        currentHunger = Mathf.Clamp(currentHunger + foodBuff, 0, maxHunger);
    }

    public void PlayPet()
    {
        currentHappy = Mathf.Clamp(currentHappy + playBuff, 0, maxHappy);
    }


}
