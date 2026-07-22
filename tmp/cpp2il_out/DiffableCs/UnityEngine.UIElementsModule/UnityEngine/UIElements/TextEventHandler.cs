namespace UnityEngine.UIElements;

internal class TextEventHandler
{
	private TextElement m_TextElement; //Field offset: 0x10
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0x18
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x20
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x28
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x30
	private EventCallback<PointerUpEvent> m_ATagOnPointerUp; //Field offset: 0x38
	private EventCallback<PointerMoveEvent> m_ATagOnPointerMove; //Field offset: 0x40
	private EventCallback<PointerOverEvent> m_ATagOnPointerOver; //Field offset: 0x48
	private EventCallback<PointerOutEvent> m_ATagOnPointerOut; //Field offset: 0x50
	internal bool isOverridingCursor; //Field offset: 0x58
	internal int currentLinkIDHash; //Field offset: 0x5C
	internal bool hasLinkTag; //Field offset: 0x60
	internal bool hasATag; //Field offset: 0x61

	private TextInfo textInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 41
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TextEventHandler(TextElement textElement) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void AllocateATagCallbacks() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void AllocateLinkCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ATagOnPointerOut(PointerOutEvent evt) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ATagOnPointerOver(PointerOverEvent _) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsUnknownMethods(Count = 1)]
	private TextInfo get_textInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void HandleATag() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 11)]
	internal void HandleLinkAndATagCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void HandleLinkTag() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HasAllocatedATagCallbacks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HasAllocatedLinkCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PointerDownLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerDownLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PointerMoveLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerMoveLinkTagEvent))]
	[Calls(Type = typeof(PointerOverLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerOverLinkTagEvent))]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkId", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.LinkInfo", Member = "GetLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PointerUpLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerUpLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy() { }

}

