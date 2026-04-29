using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public static string currentSceneToChange = "";
    [SerializeField]
    private string targetScene;

    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.gameObject.SetActive(true);
        // establecer on click cambio de escena
        currentSceneToChange = targetScene;
    }

    private void OnTriggerExit(Collider other)
    {
        canvas.gameObject.SetActive(false);
        currentSceneToChange = "";
    }

    public UnityAction ChangeScene(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
        return null;
    }
}
