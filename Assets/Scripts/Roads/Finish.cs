using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
	public GameObject FinishPanel;
	public GameObject Car;
	public GameObject timer;
	public GameObject sounds;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Rigidbody2D car = otherCollider.gameObject.GetComponent<Rigidbody2D>();
		if (car != null)
		{
			FinishPanel.SetActive(true);
			car.gameObject.SetActive(false);
			sounds.gameObject.SetActive(false);
		}
		if (timer != null)
        {
			timer.SetActive(false);
		}
	}
}
