using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity
{
    public class SmartSpeakerMusic : MonoBehaviour
    {
        public AudioSource pop;
        public AudioSource rock;
        public AudioSource classic;
        public AudioSource jazz;

        [YarnCommand("jazz")]
        public void Jazz()
        {
            jazz.Play();
        }

        [YarnCommand("pop")]
        public void Pop()
        {
            pop.Play();
        }

        [YarnCommand("classic")]
        public void Classic()
        {
            classic.Play();
        }

        [YarnCommand("rock")]
        public void Rock()
        {
            rock.Play();
        }
    }
}