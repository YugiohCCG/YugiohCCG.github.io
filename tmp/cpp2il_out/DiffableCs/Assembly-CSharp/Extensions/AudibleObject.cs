namespace Extensions;

public class AudibleObject : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
{
	public bool PlayHoverSound; //Field offset: 0x20
	public bool PlayClickSound; //Field offset: 0x21

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AudibleObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CalledBy(Type = typeof(RoomReadyButton), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	public override void OnPointerEnter(PointerEventData eventData) { }

}

