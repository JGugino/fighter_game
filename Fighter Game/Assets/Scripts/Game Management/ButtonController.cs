using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public static ButtonController instance;

	void Awake () {
        instance = this;
	}

    public void setMenuButtonListeners()
    {
        UIController.instance.playButton.onClick.AddListener(delegate { UIControls.instance.toggleOptionsPanel(); });
        UIController.instance.exitButton.onClick.AddListener(delegate { GameController.instance.exitGame(); });
    }
}
