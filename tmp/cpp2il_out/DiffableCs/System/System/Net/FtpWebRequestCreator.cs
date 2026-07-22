namespace System.Net;

internal class FtpWebRequestCreator : IWebRequestCreate
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal FtpWebRequestCreator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	public override WebRequest Create(Uri uri) { }

}

