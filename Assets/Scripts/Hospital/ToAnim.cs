using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToAnim : MonoBehaviour
{
    public Counter myCounter;
    public Animation anim;

    void Update()
    {
        if (myCounter.inStock == myCounter.myNumber)
        {
            anim = GetComponent<Animation>();
            myCounter.myText.text = "3/3";
            anim.Play();
            myCounter.inStock = 0;
        }
    }
}
