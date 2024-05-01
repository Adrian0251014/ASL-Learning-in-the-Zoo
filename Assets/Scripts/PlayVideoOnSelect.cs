using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayVideoOnSelect : MonoBehaviour
{
    public VideoPlayer videoPlayer; // ָ�����Quad��VideoPlayer���

    private void OnEnable()
    {
        GetComponent<XRBaseInteractable>().selectEntered.AddListener(PlayVideo);
    }

    private void OnDisable()
    {
        GetComponent<XRBaseInteractable>().selectEntered.RemoveListener(PlayVideo);
    }

    private void PlayVideo(SelectEnterEventArgs arg)
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }
}
