using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject siyahEkran;
    public GameObject butonlar;
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    private int index = 0; // Baþlangýç indeksi 0 olmalý
    public void ButonaTiklandiginda()
    {
        butonlar.SetActive(false); // Butonlarý yok et

        // Butona bastýðýn an yazýyý da bir ileri at
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = lines[index];
        }
    }
    void Start()
    {
        // Panel açýldýðýnda ilk satýrý göster
        if (lines.Length > 0)
        {
            dialogueText.text = lines[0];
        }
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            NextLine();
        }
        
    }

   void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = lines[index];

            if (index == 2)
            {
                butonlar.SetActive(true);
            }
        }
        else
        {
            // BURAYA EKLE:
            siyahEkran.SetActive(true); 
            gameObject.SetActive(false);
            index = 0;
        }
    }
}