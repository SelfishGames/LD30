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
        gameManager.playerManager.gameObject.SetActive(false);

        StartCoroutine(ExplosionDelay (2f));
        gameManager.TriggerCollision();
        gameManager.levelManager.currentLevel++;
    	gameManager.levelManager.ArrangeObstacles();
    	gameManager.cameraManager.transform.GetChild(0).gameObject.SetActive(true);
        
    	col.transform.position = new Vector3(-25, 2.3f, 0);
    }

    IEnumerator ExplosionDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
}
