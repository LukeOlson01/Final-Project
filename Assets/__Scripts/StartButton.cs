using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public GameObject FantasyBee;

    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(SpawnFantasyBee);
        }
    }

    private void SpawnFantasyBee()
    {
        Instantiate(FantasyBee);
        gameObject.SetActive(false);
    }
}