using UnityEngine;
using UnityEditor;

namespace AnnulusGames.TweenPlayables.Editor
{
    public static class Styling
    {
        public static bool ToggleGroup(Rect position, bool foldout, ref bool toggle, string text, bool toggleOnLabelClick = true)
        {
            Rect toggleRect = position;
            toggleRect.x += 2f;
            toggleRect.y += position.height * 0.23f;
            toggleRect.width = 13f;
            toggleRect.height = 13f;

            Rect labelRect = position;
            labelRect.y += 1f;
            labelRect.xMin += 21f;

            EditorGUI.LabelField(labelRect, text, EditorStyles.boldLabel);
            bool value = DrawFoldoutToggle(position, foldout);
            toggle = GUI.Toggle(toggleRect, toggle, GUIContent.none, EditorStyles.toggle);

            var e = Event.current;
            if (e.type == EventType.MouseDown && labelRect.Contains(e.mousePosition) && e.button == 0)
            {
                value = !value;
                e.Use();
            }
            return value;
        }

        private static bool DrawFoldoutToggle(Rect position, bool foldout)
        {
            Rect foldoutRect = position;
            foldoutRect.x -= 13.5f;
            foldoutRect.y += position.height * 0.23f;
            foldoutRect.width = 13f;
            foldoutRect.height = 13f;
            return GUI.Toggle(foldoutRect, foldout, GUIContent.none, EditorStyles.foldout);
        }

        public static Texture2D csScriptIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("cs Script Icon").image;
            }
        }

        public static Color transformColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.6f, 0.83f, 0.34f);
                else return new Color(0.32f, 0.5f, 0.32f);
            }
        }

        public static Texture2D transformIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Transform Icon").image;
            }
        }

        public static Color rendererColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.7f, 0.6f, 1f);
                else return new Color(0.45f, 0.32f, 0.67f);
            }
        }

        public static Texture2D spriteRendererIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("SpriteRenderer Icon").image;
            }
        }

        public static Color audioColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(1f, 0.74f, 0f);
                else return new Color(0.78f, 0.6f, 0f);
            }
        }

        public static Texture2D audioSourceIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("AudioSource Icon").image;
            }
        }

        public static Color lightColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.95f, 0.95f, 0.95f);
                else return new Color(0.95f, 0.95f, 0.95f);
            }
        }

        public static Texture2D lightIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Light Icon").image;
            }
        }

        public static Texture2D lineRendererIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("LineRenderer Icon").image;
            }
        }

        public static Color cameraColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.8f, 0.17f, 0.17f);
                else return new Color(0.73f, 0f, 0f);
            }
        }

        public static Texture2D cameraIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Camera Icon").image;
            }
        }

        public static Color uguiColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.62f, 0.62f, 0.62f);
                else return new Color(0.34f, 0.34f, 0.34f);
            }
        }

        public static Texture2D rectTransformIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("RectTransform Icon").image;
            }
        }

        public static Texture2D sliderIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Slider Icon").image;
            }
        }

        public static Texture2D imageIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Image Icon").image;
            }
        }

        public static Texture2D canvasGroupIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("CanvasGroup Icon").image;
            }
        }

        public static Texture2D textIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Text Icon").image;
            }
        }

        public static Texture2D outlineIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Outline Icon").image;
            }
        }

        public static Texture2D shadowIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Shadow Icon").image;
            }
        }

        public static Texture2D meshRendererIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("MeshRenderer Icon").image;
            }
        }

        public static Texture2D textMeshProUGUIIcon
        {
            get
            {
                if (_textMeshProUGUIIcon == null)
                {
                    _textMeshProUGUIIcon = AssetDatabase.LoadAssetAtPath<Texture2D>("Packages/com.unity.textmeshpro/Editor Resources/Gizmos/TMP - Text Component Icon.psd");
                }
                return _textMeshProUGUIIcon;
            }
        }
        private static Texture2D _textMeshProUGUIIcon;

    }
}
