using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] private GameObject lightSource;
    private void OnPlayerInteract()
    {
        // only turn light on if off
        if (lightSource.activeSelf == false)
            lightSource.SetActive(true);
    }
}
