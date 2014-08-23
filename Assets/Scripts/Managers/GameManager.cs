using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public CameraManager cameraManager;
    public LevelManager levelManager;

    // General public objects
    public GameObject playerExplosion;
    public Transform player;
    public PlayerManager playerManager;

    // Private

    void Update()
    {
    	if(cameraManager.transform.GetChild(0).gameObject.activeSelf && Input.GetKeyDown("return"))
    	{
    		cameraManager.transform.GetChild(0).gameObject.SetActive(false);
    	}
    }

    public void TriggerCollision()
    {
        // Set the location of the explosion.
        playerExplosion.transform.localPosition = player.transform.localPosition;
        // Play the explosion.
        playerExplosion.SetActive(true);
    }
}
