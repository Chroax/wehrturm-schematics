using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private Image fillHealth;
    [SerializeField] private TextMeshProUGUI healthCount;
    [SerializeField] private Gradient gradient;
    private Slider slider;

    public void Init()
    {
        slider = GetComponent<Slider>();
    }

    public void SetMaxHealthUI(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        healthCount.text = slider.maxValue.ToString() + "/" + slider.maxValue.ToString();
        fillHealth.color = gradient.Evaluate(1f);
    }

    public void SetHealthUI(int health)
    {
        slider.value = health;
        healthCount.text = slider.value.ToString() + "/" + slider.maxValue.ToString();
        fillHealth.color = gradient.Evaluate(slider.normalizedValue);
    }
}
