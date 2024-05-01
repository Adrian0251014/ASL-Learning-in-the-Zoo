using UnityEngine;
using UnityEngine.Video;

public class VideoLooper : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public int loopCount = 3; // 想要视频循环的次数
    private int currentLoop = 0; // 当前循环计数

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
            videoPlayer.isLooping = false; // 到达循环次数，停止循环
            videoPlayer.Stop(); // 或者让它保持在最后一帧，不要调用Stop()
        }
    }
}
