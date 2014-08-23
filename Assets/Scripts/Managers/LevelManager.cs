using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    //True is day, false is night
    [HideInInspector]
    public bool worldState = true;
    [HideInInspector]
    public int currentLevel = 0;
    public List<GameObject> levels = new List<GameObject>();

    //Camera vars
    private float targetRotation;
    private float rotateAmount = 55f;

    void Start ()
    {   

    }

    #region Update
    void Update()
    {
        //Changes worldStates
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (worldState)
            {
                worldState = false;
                targetRotation = 0f;
            }
            else
            {
                worldState = true;
                targetRotation = 90f;
            }
        }

        switch (worldState)
        {
        //Day
        case true:
        {
            if (targetRotation > 0)
            {
                Camera.main.transform.RotateAround(Vector3.zero, Vector3.right, rotateAmount * Time.deltaTime);
                targetRotation -= rotateAmount * Time.deltaTime;
            }
            return;
        }
        //Night
        case false:
        {
            if (targetRotation < 90)
            {
                Camera.main.transform.RotateAround(Vector3.zero, Vector3.right, -rotateAmount * Time.deltaTime);
                targetRotation += rotateAmount * Time.deltaTime;
            }
            return;
        }

        }

        #endregion
    }

    public void ArrangeObstacles()
    {
        foreach(GameObject go in levels)
        {
            go.SetActive(false);
            levels[currentLevel].SetActive(true);
        }
    }
}