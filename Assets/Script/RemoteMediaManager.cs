using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteMediaManager : MonoBehaviour
{
    public Microsoft.MixedReality.WebRTC.Unity.VideoRenderer videoRenderer;
    public Microsoft.MixedReality.WebRTC.Unity.VideoReceiver videoReceiver;

    public void startVideoStream()
    {
        videoRenderer.StartRendering(videoReceiver.VideoTrack);
        Debug.Log("Start");
    }

    public void stopVideoStream()
    {
        videoRenderer.StopRendering(videoReceiver.VideoTrack);
        Debug.Log("stop");
    }
}
