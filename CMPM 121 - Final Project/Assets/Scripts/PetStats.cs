using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    public Text hungerText;

    public int currentHunger;
    public int maxHunger = 100;
    public int hungerRate = 5;
    public int foodBuff = 10;

    private float time = 0f;
    private float rate = 2f;



    // Start is called before the first frame update
    void Start()
    {
        currentHunger = maxHunger;
        Debug.Log(currentHunger);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > rate)
        {
            time = 0;
            LowerHunger();
            Debug.Log(currentHunger);
        }
        SetHungerText();

    }

    void SetHungerText()
    {
        hungerText.text = "Hunger: " + currentHunger.ToString();
    }

    void LowerHunger()
    {
        currentHunger = Mathf.Clamp(currentHunger - hungerRate, 0, maxHunger);

    }

    public void FeedPet()
    {
        currentHunger = Mathf.Clamp(currentHunger + foodBuff, 0, maxHunger);
    }
}
