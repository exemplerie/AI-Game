using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text myText;
    [HideInInspector]
    public int inStock;
    public int myNumber = 3;
    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        if (myText.text != "3/3") {
            myText.text = inStock + "/" + myNumber;
        }
        
    }
}
