using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject car;
    // public Component script;
    public float x;
    public float y;
    public float z;
    public float rotZ;


    // Start is called before the first frame update
    public void GoToStart()
    {
        car.transform.position = new Vector3(x, y, z);
        car.transform.rotation = Quaternion.identity;
        car.transform.rotation = Quaternion.Euler(0, 0, -180);
    }
}
