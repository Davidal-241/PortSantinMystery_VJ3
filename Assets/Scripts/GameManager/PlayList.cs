using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayList", menuName = "ScriptableObjects/PlayList", order = 1)]
public class PlayList : ScriptableObject
{
    public AudioClip[] _sounds;
}
