using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] private GameObject lightSource;
    [SerializeField] private GameObject particleSource;
    private void OnPlayerInteract()
    {
        // only turn light on if off
        if (lightSource.activeSelf == false)
            lightSource.SetActive(true);

        if (particleSource.activeSelf == false)
            particleSource.SetActive(true);
    }
}
