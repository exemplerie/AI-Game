using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yarn.Unity
{
    public class LevelLoader : MonoBehaviour
    {
        public Animator transition;
        public float transitionTime = 1f;

        [YarnCommand("next")]
        public void NextLevel()
        {
            StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
        }

        [YarnCommand("begin")]
        public void FirstLevel()
        {
            StartCoroutine(LoadScene(0));
        }

        IEnumerator LoadScene(int levelIndex)
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(levelIndex);
        }

        
    }
}