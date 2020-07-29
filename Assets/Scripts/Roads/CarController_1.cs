using UnityEngine;
using System.Collections;

public class CarController_1 : MonoBehaviour {

	float speedForce = 12f;
	float torqueForce = -170f;
	float driftFactorSticky = 0.9f;
	float driftFactorSlippy = 1;
	float maxStickyVelocity = 2.5f;
	public AudioSource motorSound;
	public AudioSource driftSound;
	Rigidbody2D rb;

	void Start () {
	}

	void Update() {
		if (Input.GetButton("Driving"))
		{
			FadeIn(motorSound);
            driftSound.Stop();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow) & (!driftSound.isPlaying | driftSound.volume < 0.2))
		{
			driftSound.volume = 1.0f;
			motorSound.volume = 0.0f;
			driftSound.Play();
		}
	}

	void FixedUpdate () {


		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		if (rb.velocity.magnitude < 1.5f)
		{
			FadeOut(motorSound);
			FadeOut(driftSound);
		}

		float driftFactor = driftFactorSticky;
		if(RightVelocity().magnitude > maxStickyVelocity) {
			driftFactor = driftFactorSlippy;
		}

		rb.velocity = ForwardVelocity() + RightVelocity()*driftFactor;

		if(Input.GetButton("Driving")) {
			rb.AddForce( transform.up * speedForce );

		}
		if(Input.GetButton("Stopping")) {
			rb.AddForce( transform.up * -speedForce/2f );

		}
		float tf = Mathf.Lerp(0, torqueForce, rb.velocity.magnitude / 2);
		rb.angularVelocity = Input.GetAxis("Horizontal") * tf;



	}

	Vector2 ForwardVelocity() {
		return transform.up * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.up );
	}

	Vector2 RightVelocity() {
		return transform.right * Vector2.Dot( GetComponent<Rigidbody2D>().velocity, transform.right );
	}

	void FadeIn(AudioSource audio)
	{
		audio.volume += 0.6f * Time.deltaTime;
		
	}

	void FadeOut(AudioSource audio)
	{
		if (audio.volume > 0f)
		{
			audio.volume -= 0.8f * Time.deltaTime;
		}
	}

	void OnCollisionEnter2D(Collision2D res)
    {
		// motorSound.volume = 0f;
		// driftSound.volume = 0f;
    }
}
