using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
   private static string[] wordList = { "testy","treatment","crack","immense","ray","sidewalk"
            ,"flash","jolly","sulky","redundant","shade","snobbish","spooky","anger","park","accessible"
            ,"gorgeous","seemly","milk","inject","carriage","early","whip","side","egg"
            ,"telephone","imported","unpack","crowd","gaze","burst","boat","envious","aftermath","worried","tumble","tempt"
            ,"nod","hard","amount","retire","end","canvas","wail","aunt","aromatic","slimy","large","determined","nappy" };
   public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
