using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] private SkinManager skinManager;
  private float smoothTime = 0.1f;
  private float playerSPeed = 10f;
  private Vector3 velocity = Vector3.zero;
  private Vector3 direction;
  private Rigidbody2D playerBody;

  void Start()
  {
    GetComponent<SpriteRenderer>().sprite = skinManager.GetSelectedSkin().sprite;
    playerBody = GetComponent<Rigidbody2D>();
  }

  // Inputs are read here
  void Update()
  {
    direction.x = Input.GetAxis("Horizontal");
    direction.y = Input.GetAxis("Vertical");
  }

  // Phisycs is handled here
  void FixedUpdate()
  {
    Vector3 targetVelocity = direction * Time.fixedDeltaTime * playerSPeed * 30f;

    playerBody.velocity = Vector3.SmoothDamp(playerBody.velocity, targetVelocity, ref velocity, smoothTime);
  }
}
