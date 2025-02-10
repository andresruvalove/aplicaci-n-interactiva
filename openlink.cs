using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string url;  

    public void OpenWebsite()
    {
        Application.OpenURL(url);
    }
}