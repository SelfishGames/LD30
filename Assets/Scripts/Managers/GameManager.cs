using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public CameraManager cameraManager;
    public LevelManager levelManager;
    public PlayerManager playerManager;


    void Update()
    {
    	if(cameraManager.transform.GetChild(0).gameObject.activeSelf && Input.GetKeyDown("return"))
    	{
    		cameraManager.transform.GetChild(0).gameObject.SetActive(false);
    	}
    }
}
