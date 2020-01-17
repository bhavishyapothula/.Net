Imports System
Module Module1
	Sub Main()
		Dim a As Integer
		Dim b As Integer
		Dim c As Integer
      		Console.WriteLine("Enter number:")
		a = Convert.ToInt32(Console.ReadLine())	
      		Console.WriteLine("Enter number:")
		b = Convert.ToInt32(Console.ReadLine())
      		Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division")
      		Console.WriteLine("Enter choice:")
      		c = Convert.ToInt32(Console.ReadLine())
      		If (c=1) Then
      			Console.WriteLine(a & "+" & b & "=" & a+b)
		ElseIf (c=2) Then
      			Console.WriteLine(a & "-" & b & "=" & a-b)
		ElseIf (c=3) Then
      			Console.WriteLine(a & "*" & b & "=" & a*b)
		ElseIf (c=4) Then
      			Console.WriteLine(a & "/" & b & "=" & a/b)
		End If
	End Sub
End Module