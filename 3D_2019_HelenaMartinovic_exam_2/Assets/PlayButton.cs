using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class PlayButton : MonoBehaviour
{
    public Button playButton;
    public PlayableDirector pd;
    public BigVegasController player;
    public Canvas canvas;

    public void PlayTimeline(){
        pd.Play();
        player.enabled = true;
        canvas.gameObject.SetActive(false);
    }
}
