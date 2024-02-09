using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Record : MonoBehaviour
{
    public static Record instance;
    public TextMeshProUGUI recordText;
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    public void SetRecord()
    {
        recordText.SetText(PlayerPrefs.GetInt("record").ToString());

    }
}
