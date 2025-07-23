using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ECM.Controllers;

public class AmmoCounter : MonoBehaviour
{
    [SerializeField]
    public Image line;
    public Image square;

    [SerializeField]
    public TMP_Text ammoText;

    protected Weapon weaponScript;
    float ammoRatio;

    private void OnEnable()
    {
        weaponScript = this.transform.GetComponentInParent<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = weaponScript.bulletsLeft.ToString();

        ammoRatio = (float)weaponScript.bulletsLeft / (float)weaponScript.magazineSize;
        Debug.Log(ammoRatio);

        line.material.mainTextureScale = new Vector2(ammoRatio, 1f);

        if (ammoRatio < 0.4)
        {
            //Line Color
            line.material.SetColor("_TintColor", new Color32(237, 76, 103, 255));
            //line.material.SetColor("_EmissionColor", new Color32(237, 76, 103, 255));

            //Square Color
            square.material.SetColor("_Color", new Color32(237, 76, 103, 255));
            square.material.SetColor("_EmissionColor", new Color32(237, 76, 103, 255));

            //Ammo Text Color
            ammoText.color = new Color32(237, 76, 103, 255);
            ammoText.fontMaterial.SetColor(ShaderUtilities.ID_GlowColor, new Color32(237, 76, 103, 255));

            //circleImg.color = new Color32(237, 76, 103, 255);
            //ammoText.color = new Color32(237, 76, 103, 255);
        }
        else
        {
            //Line Color
            line.material.SetColor("_TintColor", new Color32(26, 211, 238, 255));
            //line.material.SetColor("_EmissionColor", new Color32(26, 211, 238, 255));

            //Square Color
            square.material.SetColor("_Color", new Color32(26, 211, 238, 255));
            square.material.SetColor("_EmissionColor", new Color32(26, 211, 238, 255));

            //Ammo Text Color
            ammoText.color = new Color32(26, 211, 238, 255);
            ammoText.fontMaterial.SetColor(ShaderUtilities.ID_GlowColor, new Color32(26, 211, 238, 255));

            //circleImg.color = new Color32(26, 211, 238, 255);
            //ammoText.color = new Color32(26, 211, 238, 255);
        }
    }
}
