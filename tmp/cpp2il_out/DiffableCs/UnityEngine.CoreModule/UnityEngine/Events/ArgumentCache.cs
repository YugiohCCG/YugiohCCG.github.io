namespace UnityEngine.Events;

internal class ArgumentCache : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	private object m_ObjectArgument; //Field offset: 0x10
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName; //Field offset: 0x18
	[FormerlySerializedAs("intArgument")]
	[SerializeField]
	private int m_IntArgument; //Field offset: 0x20
	[FormerlySerializedAs("floatArgument")]
	[SerializeField]
	private float m_FloatArgument; //Field offset: 0x24
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	private string m_StringArgument; //Field offset: 0x28
	[SerializeField]
	private bool m_BoolArgument; //Field offset: 0x30

	public bool boolArgument
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public float floatArgument
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public int intArgument
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public string stringArgument
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public object unityObjectArgument
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string unityObjectArgumentAssemblyTypeName
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ArgumentCache() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public bool get_boolArgument() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public float get_floatArgument() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public int get_intArgument() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_stringArgument() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public object get_unityObjectArgument() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public string get_unityObjectArgumentAssemblyTypeName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

}

