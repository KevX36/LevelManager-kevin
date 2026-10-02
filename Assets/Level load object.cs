using UnityEngine;

public class Levelloadobject : MonoBehaviour
{
    public string levelToLoad;
    public void LoadLevel()
    {
        GameManager.instance.levelManager.LoadLevel(levelToLoad);
    }
}
