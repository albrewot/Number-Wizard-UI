using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gameplay : MonoBehaviour {

    //Global Variables
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TMPro.TextMeshProUGUI guessTextComponent;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    public void OnPressHigher() {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess - 1;
        NextGuess();
    }

    //Initializing the Wizard
    void StartGame() {
        NextGuess();
        Debug.Log("Initializing Game...");
    }

    // Update is called once per frame
    void Update() {

    }

    void NextGuess() {
        if(min <= max) {
            guess = Random.Range(min, max);
            guessTextComponent.text = guess.ToString();
            Debug.Log("Updated guess" + guess);
        } else {
            Debug.LogWarning("Minimum Number is Higher than Maximum Number");
        }
    }
}
