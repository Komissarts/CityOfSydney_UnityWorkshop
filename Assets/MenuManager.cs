using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public int PhlappyBordBuildIndex = 3;
    public int CuberunBuildIndex = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SceneManager.GetSceneByBuildIndex(PhlappyBordBuildIndex);
        Debug.Log(SceneManager.GetSceneByBuildIndex(PhlappyBordBuildIndex));
        Debug.Log(SceneManager.GetSceneByBuildIndex(CuberunBuildIndex));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToBord()
    {
        SceneManager.LoadScene("Phlappy Bord");
    }

    public void CubeRun()
    {
        SceneManager.LoadScene("CubeRunner Level 1");
    }
}
