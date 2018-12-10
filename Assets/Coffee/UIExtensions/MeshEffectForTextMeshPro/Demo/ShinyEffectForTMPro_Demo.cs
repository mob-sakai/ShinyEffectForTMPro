using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Coffee.UIExtensions
{
	public class ShinyEffectForTMPro_Demo : MonoBehaviour
	{
		public void Play ()
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.Play ();
			}
		}

		public void SetEffectFactor (float value)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.effectFactor = value;
			}
		}

		public void SetWidth (float value)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.width = value;
			}
		}

		public void SetSoftness (float value)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.softness = value;
			}
		}

		public void SetRotation (float value)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.rotation = value;
			}
		}


		public void SetBrightness (float value)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.brightness = value;
			}
		}

		public void SetGloss (float value)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.gloss = value;
			}
		}

		public void SplitByCharacter (bool flag)
		{
			foreach (var d in GetComponentsInChildren<UIShiny> ())
			{
				d.effectArea = flag ? EffectArea.Character : EffectArea.RectTransform;
			}
		}
	}
}