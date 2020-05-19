using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{

    bool AlreadyPressed = false;
    public Animator ColorPicker;

    public Animator Button1;
    public Animator Button2;
    public Animator Button3;

    public Animator Fadeout;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColour()
    {
        ColorPicker.SetBool("MoveDown", true);
    }

    public void SceneSelect()
    {
        SceneManager.LoadScene("SceneSelect");
    }






    public void RegularScene()
    {
        StartCoroutine(RegularScene_());
    }
    public void SnowScene()
    {
        StartCoroutine(SnowScene_());
    }
    public void IceScene()
    {
        StartCoroutine(IceScene_());
    }





    IEnumerator RegularScene_()
    {
        Button1.SetBool("Pressed", true);
        Fadeout.SetBool("Fadeout", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("RegularScene");
    }
    IEnumerator SnowScene_()
    {
        Button2.SetBool("Pressed", true);
        Fadeout.SetBool("Fadeout", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("SnowScene");
    }
    IEnumerator IceScene_()
    {
        Button3.SetBool("Pressed", true);
        Fadeout.SetBool("Fadeout", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("IceScene");
    }
    
}
