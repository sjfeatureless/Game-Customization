using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Liam;
    public GameObject LiamHead;
    public GameObject[] MHair;
    public GameObject[] MTop;
    public GameObject[] MBot;
    public GameObject[] MShoes;

    public GameObject Kira;
    public GameObject KiraHead;
    public GameObject[] FHair;
    public GameObject[] FTop;
    public GameObject[] FBot;
    public GameObject[] FShoes;

    public bool gender;
    public int mh, mt, mb, ms, fh, ft, fb, fs;
    // Start is called before the first frame update
    void Start()
    {
        Kira.SetActive(false);

        LiamHead.SetActive(true);
        MHair[0].SetActive(true);
        MTop[0].SetActive(true);
        MBot[0].SetActive(true);
        MShoes[0].SetActive(true);

        gender = false;
    }

    // Update is called once per frame
    void Update()
    {
        MHair[mh].SetActive(true);
        MTop[mt].SetActive(true);
        MBot[mb].SetActive(true);
        MShoes[ms].SetActive(true);

        FHair[fh].SetActive(true);
        FTop[ft].SetActive(true);
        FBot[fb].SetActive(true);
        FShoes[fs].SetActive(true);

        for (int i = 0; i < MHair.Length; i++)
            {
            if (i == mh)
                continue;
            MHair[i].SetActive(false);
            }
        for (int i = 0; i < MTop.Length; i++)
        {
            if (i == mt)
                continue;
            MTop[i].SetActive(false);
        }
        for(int i = 0; i < MBot.Length; i++)
        {
            if (i == mb)
                continue;
            MBot[i].SetActive(false);
        }
        for (int i = 0; i < MShoes.Length; i++)
        {
            if (i == ms)
                continue;
            MShoes[i].SetActive(false);
        }

        for (int i = 0; i < FHair.Length; i++)
        {
            if (i == fh)
                continue;
            FHair[i].SetActive(false);
        }
        for (int i = 0; i < FTop.Length; i++)
        {
            if (i == ft)
                continue;
            FTop[i].SetActive(false);
        }
        for (int i = 0; i < FBot.Length; i++)
        {
            if (i == fb)
                continue;
            FBot[i].SetActive(false);
        }
        for (int i = 0; i < FShoes.Length; i++)
        {
            if (i == fs)
                continue;
            FShoes[i].SetActive(false);
        }

        if (gender == true)
        {
            Kira.SetActive(true);
            Liam.SetActive(false);
        }
        if (gender == false)
        {
            Liam.SetActive(true);
            Kira.SetActive(false);
        }
    }

    public void hair_next()
    {
        mh++;

        if (mh == MHair.Length)
            mh = 0; 

        fh++;
        if (fh == FHair.Length)
            fh = 0;
    }
    public void hair_prev()
    {
        mh--;
        if (mh == 0)
            mh = MHair.Length;

        fh--;
        if (fh == 0)
            fh = FHair.Length;
    }
    public void top_next()
    {
        mt++;

        if (mt == MTop.Length)
            mt = 0;

        ft++;
        if (ft == FTop.Length)
            ft = 0;
    }
    public void top_prev()
    {
        mt--;
        if (mt == 0)
            mt = MTop.Length;

        ft--;
        if (ft == 0)
            ft = FTop.Length;
    }
    public void bot_next()
    {
        mb++;

        if (mb == MBot.Length)
            mb = 0;

        fb++;
        if (fb == FBot.Length)
            fb = 0;
    }
    public void bot_prev()
    {
        mb--;
        if (mb == 0)
            mb = MBot.Length;

        fb--;
        if (fb == 0)
            fb = FBot.Length;
    }
    public void shoes_next()
    {
        ms++;

        if (ms == MShoes.Length)
            ms = 0;

        fs++;
        if (fs == FShoes.Length)
            fs = 0;
    }
    public void shoes_prev()
    {
        ms--;
        if (ms == 0)
            ms = MShoes.Length;

        fs--;
        if (fs == 0)
            fs = FShoes.Length;
    }
    public void gender_next()
    {
        if (gender == true)
            gender = false;
        else
        gender = true;
        
    }
    public void gender_prev()
    {
        if (gender == false)
            gender = true;
        else
            gender = false;
    }
}
