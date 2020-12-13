using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
  [SerializeField] private GameController gameController;
  private Vector3 screenBounds;

  void Start()
  {
    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 0.9f, Screen.height * 0.9f, 0));
  }

  void OnTriggerEnter2D(Collider2D collider)
  {
    if (collider.CompareTag("Player"))
    {
      gameController.AddCoins();
      float x = Random.Range(-screenBounds.x, screenBounds.x);
      float y = Random.Range(-screenBounds.y, screenBounds.y);
      transform.position = new Vector3(x, y, transform.position.z);
    }
  }

}
