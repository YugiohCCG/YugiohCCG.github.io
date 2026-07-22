namespace System;

[ClassInterface(ClassInterfaceType::AutoDual (2))]
[ComVisible(True)]
public class object
{

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public Object() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(object obj) { }

	[CallerCount(Count = 264)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool Equals(object objA, object objB) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void FieldSetter(string typeName, string fieldName, object val) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected override void Finalize() { }

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int GetHashCode() { }

	[CallerCount(Count = 933)]
	[CallsUnknownMethods(Count = 1)]
	public Type GetType() { }

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int InternalGetHashCode(object o) { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected object MemberwiseClone() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static bool ReferenceEquals(object objA, object objB) { }

	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Assembly), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Events.UnityEventBase", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Spine.SkeletonData", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.GUIContent", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override string ToString() { }

}

