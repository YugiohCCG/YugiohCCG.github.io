namespace TMPro;

[ExcludeFromPreset]
public class TMP_StyleSheet : ScriptableObject
{
	[SerializeField]
	private List<TMP_Style> m_StyleList; //Field offset: 0x18
	private Dictionary<Int32, TMP_Style> m_StyleLookupDictionary; //Field offset: 0x20

	internal List<TMP_Style> styles
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TMP_StyleSheet() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal List<TMP_Style> get_styles() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public TMP_Style GetStyle(int hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public TMP_Style GetStyle(string name) { }

	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "RefreshStyles", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Style), Member = "RefreshStyle", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void LoadStyleDictionaryInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void RefreshStyles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void Reset() { }

}

