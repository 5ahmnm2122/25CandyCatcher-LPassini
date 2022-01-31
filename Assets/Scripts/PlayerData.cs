using UnityEngine;

[CreateAssetMenu(fileName ="PlayerData", menuName = "custom/PlayerData")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int playerScore;
}
