namespace UnityEngine.UIElements;

public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<String>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String, String> <>9__3_0; //Field offset: 0x8
		public static Func<String, String, String> <>9__4_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal string <GetValueFromBag>b__3_0(string s, string t) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal string <TryGetValueFromBag>b__4_0(string s, string t) { }

	}


	[CallerCount(Count = 45)]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public UxmlStringAttributeDescription() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[CalledBy(Type = typeof(EnumFieldHelpers), Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(System.Func`3<System.String, System.Object, System.Object>), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) { }

}

