using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    UIPages Previouspage;
    UIPages Currentpage;
    // Start is called before the first frame update
    void Start()
    {
        UIPages[] pages = GetComponentsInChildren<UIPages>(true);
        //show the first page and disable other pages
        pages[1].gameObject.SetActive(true);
        pages[0].gameObject.SetActive(false);

        for (int i = 2; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
        Currentpage = pages[1];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Switchpage(UIPages nextpages)
    {
        Previouspage = Currentpage;
        Currentpage.gameObject.SetActive(false);
        nextpages.gameObject.SetActive(true);
        Currentpage = nextpages;
    }

    public void gopreviouspage()
    { Switchpage(Previouspage); }

}
