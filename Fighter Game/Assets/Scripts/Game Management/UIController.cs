using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour {

    public static UIController instance;

    [HideInInspector]
    public GameObject otherOptionsPanel;

    [HideInInspector]
    public Button playButton, trainingButton, localButton, matchmakingButton, customButton, settingsButton, exitButton;

    [HideInInspector]
    public TextMeshProUGUI versionText;

    private void Awake()
    {
        instance = this;
    }

    public void findMenuUI()
    {
        versionText = GameObject.FindGameObjectWithTag("Version Text").GetComponent<TextMeshProUGUI>();

        otherOptionsPanel = GameObject.FindGameObjectWithTag("Other Options");

        playButton = GameObject.FindGameObjectWithTag("Play Button").GetComponent<Button>();
        trainingButton = GameObject.FindGameObjectWithTag("Training Button").GetComponent<Button>();
        localButton = GameObject.FindGameObjectWithTag("Local Button").GetComponent<Button>();
        matchmakingButton = GameObject.FindGameObjectWithTag("Matchmaking Button").GetComponent<Button>();
        customButton = GameObject.FindGameObjectWithTag("Custom Button").GetComponent<Button>();
        settingsButton = GameObject.FindGameObjectWithTag("Setting Button").GetComponent<Button>();
        exitButton = GameObject.FindGameObjectWithTag("Exit Button").GetComponent<Button>();
    }
}
