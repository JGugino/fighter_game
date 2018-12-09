using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public string gameVersion = "0.0.1";

    private void Awake()
    {
        instance = this;
    }

    public void loadMainMenu()
    {
        UIController.instance.findMenuUI();

        ButtonController.instance.setMenuButtonListeners();

        UIControls.instance.setOptionsPanelActive(false);

        UIControls.instance.updateVersionText();
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
