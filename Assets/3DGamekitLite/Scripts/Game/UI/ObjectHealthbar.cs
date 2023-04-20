using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gamekit3D
{
    public class ObjectHealthbar : MonoBehaviour
    {
        public Damageable representedDamageable;
        public Slider HealthSlider;

        IEnumerator Start()
        {
            if (representedDamageable == null)
                representedDamageable = GetComponentInParent<Damageable>();
            if (representedDamageable == null)
                yield break;

            yield return null;

            HealthSlider.maxValue = representedDamageable.maxHitPoints;
            HealthSlider.value = representedDamageable.maxHitPoints;
        }

        public void ChangeHitPointUI()
        {
            HealthSlider.value = representedDamageable.currentHitPoints;
        }
    }
}
