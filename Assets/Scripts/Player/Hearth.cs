using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearth : MonoBehaviour
{
    public Move player;
    public Sprite[] spriteHearth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Move>();
    }
    public UnityEngine.UI.Image imageHearth;

    // Update is called once per frame
    void FixedUpdate()
    {
        imageHearth.sprite = spriteHearth[player.hearth];
    }
}
