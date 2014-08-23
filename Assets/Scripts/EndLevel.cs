using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour
{
	public GameManager gameManager;
    // Update is called once per frame
    void Update ()
    {

    }


    void OnTriggerEnter(Collider col)
    {
        gameManager.levelManager.currentLevel++;
    	gameManager.levelManager.ArrangeObstacles();
    	gameManager.cameraManager.transform.GetChild(0).gameObject.SetActive(true);
    	
    	col.transform.position = new Vector3(-25, 2.3f, 0);
    }
}
