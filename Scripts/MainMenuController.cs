using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
  public void LoadGame() => SceneManager.LoadScene("GameScene");
  public void LoadShop() => SceneManager.LoadScene("ShopScene");
}
