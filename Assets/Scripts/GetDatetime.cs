using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class GetDatetime : MonoBehaviour
{

    [SerializeField]
    private GameObject _hour;
    [SerializeField]
    private GameObject _minute;
    [SerializeField]
    private GameObject _second;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        DateTime localDate = DateTime.Now;
        var cultureName = "zh-TW";
        var culture = new CultureInfo(cultureName);
        Debug.Log("localDate: " + localDate.ToString(culture));
        _hour.transform.localRotation = Quaternion.Euler(localDate.Hour * 30, 0, 0);
        _minute.transform.localRotation = Quaternion.Euler(localDate.Minute * 6, 0, 0);
        _second.transform.localRotation = Quaternion.Euler(localDate.Second * 6, 0, 0);
    }
}
