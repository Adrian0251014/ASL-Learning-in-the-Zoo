using UnityEngine;
using UnityEngine.Video;

public class VideoLooper : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public int loopCount = 3; // ��Ҫ��Ƶѭ���Ĵ���
    private int currentLoop = 0; // ��ǰѭ������

    void Start()
    {
        if (videoPlayer)
        {
            videoPlayer.isLooping = true;
            videoPlayer.loopPointReached += CheckLoop;
        }
    }

    void CheckLoop(VideoPlayer vp)
    {
        currentLoop++;

        if (currentLoop >= loopCount)
        {
            videoPlayer.isLooping = false; // ����ѭ��������ֹͣѭ��
            videoPlayer.Stop(); // �����������������һ֡����Ҫ����Stop()
        }
    }
}
