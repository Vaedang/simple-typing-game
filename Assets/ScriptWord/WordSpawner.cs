﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

   public WordDisplay SpawWord()
    {
        Vector3 randomPosition = new Vector3(-8f,Random.Range(-4f,4f));


        GameObject wordObj = Instantiate(wordPrefab,randomPosition,Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
