using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgoundMusic : MonoBehaviour
{
    private static BackgoundMusic backgoundMusic;

    void Awake()
    {
        if (backgoundMusic == null)
        {
            backgoundMusic = this;
            DontDestroyOnLoad(backgoundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
