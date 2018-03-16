using System.Runtime.InteropServices;
using System.Reflection;

[Guid("F1C8ED38-A242-4FAD-A237-FC844B2AF2C2"),
 ComVisible(true),
 ClassInterface(ClassInterfaceType.None),
 ProgId("KSR.Stos.2")]
public class Stos : IStos
{
    private int[] stack;
    private uint size;
    public Stos() {
        stack = new int[256];
    }

    public uint Push(int v) {
        if (size < 256)
            stack[size++] = v;
        return size;
    }

    public uint Pop(out int v) {
        if (size > 0)
            v = stack[--size];
        else
            v = 0;
        return size;
    }
}
