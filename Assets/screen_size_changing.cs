using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screen_size_changing : MonoBehaviour
{
    public Dropdown sizes;
    void Change()
    {
        if (sizes.value == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        if (sizes.value == 1)
        {
            Screen.SetResolution(1366, 768, true);
        }
        if (sizes.value == 2)
        {
            Screen.SetResolution(2560, 1440, true);
        }
    }
}
