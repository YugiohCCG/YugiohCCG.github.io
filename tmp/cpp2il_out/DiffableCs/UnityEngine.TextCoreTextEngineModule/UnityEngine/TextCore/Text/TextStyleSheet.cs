namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextStyleSheet : ScriptableObject
{
	[SerializeField]
	private List<TextStyle> m_StyleList; //Field offset: 0x18
	private Dictionary<Int32, TextStyle> m_StyleLookupDictionary; //Field offset: 0x20
	private object styleLookupLock; //Field offset: 0x28

	internal List<TextStyle> styles
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public TextStyleSheet() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	internal List<TextStyle> get_styles() { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public TextStyle GetStyle(int hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public TextStyle GetStyle(string name) { }

	[CalledBy(Type = typeof(TextStyleSheet), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextStyle))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TextStyle))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "RefreshStyles", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextStyle), Member = "RefreshStyle", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void LoadStyleDictionaryInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void RefreshStyles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void Reset() { }

}

