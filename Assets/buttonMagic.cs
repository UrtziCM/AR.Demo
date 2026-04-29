using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonMagic : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(SceneChanger.currentSceneToChange);
    }
}
