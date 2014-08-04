Public Class frmConversorUnidades
#Region "Métodos"
    Private Sub btnCalculaSeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculaSeg.Click
        Try
            If txtSegundos.Text <> 0 Then
                If rbtnSegMinutos.Checked AndAlso rbtnSegHoras.Checked = False Then
                    Me.txtSegConvertido.Text = Me.txtSegundos.Text / 60
                    Me.lblSegConv.Text = "(min)"
                ElseIf rbtnSegHoras.Checked AndAlso rbtnSegMinutos.Checked = False Then
                    Me.txtSegConvertido.Text = Me.txtSegundos.Text / 3600
                    Me.lblSegConv.Text = "(hr)"
                ElseIf rbtnSegHoras.Checked = False AndAlso rbtnSegMinutos.Checked = False Then
                    MessageBox.Show("Seleccione una conversión")
                End If
            Else
                MessageBox.Show("Ingrese un valor para convertir")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al convertir en segundos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnCalculaMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculaMin.Click
        Try
            If txtMinutos.Text <> 0 Then
                If rbtnMinSegundos.Checked AndAlso rbtnMinHoras.Checked = False Then
                    Me.txtMinConvertido.Text = Me.txtMinutos.Text * 60
                    Me.lblMinConv.Text = "(seg)"
                ElseIf rbtnMinHoras.Checked AndAlso rbtnMinSegundos.Checked = False Then
                    Me.txtMinConvertido.Text = Me.txtMinutos.Text / 60
                    Me.lblMinConv.Text = "(hr)"
                ElseIf rbtnMinHoras.Checked = False AndAlso rbtnMinSegundos.Checked = False Then
                    MessageBox.Show("Seleccione una conversión")
                End If
            Else
                MessageBox.Show("Ingrese un valor para convertir")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al convertir en minutos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnCalculaHrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculaHrs.Click
        Try
            If txtHoras.Text <> 0 Then
                If rbtnHrSegundos.Checked AndAlso rbtnHrMinutos.Checked = False Then
                    Me.txtHrConvertida.Text = Me.txtHoras.Text * 3600
                    Me.lblHrConv.Text = "(seg)"
                ElseIf rbtnHrMinutos.Checked AndAlso rbtnHrSegundos.Checked = False Then
                    Me.txtHrConvertida.Text = Me.txtHoras.Text * 60
                    Me.lblHrConv.Text = "(min)"
                ElseIf rbtnHrMinutos.Checked = False AndAlso rbtnHrSegundos.Checked = False Then
                    MessageBox.Show("Seleccione una conversión")
                End If
            Else
                MessageBox.Show("Ingrese un valor para convertir")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al convertir en horas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
#Region "Eventos"
    'Private Sub txtSegundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSegundos.Click
    '    Me.gpbSegundos.Enabled = True
    '    Me.gpbMinutos.Enabled = False
    '    Me.gpbHoras.Enabled = False
    'End Sub
    'Private Sub txtMinutos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinutos.Click
    '    Me.gpbSegundos.Enabled = False
    '    Me.gpbMinutos.Enabled = True
    '    Me.gpbHoras.Enabled = False
    'End Sub

    'Private Sub txtHoras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoras.Click
    '    Me.gpbSegundos.Enabled = False
    '    Me.gpbMinutos.Enabled = False
    '    Me.gpbHoras.Enabled = True
    'End Sub
#End Region

End Class