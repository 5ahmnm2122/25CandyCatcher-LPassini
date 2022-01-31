using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public PlayerData playerdata;

    public Text playerName;
    public Text playerscore;
   
    void Start()
    {
        playerName.text = playerdata.playerName;
        playerscore.text = playerdata.playerScore.ToString();  
    }

    public void Restart ()
    {
        SceneManager.LoadScene("StartScene");
    }
}
