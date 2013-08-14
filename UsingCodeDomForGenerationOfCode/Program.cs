/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 14.08.2013
 * Time: 19:06
 */
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using Microsoft.CSharp;

namespace UsingCodeDomForGenerationOfCode
{
	class Program
	{
		static CodeCompileUnit GetCode()
		{
			CodeCompileUnit compileUnit = new CodeCompileUnit();
			CodeNamespace myNamespace = new CodeNamespace("MyNamespace");
			myNamespace.Imports.Add(new CodeNamespaceImport("System"));
			CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
			CodeEntryPointMethod start = new CodeEntryPointMethod();
			CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
				new CodeTypeReferenceExpression("Console"),
				"WriteLine", new CodePrimitiveExpression("Hello World!"));
			compileUnit.Namespaces.Add(myNamespace);
			myNamespace.Types.Add(myClass);
			myClass.Members.Add(start);
			start.Statements.Add(cs1);
			return compileUnit;
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			CSharpCodeProvider provider = new CSharpCodeProvider();
			
			using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false))
			{
				IndentedTextWriter tw = new IndentedTextWriter(sw, "   ");
				provider.GenerateCodeFromCompileUnit(GetCode(), tw, new CodeGeneratorOptions());
				tw.Close();
			}
			
			Func<int, int, int> addFunc = (x, y) => x + y;
			Console.WriteLine(addFunc(2, 3));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}