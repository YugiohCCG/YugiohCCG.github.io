namespace UnityEngine.UIElements;

internal class UxmlObjectListAttributeDescription : UxmlObjectAttributeDescription<List`1<T>>
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UxmlObjectListAttributeDescription`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjects", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

