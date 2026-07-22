namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleValueHandle
{
	[SerializeField]
	private StyleValueType m_ValueType; //Field offset: 0x0
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int valueIndex; //Field offset: 0x4

	public internal StyleValueType valueType
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		internal set { } //Length: 3
	}

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public StyleValueType get_valueType() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	internal void set_valueType(StyleValueType value) { }

}

