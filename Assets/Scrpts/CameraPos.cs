using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    void LateUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0, 20, -15);
    }
}
