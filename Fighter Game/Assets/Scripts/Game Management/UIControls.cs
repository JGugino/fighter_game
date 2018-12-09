using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControls : MonoBehaviour {

    public static UIControls instance;

    private void Awake()
    {
        instance = this;
    }

    public void updateVersionText()
    {
        UIController.instance.versionText.text = "version " + GameController.instance.gameVersion;
    }

    public void toggleOptionsPanel()
    {
        if (UIController.instance.otherOptionsPanel.activeSelf)
        {
            UIController.instance.otherOptionsPanel.SetActive(false);
        }
        else if (!UIController.instance.otherOptionsPanel.activeSelf)
        {
            UIController.instance.otherOptionsPanel.SetActive(true);
        }
    }

    public void setOptionsPanelActive(bool _active)
    {
        UIController.instance.otherOptionsPanel.SetActive(_active);
    }

}
