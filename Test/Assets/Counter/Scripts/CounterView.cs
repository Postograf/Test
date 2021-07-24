using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    [SerializeField] private CounterController _controller;
    [SerializeField] private Text _count;

    private void Start()
    {
        _count.text = "";
    }

    public void OnButtonClick()
    {
        _count.text = $"{_controller.Add()}";
    }
}
