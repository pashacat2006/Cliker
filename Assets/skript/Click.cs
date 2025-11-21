using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Click : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public int namber;
    private int clickCount = 1;
    public TextMeshProUGUI str;
    private int clickCount1;
    public TextMeshProUGUI CLickWhatCount;
    private int clickCount2 = 0;
    public GameObject clickA;
    public GameObject rewardA;
    private bool reward1 = false;
    private bool reward2 = false;
    private bool reward3 = false;
    private bool reward4 = false;
    private bool reward5 = false;
    private Volume volume;
    //public void Update()
    //{
    //    clickA.GetComponent<AudioSource>().volume = volume.volume;
    //    rewardA.GetComponent<AudioSource>().volume = volume.volume;
    //}
    public void moseClick()
    {
        namber += clickCount;
        Instantiate(clickA, transform.position, Quaternion.identity);
        textMeshPro.text = namber.ToString();
        reward();
    }
    public void reward()
    {
        if (namber == 1 && reward1 == false)
        {
            print("One click");
            reward1 = true;
        } else if (namber == 20 && reward2 == false) {
            Instantiate(rewardA, transform.position, Quaternion.identity);
            reward2 = true;
        } else if (namber == 50 && reward3 == false)
        {
            Instantiate(rewardA, transform.position, Quaternion.identity);
            reward3 = true;
        } else if (namber == 85 && reward4 == false)
        {
            Instantiate(rewardA, transform.position, Quaternion.identity);
            reward4 = true;
        } else if (namber == 130 && reward5 == false)
        {
            Instantiate(rewardA, transform.position, Quaternion.identity);
            reward5 = true;
        }
    }
    public void Upgrade()
    {
        if (namber >= clickCount1)
        {
            if (clickCount1 >= 500)
            {
                str.text = "Max";
                CLickWhatCount.text = "Max";
            }
            else
            {
                namber -= clickCount1;
                clickCount1 += 18;
                str.text = clickCount1.ToString();
                str.text += "$";
                clickCount2++;
                CLickWhatCount.text = clickCount2.ToString();
                clickCount++;
                textMeshPro.text = namber.ToString();
            }
        }
    }
}
