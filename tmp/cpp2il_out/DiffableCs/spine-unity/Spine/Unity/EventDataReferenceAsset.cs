namespace Spine.Unity;

[CreateAssetMenu(menuName = "Spine/EventData Reference Asset", order = 100)]
public class EventDataReferenceAsset : ScriptableObject
{
	private const bool QuietSkeletonData = True; //Field offset: 0x0
	[SerializeField]
	protected SkeletonDataAsset skeletonDataAsset; //Field offset: 0x18
	[SerializeField]
	[SpineEvent(null, "skeletonDataAsset", True, False, False)]
	protected string eventName; //Field offset: 0x20
	private EventData eventData; //Field offset: 0x28

	public EventData EventData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDataReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
		 get { } //Length: 43
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public EventDataReferenceAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDataReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
	public EventData get_EventData() { }

	[CalledBy(Type = typeof(EventDataReferenceAsset), Member = "get_EventData", ReturnType = typeof(EventData))]
	[CalledBy(Type = typeof(EventDataReferenceAsset), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDataReferenceAsset)}, ReturnType = typeof(EventData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(SkeletonData), Member = "FindEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(EventData))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDataReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static EventData op_Implicit(EventDataReferenceAsset asset) { }

}

