﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

    public List<AudioClip> audio_clips;

    private AudioSource m_asource;
    public GameObject hammerhead;

    void Awake()
    {
        m_asource = gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Collider col = collision.contacts[0].thisCollider;
        if (col.gameObject == hammerhead)
        {
            int i = Random.Range(0, audio_clips.Count);
            m_asource.PlayOneShot(audio_clips[i]);
        }
    }
}
