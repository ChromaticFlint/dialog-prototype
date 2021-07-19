using UnityEngine;

public class PlayerX : MonoBehaviour
{
  //   [SerializeField] private DialogueUI dialogueUI;

  //   private const float MoveSpeed = 10f;

  //   public DialogueUI DialogueUI => dialogueUI;

  //   public IInteractable Interactable { get; set; }

  //   private Rigidbody2D rb;

  //   private void Start()
  //   {
  //     rb = GetComponent<Rigidbody2D>();
  //   }

  //   private void Update()
  //   {
  //     // Prevents movement and functionality past this line if the dialogue is open.
  //     if (dialogueUI.IsOpen) return;

  //     // Movement
  //     Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

  //     rb.MovePosition(rb.position + input.normalized * (MoveSpeed * Time.fixedDeltaTime));

  //     // Interaction
  //     if (Input.GetKeyDown(KeyCode.E))
  //     {
  //       Interactable?.Interact(this);
  //     }
  //   }
}
