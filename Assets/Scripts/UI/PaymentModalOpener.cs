using UnityEngine;

public class PaymentModalOpener : MonoBehaviour
{
    [SerializeField] private GameObject paymentModalRoot;

    public void Open()
    {
        paymentModalRoot.SetActive(true);
    }

    public void Close()
    {
        paymentModalRoot.SetActive(false);
    }
}