using UnityEngine;
using UnityEngine.UI;

public class MobileButtonController : MonoBehaviour
{
    public Button skillButton;
    public Button attackButton;
    private SkillSystem skillSystem;
    private WeaponController weaponController;

    void Start()
    {
        // Get references to the SkillSystem and WeaponController components
        skillSystem = FindObjectOfType<SkillSystem>();
        weaponController = FindObjectOfType<WeaponController>();

        // Add listeners for button clicks
        skillButton.onClick.AddListener(OnSkillButtonClicked);
        attackButton.onClick.AddListener(OnAttackButtonClicked);
    }

    void OnSkillButtonClicked()
    {
        // Trigger skill using the SkillSystem
        skillSystem.UseSkill(); // Replace with actual skill method
    }

    void OnAttackButtonClicked()
    {
        // Trigger attack using the WeaponController
        weaponController.Attack(); // Replace with actual attack method
    }
}