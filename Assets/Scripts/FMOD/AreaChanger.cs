using UnityEngine;

public class AreaChanger : MonoBehaviour
{
    [SerializeField] private MusicArea area;
    public void ChangeArea()
    {
        AudioManager.instance.SetMusicArea(area);
        Debug.Log(area);
    }
}