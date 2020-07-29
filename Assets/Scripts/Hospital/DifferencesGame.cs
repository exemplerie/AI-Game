using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifferencesGame : MonoBehaviour
{
    private Button myButton;
    private Image myImage;
    public Counter myCounter;

    void Start()
    {
        myButton = GetComponent<Button>();
        myImage = GetComponent<Image>();
        myButton.onClick.AddListener(MyVoid);
    }

    void MyVoid()
    {
        myCounter.inStock += 1;
        myImage.color = Color.white;
        myButton.enabled = false;
    }
}
