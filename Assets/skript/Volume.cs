using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Volume : MonoBehaviour
{
    // Start is called before the first frame update
    public float volume = 1;
    public void SliderVolume(float volumeFloat)
    {
        volume = volumeFloat;
        print(volume);
    }

}
