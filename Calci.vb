Imports System
Module Module1
   Sub Main()
      Dim a As Integer
      Dim b As Integer
      Console.WriteLine("Enter number:")
      a = Convert.ToInt32(Console.ReadLine())
      Console.WriteLine("Enter number:")
      b = Convert.ToInt32(Console.ReadLine())
      Console.WriteLine(a & "+" & b & "=" & a+b)
      Console.WriteLine(a & "-" & b & "=" & a-b)
      Console.WriteLine(a & "*" & b & "=" & a*b)
      Console.WriteLine(a & "/" & b & "=" & a/b)
   End Sub
End Module