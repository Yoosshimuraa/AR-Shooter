using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction<int> ScoreAdded;

    private int _score = 0;
    public void AddScore()
    {
        _score++;
        ScoreAdded?.Invoke(_score);
    }
}
