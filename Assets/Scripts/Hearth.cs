using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearth : MonoBehaviour
{
    public Move player;

    public Sprite[] spriteHearth;

    public UnityEngine.UI.Image imageHearth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Move>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        imageHearth.sprite = spriteHearth[player.hearth];
    }
}
