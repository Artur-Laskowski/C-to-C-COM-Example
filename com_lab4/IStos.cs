using System.Runtime.InteropServices;
using System.Reflection;

[Guid("58D9A434-2614-4BBB-A784-9BFE36BF33D9"),
 ComVisible(true),
 InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IStos
{
    uint Push(int v);
    uint Pop(out int v);
}
