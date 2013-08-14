/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 14.08.2013
 * Time: 20:15
 */
using System;
using System.Linq.Expressions;

namespace UsingCodeDomForGenerationOfCode
{
	/// <summary>
	/// Description of CreatingHelloWorldWithExpressionTree.
	/// </summary>
	public class CreatingHelloWorldWithExpressionTree
	{
		static void Main()
		{
			BlockExpression blockExpr = Expression.Block(
				Expression.Call(
					null,
					typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
					Expression.Constant("Hello ")
				),
				Expression.Call(
					null,
					typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
					Expression.Constant("World!")
				)
			);
			
			Expression.Lambda<Action>(blockExpr).Compile()();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
