using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{

    public GameObject keyNumber;
    public GameObject livesLeft;
    public GameObject energyLevel;

    int energy = 100;
    int keysCollected = 0;
    int livesRemaining = 3;

    // Start is called before the first frame update
    void Start()
    {
        KeyDisplay();
        LifeDisplay();
        EnergyDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        Keys();
        Lives();
        Energy();
    }

    void KeyDisplay()
    {
        Text txt = keyNumber.GetComponent<Text>();
        txt.text = "Keys Collected: " + keysCollected;
    }
    void LifeDisplay()
    {
        Text txt = livesLeft.GetComponent<Text>();
        txt.text = "Lives Remaining:  ";
    }
    void EnergyDisplay()
    {
        Text txt = energyLevel.GetComponent<Text>();
        txt.text = "Energy Level: " + keysCollected;
    }

    void Keys()
    {
        Text txt = keyNumber.GetComponent<Text>();

        if (Input.GetKey(KeyCode.W))
        {
            txt.text = "Keys Collected: " + keysCollected;
            keysCollected += 1;
        }
    }
    public void Lives()
    {
        Text txt = livesLeft.GetComponent<Text>();

        if (Input.GetKeyDown(KeyCode.E))
        {
            txt.text = "Lives Remaining:  ";
            livesRemaining -= 1;
        }


        if (livesRemaining < 2)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
        if (livesRemaining < 1)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
        if (livesRemaining < 0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    void Energy()
    {
        Text txt = energyLevel.GetComponent<Text>();

        if (Input.GetKey(KeyCode.R))
        {
            txt.text = "Energy Level: " + energy;
            energy -= 1;
        }
    }
}
