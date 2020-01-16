using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private GameObject player;
    private Movement movement;
    public TextMeshProUGUI numberBullets;
    public TextMeshProUGUI numberMolotov;

    private int numberOfMolotov;
    private int numberOfKeys;

    private bool lanter;
    // Start is called before the first frame update
    void Start()
    {
        //numberBullets = GetComponent<TextMeshProUGUI>();
       // numberMolotov = GetComponent<TextMeshProUGUI>();
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Movement>();
        movement = player.GetComponentInParent<Movement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        numberBullets.text = movement.getWeapon().getAmmo().ToString();
        numberMolotov.text = movement.getWeapon().totalGoldBullets.ToString();
    }
}
