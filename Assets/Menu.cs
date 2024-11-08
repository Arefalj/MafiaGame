using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject rolePage;
    public GameObject waitPage;
    public RawImage roleImage;
    public TMP_Text roleText;
    public List<string> CopyRoles;
    public List<Texture> CopyRolesImages;
    public List<string> Roles;
    public List<Texture> RolesImages;
    public List<string> Rolesplus2;
    public List<Texture> Rolesplus2Images;
    public List<string> RolesAnotherplus2;
    public List<Texture> RolesAnotherplus2Images;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<Roles.Count; i++){
            CopyRoles.Add(Roles[i]);
            CopyRolesImages.Add(RolesImages[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickButtonStart8()
    {
        mainPage.SetActive(false);
        rolePage.SetActive(false);
        waitPage.SetActive(true);
    }
    public void ClickButtonStart10()
    {
        mainPage.SetActive(false);
        rolePage.SetActive(false);
        waitPage.SetActive(true);
        Roles.Add(Rolesplus2[0]);
        Roles.Add(Rolesplus2[1]);
        RolesImages.Add(Rolesplus2Images[0]);
        RolesImages.Add(Rolesplus2Images[1]);
    }
    public void ClickButtonStart12()
    {
        mainPage.SetActive(false);
        rolePage.SetActive(false);
        waitPage.SetActive(true);
        Roles.Add(Rolesplus2[0]);
        Roles.Add(Rolesplus2[1]);
        Roles.Add(RolesAnotherplus2[0]);
        Roles.Add(RolesAnotherplus2[1]);
        RolesImages.Add(Rolesplus2Images[0]);
        RolesImages.Add(Rolesplus2Images[1]);
        RolesImages.Add(RolesAnotherplus2Images[0]);
        RolesImages.Add(RolesAnotherplus2Images[1]);
    }
    public void ClickButtonRoleView()
    {
        if (Roles.Count == 0)
        {
            rolePage.SetActive(false);
            waitPage.SetActive(false);
            mainPage.SetActive(true);
            for(int i = 0; i<CopyRoles.Count; i++){
                Roles.Add(CopyRoles[i]);
                RolesImages.Add(CopyRolesImages[i]);
            }
            return;
        }
        int a = Random.Range(0, Roles.Count);
        roleImage.texture = RolesImages[a];
        roleText.text = Roles[a];
        Roles.RemoveAt(a);
        RolesImages.RemoveAt(a);
        waitPage.SetActive(false);
        rolePage.SetActive(true);
    }
    public void ClickButtonSeen()
    {
        waitPage.SetActive(true);
        rolePage.SetActive(false);
        mainPage.SetActive(false);
    }

}
