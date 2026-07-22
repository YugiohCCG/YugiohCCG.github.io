//Type is in global namespace

internal static class SR
{

	[CalledBy(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1) { }

}

