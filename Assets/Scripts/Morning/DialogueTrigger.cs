using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yarn.Unity
{

    public class DialogueTrigger : MonoBehaviour
    {
        [YarnCommand("next")]
        public void NextScene()
        {
            StartCoroutine(Waiting());
        }

        IEnumerator Waiting()
        {
            yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }
}
