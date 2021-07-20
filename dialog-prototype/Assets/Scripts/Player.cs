using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] private DialogueUI dialogueUI;

  public PlayerController controller;
  [SerializeField] private float moveSpeed = 40f;
  private float horizontalMove = 0f;
  private bool jump = false;
  private bool crouch = false;

  // Lazy Win Condition
  [SerializeField] private GameObject winText;

  public DialogueUI DialogueUI => dialogueUI;

  public IInteractable Interactable { get; set; }

  private void Update()
  {
    // Prevents movement and functionality past this line if the dialogue is open.
    if (dialogueUI.IsOpen) return;

    // Input
    horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

    // Jump
    if (Input.GetButtonDown("Jump"))
    {
      jump = true;
    }

    // Crouch
    if (Input.GetButtonDown("Crouch"))
    {
      crouch = true;
    }
    else if (Input.GetButtonUp("Crouch"))
    {
      crouch = false;
    }

    // Interaction
    if (Input.GetKeyDown(KeyCode.E))
    {
      Interactable?.Interact(this);
    }
  }

  private void FixedUpdate()
  {
    controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
    jump = false;
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Pickup"))
    {
      Destroy(other.gameObject);
    }

    if (other.CompareTag("Win")) {
      winText.SetActive(true);
    }
  }
}
