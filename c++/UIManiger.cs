using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI healthValueText;
    public int healthValue;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        healthValueText.text = healthValue.ToString();
    }
    public void botton()
    {
        healthValue -= 5;
    }
    public void heal()
    {
        healthValue += 50;
    }
    public void poison()
    {
        InvokeRepeating(nameof(Ppoisondamage),0, 1f); 
    }
    public void Ppoisondamage ()
    {
        healthValue -= 5;
    }
}

