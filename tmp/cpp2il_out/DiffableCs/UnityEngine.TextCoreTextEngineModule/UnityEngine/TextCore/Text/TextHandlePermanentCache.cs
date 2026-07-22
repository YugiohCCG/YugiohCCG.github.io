namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextHandlePermanentCache
{
	internal LinkedList<TextInfo> s_TextInfoPool; //Field offset: 0x10
	private object syncRoot; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public TextHandlePermanentCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandle), Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override void AddTextInfoToCache(TextHandle textHandle) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public void RemoveTextInfoFromCache(TextHandle textHandle) { }

}

