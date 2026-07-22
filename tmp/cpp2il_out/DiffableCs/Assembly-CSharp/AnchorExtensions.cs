//Type is in global namespace

[Extension]
public static class AnchorExtensions
{
	private static readonly Vector2 ZO; //Field offset: 0x0
	private static readonly Vector2 HO; //Field offset: 0x8
	private static readonly Vector2 ZH; //Field offset: 0x10
	private static readonly Vector2 HH; //Field offset: 0x18
	private static readonly Vector2 OZ; //Field offset: 0x20
	private static readonly Vector2 OH; //Field offset: 0x28
	private static readonly Vector2 HZ; //Field offset: 0x30

	[CallerCount(Count = 0)]
	private static AnchorExtensions() { }

	[CalledBy(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MousePositionDebug), Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static void SetAnchor(RectTransform source, AnchorPresets allign, int offsetX = 0, int offsetY = 0) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "SetLvPwrTop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "SetLvPwrBot", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FPSData), Member = "DefineDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FPSMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FPSData), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "UpdateTemplateLevelInHand", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshGenesys", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(AnchorPresets), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[Extension]
	public static void SetAnchorAndPivot(RectTransform source, PivotPresets preset) { }

	[CalledBy(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MousePositionDebug), Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static void SetPivot(RectTransform source, PivotPresets preset) { }

}

