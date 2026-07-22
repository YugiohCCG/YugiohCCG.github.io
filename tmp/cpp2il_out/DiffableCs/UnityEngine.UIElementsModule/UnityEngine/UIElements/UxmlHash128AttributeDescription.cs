namespace UnityEngine.UIElements;

public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription<Hash128>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Hash128, Hash128> <>9__3_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		internal Hash128 <GetValueFromBag>b__3_0(string s, Hash128 i) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public UxmlHash128AttributeDescription() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`3<System.Object, UnityEngine.Hash128, UnityEngine.Hash128>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(System.Func`3<System.String, UnityEngine.Hash128, UnityEngine.Hash128>), typeof(Hash128)}, ReturnType = typeof(Hash128))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

