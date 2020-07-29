using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity.Example
{
    public class RadioDialogs : MonoBehaviour
    {
        private int num = 0;
        public YarnProgram dialog1;
        public YarnProgram dialog2;
        public YarnProgram dialog3;

        public AudioSource audio1;
        public AudioSource audio2;
        public AudioSource audio3;
        public GameObject dialogue;

        public void ToDialog()
        {
            if (!dialogue.activeInHierarchy)
            {
                num++;
                DialogueRunner dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
                if (num == 1)
                {
                    dialogueRunner.Add(dialog1);
                    dialogueRunner.StartDialogue("Start1");
                    audio1.Play();
                }
                if (num == 2)
                {
                    dialogueRunner.Add(dialog2);
                    dialogueRunner.StartDialogue("Start2");
                    audio1.Stop();
                    audio2.Play();
                }
                if (num == 3)
                {

                    dialogueRunner.Add(dialog3);
                    dialogueRunner.StartDialogue("Start3");
                    audio2.Stop();
                    audio3.Play();

                }
            }
        }
    }
}
