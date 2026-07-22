namespace UnityEngine.Rendering;

public class SerializableEnum
{
	[SerializeField]
	private string m_EnumValueAsString; //Field offset: 0x10
	[SerializeField]
	private string m_EnumTypeAsString; //Field offset: 0x18

	public Enum value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enum), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 260
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 62
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "GetNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public SerializableEnum(Type enumType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public Enum get_value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void set_value(Enum value) { }

}

