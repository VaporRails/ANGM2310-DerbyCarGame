using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WinVolume : MonoBehaviour{
    [SerializeField]
    private UIController uIController;
    public string winText = "You Win";
    [SerializeField]
    private AudioSource winSoundPrefab;
    private void Awake() {
        uIController = FindObjectOfType<UIController>();
    }
    private void OnTriggerEnter(Collider other) {
        other.gameObject.SetActive(false);

        if(uIController != null) {
            uIController.ShowWinText(winText);
        }

        if(winSoundPrefab != null) {
            SoundPlayer.Instance.PlaySFX(winSoundPrefab, transform.position);
        }
    }
}
