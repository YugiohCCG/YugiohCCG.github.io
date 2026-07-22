namespace DG.Tweening.Core;

internal class TweenLink
{
	public readonly GameObject target; //Field offset: 0x10
	public readonly LinkBehaviour behaviour; //Field offset: 0x18
	public bool lastSeenActive; //Field offset: 0x1C

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLink", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(GameObject)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLink", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(GameObject), typeof(LinkBehaviour)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public TweenLink(GameObject target, LinkBehaviour behaviour) { }

}

