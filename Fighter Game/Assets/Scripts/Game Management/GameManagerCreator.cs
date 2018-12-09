using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCreator : MonoBehaviour {

    public GameObject gameManagerPrefab;


    private void Awake()
    {
        if (!GameObject.FindGameObjectWithTag("Game Manager"))
        {
            GameObject manager = Instantiate(gameManagerPrefab, Vector3.zero, Quaternion.identity);

            DontDestroyOnLoad(manager);
        }
        else
        {
            Debug.Log("Game Manager already exists");
            return;
        }
    }

    private void Start()
    {
        GameController.instance.loadMainMenu();
    }
}
