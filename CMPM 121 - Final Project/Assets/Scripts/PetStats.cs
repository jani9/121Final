using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    //UI Text
    public Text hungerText;
    public Text happyText;
    public Text cleanText;

    //Hunger
    public int currentHunger;
    public int maxHunger = 100;
    public int hungerRate = 5;
    public int foodBuff = 10;

    public GameObject apple; // Food for fruitant

    //Happiness
    public int currentHappy;
    public int maxHappy = 100;
    public int happyRate = 2;
    public int playBuff = 10;

    //Cleanliness
    public int currentClean;
    public int maxClean = 100;
    public int cleanRate = 1;
    public int cleanArea = 50;

    //Time
    private float time = 0f;
    private float rate = 2f;

    void Start()
    {
        currentHunger = maxHunger;
        currentHappy = maxHappy;
        currentClean = maxClean;
        apple.SetActive(false);
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time > rate)
        {
            time = 0;
            LowerStats();
        }
        SetText();
    }

    void SetText()
    {
        hungerText.text = "Fullness: " + currentHunger.ToString();
        happyText.text = "Happy: " + currentHappy.ToString();
        cleanText.text = "Cleanliness: " + currentClean.ToString();

    }

    void LowerStats()
    {
        currentHunger = Mathf.Clamp(currentHunger - hungerRate, 0, maxHunger);
        currentHappy = Mathf.Clamp(currentHappy - happyRate, 0, maxHappy);
        currentClean = Mathf.Clamp(currentClean - cleanRate, 0, maxClean);

    }

    public void FeedPet()
    {
        SpawnApple();
    }

    public void PlayPet()
    {
        currentHappy = Mathf.Clamp(currentHappy + playBuff, 0, maxHappy);
    }

    public void CleanPet()
    {
        currentClean = Mathf.Clamp(currentClean + cleanArea, 0, maxClean);
    }

    void SpawnApple()
    {
        apple.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        currentHunger = Mathf.Clamp(currentHunger + foodBuff, 0, maxHunger);
        apple.SetActive(false);
        apple.transform.position = new Vector2 (0.1f, 0.1f);
    }
}
