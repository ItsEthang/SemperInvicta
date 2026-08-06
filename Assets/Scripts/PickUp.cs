using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private GameObject pickupVFX;
    public void Collect()
    {
        PlayPickUpVfx();

        Destroy(gameObject);
    }

    private void PlayPickUpVfx()
    {
        Instantiate(
            pickupVFX,
            transform.position,
            transform.rotation
        );
    }
}
