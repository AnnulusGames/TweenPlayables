using UnityEngine;
using UnityEditor;

namespace TweenPlayables.Editor
{
    public static class Styles
    {
        public static bool ToggleGroup(Rect position, bool foldout, ref bool toggle, string text, bool toggleOnLabelClick = true)
        {
            var toggleRect = position;
            toggleRect.x += 2f;
            toggleRect.y += position.height * 0.23f;
            toggleRect.width = 13f;
            toggleRect.height = 13f;

            var labelRect = position;
            labelRect.y += 1f;
            labelRect.xMin += 21f;

            EditorGUI.LabelField(labelRect, text, EditorStyles.boldLabel);
            var value = DrawFoldoutToggle(position, foldout);
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
            var foldoutRect = position;
            foldoutRect.x -= 13.5f;
            foldoutRect.y += position.height * 0.23f;
            foldoutRect.width = 13f;
            foldoutRect.height = 13f;
            return GUI.Toggle(foldoutRect, foldout, GUIContent.none, EditorStyles.foldout);
        }

        public static Texture2D CsScriptIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("cs Script Icon").image;
            }
        }

        public static Color TransformColor
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

        public static Color RendererColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.7f, 0.6f, 1f);
                else return new Color(0.45f, 0.32f, 0.67f);
            }
        }

        public static Texture2D SpriteRendererIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("SpriteRenderer Icon").image;
            }
        }

        public static Color AudioColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(1f, 0.74f, 0f);
                else return new Color(0.78f, 0.6f, 0f);
            }
        }

        public static Texture2D AudioSourceIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("AudioSource Icon").image;
            }
        }

        public static Color LightColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.95f, 0.95f, 0.95f);
                else return new Color(0.95f, 0.95f, 0.95f);
            }
        }

        public static Texture2D LightIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Light Icon").image;
            }
        }

        public static Texture2D LineRendererIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("LineRenderer Icon").image;
            }
        }

        public static Color CameraColor
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

        public static Color UGUIColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin) return new Color(0.62f, 0.62f, 0.62f);
                else return new Color(0.34f, 0.34f, 0.34f);
            }
        }

        public static Texture2D RectTransformIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("RectTransform Icon").image;
            }
        }

        public static Texture2D SliderIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Slider Icon").image;
            }
        }

        public static Texture2D ImageIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Image Icon").image;
            }
        }

        public static Texture2D CanvasGroupIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("CanvasGroup Icon").image;
            }
        }

        public static Texture2D TextIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Text Icon").image;
            }
        }

        public static Texture2D OutlineIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Outline Icon").image;
            }
        }

        public static Texture2D ShadowIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("Shadow Icon").image;
            }
        }

        public static Texture2D MeshRendererIcon
        {
            get
            {
                return (Texture2D)EditorGUIUtility.IconContent("MeshRenderer Icon").image;
            }
        }

        public static Texture2D TextMeshProUGUIIcon
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
