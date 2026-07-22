namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleProperty
{
	[SerializeField]
	private string m_Name; //Field offset: 0x10
	[SerializeField]
	private int m_Line; //Field offset: 0x18
	[SerializeField]
	private StyleValueHandle[] m_Values; //Field offset: 0x20
	internal bool isCustomProperty; //Field offset: 0x28
	internal bool requireVariableResolve; //Field offset: 0x29

	public string name
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public StyleValueHandle[] values
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StyleProperty() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public StyleValueHandle[] get_values() { }

}

