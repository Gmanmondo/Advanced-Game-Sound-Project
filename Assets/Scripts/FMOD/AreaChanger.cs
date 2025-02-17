using UnityEngine;

public class AreaChanger : MonoBehaviour
{
    public void ChangeArea()
    {
        AudioManager.instance.SetMusicArea(MusicArea.RUNNING_MUSIC);
        Debug.Log("Changed area");
    }
}