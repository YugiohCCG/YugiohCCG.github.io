namespace Coffee.UISoftMask;

[Extension]
internal static class GraphicConnectorExtension
{

	[CalledBy(Type = typeof(SoftMaskable), Member = "get_softMask", ReturnType = typeof(SoftMask))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static T GetComponentInParentEx(Component component, bool includeInactive = false) { }

	[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "set_inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "set_useStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetMaterialDirtyEx(Graphic graphic) { }

	[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetVerticesDirtyEx(Graphic graphic) { }

}

