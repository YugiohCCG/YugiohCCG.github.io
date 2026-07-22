namespace System.Security;

[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected CodeAccessPermission() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	[CallerCount(Count = 0)]
	[Conditional("MONO_FEATURE_CAS")]
	public override void Demand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(False)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ComVisible(False)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	public abstract bool IsSubsetOf(IPermission target) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.Security.IPermission.Demand() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	public abstract SecurityElement ToXml() { }

}

