namespace UnityEngine.UIElements;

internal class ATGTextEventHandler
{
	private TextElement m_TextElement; //Field offset: 0x10
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0x18
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x20
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x28
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x30
	private EventCallback<PointerUpEvent> m_HyperlinkOnPointerUp; //Field offset: 0x38
	private EventCallback<PointerMoveEvent> m_HyperlinkOnPointerMove; //Field offset: 0x40
	private EventCallback<PointerOverEvent> m_HyperlinkOnPointerOver; //Field offset: 0x48
	private EventCallback<PointerOutEvent> m_HyperlinkOnPointerOut; //Field offset: 0x50
	internal bool isOverridingCursor; //Field offset: 0x58
	internal int currentLinkIDHash; //Field offset: 0x5C

	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public ATGTextEventHandler(TextElement textElement) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void AllocateHyperlinkCallbacks() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void AllocateLinkCallbacks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HasAllocatedHyperlinkCallbacks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HasAllocatedLinkCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HyperlinkOnPointerMove(PointerMoveEvent pme) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void HyperlinkOnPointerOut(PointerOutEvent evt) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void HyperlinkOnPointerOver(PointerOverEvent _) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void HyperlinkOnPointerUp(PointerUpEvent pue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(PointerDownLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerDownLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(PointerMoveLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerMoveLinkTagEvent))]
	[Calls(Type = typeof(PointerOverLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerOverLinkTagEvent))]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerOutLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string)}, ReturnType = typeof(PointerOutLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.RichTextTagParser+TagType, System.String>))]
	[Calls(Type = typeof(PointerUpLinkTagEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent), typeof(string), typeof(string)}, ReturnType = typeof(PointerUpLinkTagEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	public void OnDestroy() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal void RegisterHyperlinkCallbacks() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void RegisterLinkTagCallbacks() { }

	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal void UnRegisterHyperlinkCallbacks() { }

	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void UnRegisterLinkTagCallbacks() { }

}

