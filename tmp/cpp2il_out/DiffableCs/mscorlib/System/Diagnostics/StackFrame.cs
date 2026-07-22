namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
public class StackFrame
{
	public const int OFFSET_UNKNOWN = -1; //Field offset: 0x0
	private int ilOffset; //Field offset: 0x10
	private int nativeOffset; //Field offset: 0x14
	private long methodAddress; //Field offset: 0x18
	private uint methodIndex; //Field offset: 0x20
	private MethodBase methodBase; //Field offset: 0x28
	private string fileName; //Field offset: 0x30
	private int lineNumber; //Field offset: 0x38
	private int columnNumber; //Field offset: 0x3C
	private string internalMethodName; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StackFrame() { }

	[CalledBy(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StackFrame(int skipFrames, bool fNeedFileInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int GetFileLineNumber() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override string GetFileName() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int GetILOffset() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string GetInternalMethodName() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override MethodBase GetMethod() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal long GetMethodAddress() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal uint GetMethodIndex() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int GetNativeOffset() { }

	[CalledBy(Type = typeof(StackFrame), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string GetSecureFileName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StackFrame), Member = "GetSecureFileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

