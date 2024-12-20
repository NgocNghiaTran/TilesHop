using UnityEngine;
using UnityEngine.UI;

public class SongHolder : MonoBehaviour
{
    [SerializeField] Song song;
    [SerializeField] Text songName;

    public void SetSong(Song newSong)
    {
        song = newSong;
        //UpdateInfo();
    }

    void Start()
    {
        //PlaySong();
    }

    //public void UpdateInfo()
    //{
    //    songName.text = song.name;
    //}

    public void PlaySong()
    {
        LevelGenerator.Instance.currentSong = song;
        LevelGenerator.Instance.StartWithSong();
        UIManager.Instance.CloseMenu();
    }
}
