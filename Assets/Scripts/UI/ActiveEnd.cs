using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity
{
    public class ActiveEnd : MonoBehaviour
{
    public GameObject panel;
    public bool once;

        void Start()
        {
            if (once == true)
            {
                Invoke("ActivePanel", 1.5f);
            };
        }

        [YarnCommand("note")]
        public void ActivePanel()
        {
            panel.SetActive(true);
        }
    }
}