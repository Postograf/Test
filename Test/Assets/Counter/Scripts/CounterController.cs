using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterController : MonoBehaviour
{
    [SerializeField] private CounterModel _model;

    public int Add()
    {
        _model.Count++;
        return _model.Count;
    }
}
