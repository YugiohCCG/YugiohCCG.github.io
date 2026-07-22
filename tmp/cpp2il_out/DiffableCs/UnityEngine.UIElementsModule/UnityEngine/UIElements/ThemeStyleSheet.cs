namespace UnityEngine.UIElements;

[HelpURL("UIE-tss")]
public class ThemeStyleSheet : StyleSheet
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	public ThemeStyleSheet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	internal virtual void OnEnable() { }

}

