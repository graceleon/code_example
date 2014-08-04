Public Class frmConversorDecimal

    '    Dim segundos As Double = 7950 'Los Segundos a Probar

    '    'Prueba 1: Total Dias, Total de Horas, Total Minutos, Total Segundos
    '    Dim t As New TimeSpan

    'Response.Write("Prueba 1: Dias: " + t.FromSeconds(segundos).TotalDays.ToString() +
    ' " Tiempo: " + t.FromSeconds(segundos).TotalHours.ToString() + ":" +t.FromSeconds(segundos).TotalMinutes.ToString() + ":" + t.FromSeconds(segundos).TotalSeconds.ToString())


    Private Sub btnConvertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertir.Click
        Dim t As New TimeSpan
        Dim valor As Double = txtValorConvertir.Text
        Dim resultado As New Duracion
        Try
            If valor <> Nothing Then
                If Me.rbtnHorasConv.Checked AndAlso _
                   Me.rbtnMinutosConv.Checked = False AndAlso _
                   Me.rbtnSegundosConv.Checked = False Then
                    resultado = New Duracion(valor * 3600)

                ElseIf Me.rbtnHorasConv.Checked = False AndAlso _
                       Me.rbtnMinutosConv.Checked AndAlso _
                       Me.rbtnSegundosConv.Checked = False Then
                    resultado = New Duracion(valor * 60)
                ElseIf Me.rbtnHorasConv.Checked = False AndAlso _
                       Me.rbtnMinutosConv.Checked = False AndAlso _
                       Me.rbtnSegundosConv.Checked Then
                    resultado = New Duracion(valor)
                End If
                Me.txtValorConvertido.Text = resultado.ToDate
            Else
                MessageBox.Show("Debe ingresar un valor para convertir")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al convertir el valor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmConversorDecimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class