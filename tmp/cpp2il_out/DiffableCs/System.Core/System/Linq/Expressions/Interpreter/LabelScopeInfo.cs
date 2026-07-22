namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelScopeInfo
{
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; //Field offset: 0x10
	internal readonly LabelScopeKind Kind; //Field offset: 0x18
	internal readonly LabelScopeInfo Parent; //Field offset: 0x20

	internal bool CanJumpInto
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "TryPushLabelBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	internal bool ContainsTarget(LabelTarget target) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_CanJumpInto() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

}

