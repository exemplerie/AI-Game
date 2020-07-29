using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class CircleSlider : MonoBehaviour
{
    public GameObject dialogue;
    [SerializeField] Transform handle;
    [SerializeField] Image fill;
    [SerializeField] Text valTxt;
    Vector3 mousePos;

    public void onHandleDrag ()
    {
        if (!dialogue.activeInHierarchy)
        {
            mousePos = Input.mousePosition;
            Vector2 dir = mousePos - handle.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            angle = (angle <= 0) ? (360 + angle) : angle;
            if (angle <= 225 || angle >= 305)
            {
                Quaternion r = Quaternion.AngleAxis(angle + 135f, Vector3.forward);
                handle.rotation = r;
                angle = ((angle >= 305) ? (angle - 360) : angle) + 42;
                fill.fillAmount = 0.85f - (angle / 360f);
                valTxt.text = string.Format("{0:N1}", System.Math.Round(85 + (fill.fillAmount * 100) / 3, 1)).Replace(',', '.').ToString();
            }
        }
    }
}
