# CSharp-to-Cpp-COM-Example

In order to run this code, you must:
1. Make sure assembly is signed in project properties,
2. Add assembly to GAC by running `gacutil.exe /i assemblyName.dll`,
3. Register dll created in GAC by running `regasm.exe assemblyName.dll /codebase`,
4. Add assembly in references tab in VS solution explorer.
