using System;
using UnityEngine;
using TMPro;

namespace ObserverDesignPattern.Concretes
{
    public class UIObserverPattern : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI objectText;
        [SerializeField] private TextMeshProUGUI doorText;

        private void OnEnable()
        {
            PlayerObserver.OnPlayerCollect += ShowObjectText;
            PlayerObserver.OnPlayerInteractDoor += ShowDoorText;
        }

        private void OnDisable()
        {
            PlayerObserver.OnPlayerCollect -= ShowObjectText;
            PlayerObserver.OnPlayerInteractDoor -= ShowDoorText;
        }

        private void ShowObjectText(int amount) => objectText.text = "Total Objects: " + amount;
        private void ShowDoorText(int amount) => doorText.text = "Door Click: " + amount;
    }
}
