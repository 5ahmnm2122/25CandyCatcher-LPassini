using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    
    public PlayerData playerdata;

    
    public Button playButton;
    public InputField nameSpace;
    public string input;

    
    public void GetNameData ()
    {
        input = nameSpace.text;
        if (input != "")
        {
            playButton.interactable = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playButton.interactable = false;
    }

    public void SaveData ()
    {
        playerdata.playerName = input;
        SceneManager.LoadScene("MainScene");
    }
}
