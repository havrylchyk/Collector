using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using System;
using System.IO;

namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerData
    {
        public string Name;
        public int cats;
    }
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private int Cats;
        [SerializeField] private AudioSource audioSource;
        public Action<int> OnCatsAmountcanged;

        private void Start()
        {
            var path = Application.persistentDataPath + "/playerData.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                var playerData = JsonUtility.FromJson<PlayerData>(json);

                Cats = playerData.cats;
            }
            else
                Cats = 0;

            OnCatsAmountcanged?.Invoke(Cats);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Catch>(out var cat))
            {
                var catValue = cat.Collect();
                Cats += catValue;

                if (audioSource != null)
                {
                    audioSource.Play();
                }

                var json = JsonUtility.ToJson(new PlayerData() { Name = "Wizard", cats = Cats });


                var path = Application.persistentDataPath + "/playerData.json";
                File.WriteAllText(path, json);

                OnCatsAmountcanged?.Invoke(Cats);
            }
        }

    }

}
