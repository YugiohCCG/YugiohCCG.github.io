namespace UnityEngine.UIElements;

[Obsolete("UxmlAttributeOverridesFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
{

	public virtual string uxmlName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public virtual string uxmlQualifiedName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 114
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	public UxmlAttributeOverridesFactory() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[CallerCount(Count = 0)]
	public virtual string get_uxmlName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual string get_uxmlQualifiedName() { }

}

