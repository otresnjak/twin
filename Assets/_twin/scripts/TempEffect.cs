﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TempEffect : MonoBehaviour
{
    public float Lifespan = 5.0f;
    public GameObject[] Visual;
    public AudioClip[] SoundEffect;

    void Start()
    {
        if (Visual.Length > 0)
        {
            if (Visual.Length > 0)
            {
                var vis = Instantiate(RandomUtils.Pick(Visual), transform);
                vis.transform.localPosition = Vector3.zero;
                vis.transform.localRotation = Quaternion.identity;
            }
        }

        if (SoundEffect.Length > 0)
            GetComponent<AudioSource>().PlayOneShot(RandomUtils.Pick(SoundEffect));
        Destroy(gameObject, Lifespan);
    }
}
