using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public static partial class GFunc
    {
        [System.Diagnostics.Conditional("DEBUG_MODE")]
        public static void Log(object message)
        {
#if DEBUG_MODE
        Debug.Log(message);
#endif
        }

        public static void SetText(this GameObject target, string text)
        {
            Text textComponent = target.GetComponent<Text>();
            if (textComponent == null)
            {
                return;
            }
            textComponent.text = text;
        }
    }
