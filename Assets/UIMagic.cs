using System;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation.Samples;

public class UIMagic : MonoBehaviour
{
    private Transform polyTransform;
    [SerializeField]
    private PlaceOnPlane placer;
    private GameObject spawnedObject => GameObject.FindGameObjectWithTag("Disposable");


    [SerializeField]
    private GameObject patata;
    [SerializeField]
    private GameObject zanahoria;

    [SerializeField]
    private TMP_Text polyText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        polyTransform = GameObject.Find("Trackables").transform;
    }

    // Update is called once per frame
    void Update()
    {
        polyText.text = $"poly count={polyTransform.childCount}";
    }

    public void PolyReset()
    {
        foreach (Transform t in polyTransform.GetComponentInChildren<Transform>())
        {
            Destroy(t.gameObject);
        }
        Destroy(spawnedObject);
    }

    public void ChangePrefab(Int32 objectId)
    {
        
        Destroy(spawnedObject); 
        switch (objectId)
        {
            case 0:
                placer.placedPrefab = patata;
                break;
            case 1:
                placer.placedPrefab = zanahoria;
                break;
        }
    }

}
