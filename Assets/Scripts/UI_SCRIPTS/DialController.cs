using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialController : MonoBehaviour {

    public GameObject camera_object;

    public int dial_state = 3;
    public int max_dial_states;
    public GameObject HeadViewer;
    public GameObject TorsoViewer;
    public GameObject LegViewer;
    public GameObject ArmViewer;
    public GameObject WeaponViewer;
    public GameObject ArmorViewer;

    void Start () {
        if (dial_state == 1)
        {
            HeadViewer.SetActive(false);
            TorsoViewer.SetActive(false);
            LegViewer.SetActive(true);
            ArmViewer.SetActive(false);
            WeaponViewer.SetActive(false);
            ArmorViewer.SetActive(false);
        }
    }

    private void Update()
    {
        if (dial_state == 1)
        {
            HeadViewer.SetActive(false);
            TorsoViewer.SetActive(false);
            LegViewer.SetActive(true);
            ArmViewer.SetActive(false);
            WeaponViewer.SetActive(false);
            ArmorViewer.SetActive(false);
        }
        else if (dial_state == 2)
        {
            HeadViewer.SetActive(false);
            TorsoViewer.SetActive(true);
            LegViewer.SetActive(false);
            ArmViewer.SetActive(false);
            WeaponViewer.SetActive(false);
            ArmorViewer.SetActive(false);
        }
        else if (dial_state == 3)
        {
            HeadViewer.SetActive(true);
            TorsoViewer.SetActive(false);
            LegViewer.SetActive(false);
            ArmViewer.SetActive(false);
            WeaponViewer.SetActive(false);
            ArmorViewer.SetActive(false);
        }
        else if (dial_state == 4)
        {
            HeadViewer.SetActive(false);
            TorsoViewer.SetActive(false);
            LegViewer.SetActive(false);
            ArmViewer.SetActive(true);
            WeaponViewer.SetActive(false);
            ArmorViewer.SetActive(false);
        }
        else if (dial_state == 5)
        {
            HeadViewer.SetActive(false);
            TorsoViewer.SetActive(false);
            LegViewer.SetActive(false);
            ArmViewer.SetActive(false);
            WeaponViewer.SetActive(true);
            ArmorViewer.SetActive(false);
        }
        else if (dial_state == 6)
        {
            HeadViewer.SetActive(false);
            TorsoViewer.SetActive(false);
            LegViewer.SetActive(false);
            ArmViewer.SetActive(false);
            WeaponViewer.SetActive(false);
            ArmorViewer.SetActive(true);
        }
    }

    void OnMouseDown () {
        if (camera_object.GetComponent<WorkshopDrag>().tutorial_complete)
        {
            dial_state++;

            if (dial_state > max_dial_states)
            {
                dial_state = 1;
            }
        }
    }
}
