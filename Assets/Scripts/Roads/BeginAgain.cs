using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginAgain : MonoBehaviour {

	public Restart restart;
	public UnityEngine.Object carPrefab;
	private GameObject respawn;
	private GameObject myCamera;
	public AudioSource crashSound;

	private void Start()
    {
        respawn = GameObject.Find("Respawn");
		myCamera = GameObject.Find("Main Camera");
	}

    void OnTriggerEnter2D (Collider2D colInfo)
	{
		if (colInfo.CompareTag("Collidable"))
		{
			gameObject.SetActive(false);
			crashSound.Play();
			Respawn();
		}
	}

	public void Respawn()
    {
		GameObject carCopy = (GameObject)Instantiate(carPrefab, respawn.transform.position, Quaternion.identity);
		carCopy.name = gameObject.name;
		carCopy.SetActive(true);
		carCopy.GetComponent<BeginAgain>().crashSound = crashSound;
		myCamera.GetComponent<CameraController>().target = carCopy.transform;
		Destroy(gameObject);

	}

}
