using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMediaManager : MonoBehaviour
{
    public Microsoft.MixedReality.WebRTC.Unity.VideoRenderer videoRenderer;
    public Microsoft.MixedReality.WebRTC.Unity.WebcamSource webcamsource;

    public void startVideoStream()
    {
        videoRenderer.StartRendering(webcamsource.Source);
        Debug.Log("Start");
    }

    public void stopVideoStream()
    {
        videoRenderer.StopRendering(webcamsource.Source);
        Debug.Log("stop");
    }
}
