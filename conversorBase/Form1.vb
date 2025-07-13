Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "10" ' Valor por defecto en el TextBox1
    End Sub

    'Funcion para pasar de decimal a otra base

    Function DecimalToBase(decimalNumber As Integer, base As Integer) As String
        Dim result As String = ""
        Dim remainder As Integer
        While decimalNumber > 0
            remainder = decimalNumber Mod base
            If remainder < 10 Then
                result = remainder.ToString() & result
            Else
                result = Chr(remainder + 55) & result ' Convert to A, B, C, etc.
            End If
            decimalNumber \= base
        End While
        Return result
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked Then
            'captura el valor del TextBox1 y lo convierte a integer
            Dim decimalNumber As Integer

            decimalNumber = Convert.ToInt32(TextBox1.Text)
            Dim base As Integer = 2 ' Base binaria
            TextBox2.Text = DecimalToBase(decimalNumber, base)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            'captura el valor del TextBox1 y lo convierte a integer
            Dim decimalNumber As Integer

            decimalNumber = Convert.ToInt32(TextBox1.Text)

            Dim base As Integer = 8 ' Base octal
            TextBox2.Text = DecimalToBase(decimalNumber, base)
        End If


    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked Then
            'captura el valor del TextBox1 y lo convierte a integer
            Dim decimalNumber As Integer

            decimalNumber = Convert.ToInt32(TextBox1.Text)

            Dim base As Integer = 16 ' Base hexadecimal
            TextBox2.Text = DecimalToBase(decimalNumber, base)
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = "" ' Limpiar el TextBox2 al cambiar el valor del TextBox1
    End Sub
End Class
