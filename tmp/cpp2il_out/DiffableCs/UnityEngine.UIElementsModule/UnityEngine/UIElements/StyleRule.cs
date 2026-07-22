namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleRule
{
	[SerializeField]
	private StyleProperty[] m_Properties; //Field offset: 0x10
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int line; //Field offset: 0x18
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int customPropertiesCount; //Field offset: 0x1C

	public StyleProperty[] properties
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StyleRule() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public StyleProperty[] get_properties() { }

}

