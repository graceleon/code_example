Public Class frmTrenes

#Region "Campos"
    Private _Estado As Integer
    Public KeyAscii As Short
#End Region

#Region "Constructor"
    Sub New(ByVal estado As Integer)
        InitializeComponent()
        _Estado = estado
    End Sub
#End Region

#Region "Métodos"
    Private Sub btnCalcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcula.Click
        Dim paxPie74, paxPie93, paxPie04, paxPie07, paxPie02 As New Double
        Dim porcentaje74, porcentaje93, porcentaje04, porcentaje07, porcentaje02 As New Double
        Dim paxPorcentaje74, paxPorcentaje93, paxPorcentaje04, paxPorcentaje07, paxPorcentaje02 As New Double
        Dim asientos74, asientos93, asientos04, asientos07, asientos02 As New Double
        Dim totalTrenes, TrenesCirculando As New Integer
        Dim CapPromNS74, CapPromNS93, CapPromNS04, CapPromNS07, CapPromAS02 As New Double
        Dim AsiPromNS74, AsiPromNS93, AsiPromNS04, AsiPromNS07, AsiPromAS02 As New Double
        Try
            ' Se calcula la cantidad de pasajeros de pie por tecnologia (Capacidad - Asientos)
            paxPie74 = (txt5CapNS74.Value - txt5AsientosNS74.Value) + _
                       (txt6CapNS74.Value - txt6AsientosNS74.Value) + _
                       (txt7CapNS74.Value - txt7AsientosNS74.Value)

            paxPie93 = (txt6CapNS93.Value - txt6AsientosNS93.Value) + _
                       (txt7CapNS93.Value - txt7AsientosNS93.Value) + _
                       (txt8CapNS93.Value - txt8AsientosNS93.Value)

            paxPie04 = (txt7CapNS04.Value - txt7AsientosNS04.Value) + _
                       (txt8CapNS04.Value - txt8AsientosNS04.Value)

            paxPie07 = (txt9CapNS07.Value - txt9AsientosNS07.Value)

            paxPie02 = (txt3CapAS02.Value - txt3AsientosAS02.Value) + _
                       (txt6CapAS02.Value - txt6AsientosAS02.Value)

            ' Total de pasajeros de pie
            Dim totalPax As New Integer
            totalPax = paxPie74 * (txt5CochesNS74.Value + txt6CochesNS74.Value + txt7CochesNS74.Value) + _
                       paxPie93 * (txt6CochesNS93.Value + txt7CochesNS93.Value + txt8CochesNS93.Value) + _
                       paxPie04 * (txt7CochesNS04.Value + txt8CochesNS04.Value) + _
                       paxPie07 * (txt9CochesNS07.Value) + _
                       paxPie02 * (txt3CochesAS02.Value + txt6CochesAS02.Value)
            Me.lblPaxTotal.Text = "Total Pasajeros:   " & totalPax

            ' Total de Trenes por tecnología
            Dim NS74 As Integer = CInt(txt5CochesNS74.Value + txt6CochesNS74.Value + txt7CochesNS74.Value)
            Me.txtNS74.Text = NS74
            Dim NS93 As Integer = CInt(txt6CochesNS93.Value + txt7CochesNS93.Value + txt8CochesNS93.Value)
            Me.txtNS93.Text = NS93
            Dim NS04 As Integer = CInt(txt7CochesNS04.Value + txt8CochesNS04.Value)
            Me.txtNS04.Text = NS04
            Dim NS07 As Integer = CInt(txt9CochesNS07.Value)
            Me.txtNS07.Text = NS07
            Dim AS02 As Integer = CInt(txt3CochesAS02.Value + txt6CochesAS02.Value)
            Me.txtAS02.Text = AS02

            'Total Trenes
            totalTrenes = CInt(NS74 + NS93 + NS04 + NS07 + AS02)
            Me.lblTotalTrenes.Text = "Total Trenes:   " & totalTrenes

            ' Trenes Operando
            TrenesCirculando = CInt(totalTrenes - txtTrenesReserva.Value - txtTrenesInyeccion.Value)
            Me.lblTrenesCirculando.Text = "Trenes Circulando:   " & TrenesCirculando

            ' Se obtienen los porcentajes de pasajeros por tecnologia
            porcentaje74 = (NS74 * 100 / totalTrenes)
            porcentaje93 = (NS93 * 100 / totalTrenes)
            porcentaje04 = (NS04 * 100 / totalTrenes)
            porcentaje07 = (NS07 * 100 / totalTrenes)
            porcentaje02 = (AS02 * 100 / totalTrenes)

            ' Pasajeros de acuerdo al porcentaje obtenido
            paxPorcentaje74 = (porcentaje74 / 100 * paxPie74)
            paxPorcentaje93 = (porcentaje93 / 100 * paxPie93)
            paxPorcentaje04 = (porcentaje04 / 100 * paxPie04)
            paxPorcentaje07 = (porcentaje07 / 100 * paxPie07)
            paxPorcentaje02 = (porcentaje02 / 100 * paxPie02)

            ' Cantidad total de pasajeros de acuerdo al porcentaje
            Dim paxTotalPorcentaje As Double = (paxPorcentaje74 + _
                                               paxPorcentaje93 + _
                                               paxPorcentaje04 + _
                                               paxPorcentaje07 + _
                                               paxPorcentaje02)

            ' Asientos de acuerdo al porcentaje obtenido
            asientos74 = (porcentaje74 / 100) * (txt5AsientosNS74.Value + txt6AsientosNS74.Value + txt7AsientosNS74.Value)
            asientos93 = (porcentaje93 / 100) * (txt6AsientosNS93.Value + txt7AsientosNS93.Value + txt8AsientosNS93.Value)
            asientos04 = (porcentaje04 / 100) * (txt7AsientosNS04.Value + txt8AsientosNS04.Value)
            asientos07 = (porcentaje07 / 100) * (txt9AsientosNS07.Value)
            asientos02 = (porcentaje02 / 100) * (txt3AsientosAS02.Value + txt6AsientosAS02.Value)

            ' Cantidad total de asientos
            Dim totalAsientos As New Double
            totalAsientos = CDbl(asientos74 + asientos93 + asientos04 + asientos07 + asientos02)

            ' Asientos Promedio por tecnología
            AsiPromNS74 = ((txt5CochesNS74.Value * txt5AsientosNS74.Value) + _
                           (txt6CochesNS74.Value * txt6AsientosNS74.Value) + _
                           (txt7CochesNS74.Value * txt7AsientosNS74.Value))
            AsiPromNS93 = ((txt6CochesNS93.Value * txt6AsientosNS93.Value) + _
                           (txt7CochesNS93.Value * txt7AsientosNS93.Value) + _
                           (txt8CochesNS93.Value * txt8AsientosNS93.Value))
            AsiPromNS04 = ((txt7CochesNS04.Value * txt7AsientosNS04.Value) + _
                           (txt8CochesNS04.Value * txt8AsientosNS04.Value))
            AsiPromNS07 = (txt9CochesNS07.Value * txt9AsientosNS07.Value)
            AsiPromAS02 = ((txt3CochesAS02.Value * txt3AsientosAS02.Value) + _
                           (txt6CochesAS02.Value * txt6AsientosAS02.Value))
            Me.lblAsientosPromedio.Text = "Asientos Promedio: " & Format((AsiPromNS74 + _
                                                                         AsiPromNS93 + _
                                                                         AsiPromNS04 + _
                                                                         AsiPromNS07 + _
                                                                         AsiPromAS02) / (totalTrenes - txtTrenesReserva.Value), "0.0")

            ' Capacidad Promedio por tecnología
            CapPromNS74 = ((txt5CochesNS74.Value * txt5CapNS74.Value) + _
                          (txt6CochesNS74.Value * txt6CapNS74.Value) + _
                          (txt7CochesNS74.Value * txt7CapNS74.Value))

            CapPromNS93 = ((txt6CochesNS93.Value * txt6CapNS93.Value) + _
                          (txt7CochesNS93.Value * txt7CapNS93.Value) + _
                          (txt8CochesNS93.Value * txt8CapNS93.Value))

            CapPromNS04 = ((txt7CochesNS04.Value * txt7CapNS04.Value) + _
                          (txt8CochesNS04.Value * txt8CapNS04.Value))

            CapPromNS07 = (txt9CochesNS07.Value * txt9CapNS07.Value)

            CapPromAS02 = ((txt3CochesAS02.Value * txt3CapAS02.Value) + _
                          (txt6CochesAS02.Value * txt6CapAS02.Value))

            lblCapacidadPromedio.Text = "Capacidad Promedio:  " & Format(((CapPromNS74 + _
                                                                  CapPromNS93 + _
                                                                  CapPromNS04 + _
                                                                  CapPromNS07 + _
                                                                  CapPromAS02) / totalTrenes), "0.0")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular los Valores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnTrenesBucle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrenesBucle.Click
        Dim TrenesBucle As New Integer
        Dim dividendo As New Double
        Dim divisor As New Double
        Try
            dividendo = (txtVueltaBucle.Text * txtNumeroTrenes.Text)
            divisor = (txtVueltaBucle.Text + (txtNbucle.Text * txtVueltaLarga.Text))
            TrenesBucle = CInt(dividendo / divisor)
            Me.txtTrenesBucles.Text = TrenesBucle
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al calcular los Trenes de Bucle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnTrenesLargos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrenesLargos.Click
        Dim TrenesLargos As New Integer
        Try
            TrenesLargos = CInt(txtNumeroTrenesL.Text - txtNumeroTrenesBucle.Text)
            Me.txtTrenesLargos.Text = TrenesLargos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al calcular los Trenes Largos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmTrenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Estado = 1 Then
            Me.gpbTrenesBucle.Enabled = False
            Me.gpbTrenesLargos.Enabled = False
        ElseIf _Estado = 2 Then
            Me.gpbTrenesBucle.Enabled = False
        ElseIf _Estado = 3 Then
            Me.gpbTrenesLargos.Enabled = False
        End If
    End Sub
    Private Sub txtNumeroTrenes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroTrenes.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVueltaBucle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVueltaBucle.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtNbucle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNbucle.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVueltaLarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVueltaLarga.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtNumeroTrenesL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroTrenesL.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNumeroTrenesBucle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroTrenesBucle.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        ' Limpiamos la cantidad de trenes por tecnologías
        Me.txtNS74.Text = 0
        Me.txtNS93.Text = 0
        Me.txtNS04.Text = 0
        Me.txtNS07.Text = 0
        Me.txtAS02.Text = 0
        ' Limpiamos los números de coches por tecnologías
        Me.txt5CochesNS74.Value = 0
        Me.txt6CochesNS74.Value = 0
        Me.txt7CochesNS74.Value = 0
        Me.txt6CochesNS93.Value = 0
        Me.txt7CochesNS93.Value = 0
        Me.txt8CochesNS93.Value = 0
        Me.txt7CochesNS04.Value = 0
        Me.txt8CochesNS04.Value = 0
        Me.txt9CochesNS07.Value = 0
        Me.txt3CochesAS02.Value = 0
        Me.txt6CochesAS02.Value = 0
        ' Limpiamos las capacidades por tecnologías
        Me.txt5CapNS74.Value = 0
        Me.txt6CapNS74.Value = 0
        Me.txt7CapNS74.Value = 0
        Me.txt6CapNS93.Value = 0
        Me.txt7CapNS93.Value = 0
        Me.txt8CapNS93.Value = 0
        Me.txt7CapNS04.Value = 0
        Me.txt8CapNS04.Value = 0
        Me.txt9CapNS07.Value = 0
        Me.txt3CapAS02.Value = 0
        Me.txt6CapAS02.Value = 0
        ' Limpiamos los asientos por tecnologías
        Me.txt5AsientosNS74.Value = 0
        Me.txt6AsientosNS74.Value = 0
        Me.txt7AsientosNS74.Value = 0
        Me.txt6AsientosNS93.Value = 0
        Me.txt7AsientosNS93.Value = 0
        Me.txt8AsientosNS93.Value = 0
        Me.txt7AsientosNS04.Value = 0
        Me.txt8AsientosNS04.Value = 0
        Me.txt9AsientosNS07.Value = 0
        Me.txt3AsientosAS02.Value = 0
        Me.txt6AsientosAS02.Value = 0
        ' Limpiamos el tren de reserva
        Me.txtTrenesReserva.Value = 0

        '' Llamada para limpiar todos los textbox
        'Call Tools.LimpiarTextBox(Me)
        '' Llamada para limpiar todos los NumericUpDown
        'Call Tools.LimpiarNumericUpDown(Me)

    End Sub
    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        ' Restablecemos los valores de cantidad de trenes por tecnologías
        Me.txtNS74.Text = 0
        Me.txtNS93.Text = 0
        Me.txtNS04.Text = 0
        Me.txtNS07.Text = 0
        Me.txtAS02.Text = 0
        ' Restablecemos los valores de números de coches por tecnologías
        Me.txt5CochesNS74.Value = 50
        Me.txt6CochesNS74.Value = 0
        Me.txt7CochesNS74.Value = 0
        Me.txt6CochesNS93.Value = 12
        Me.txt7CochesNS93.Value = 12
        Me.txt8CochesNS93.Value = 10
        Me.txt7CochesNS04.Value = 3
        Me.txt8CochesNS04.Value = 8
        Me.txt9CochesNS07.Value = 20
        Me.txt3CochesAS02.Value = 6
        Me.txt6CochesAS02.Value = 33
        ' Restablecemos los valores de capacidades por tecnologías
        Me.txt5CapNS74.Value = 932
        Me.txt6CapNS74.Value = 1132
        Me.txt7CapNS74.Value = 1302
        Me.txt6CapNS93.Value = 943
        Me.txt7CapNS93.Value = 1112
        Me.txt8CapNS93.Value = 1272
        Me.txt7CapNS04.Value = 1261
        Me.txt8CapNS04.Value = 1447
        Me.txt9CapNS07.Value = 1534
        Me.txt3CapAS02.Value = 798
        Me.txt6CapAS02.Value = 1595
        ' Restablecemos los valores de asientos por tecnologías
        Me.txt5AsientosNS74.Value = 124
        Me.txt6AsientosNS74.Value = 179
        Me.txt7AsientosNS74.Value = 199
        Me.txt6AsientosNS93.Value = 111
        Me.txt7AsientosNS93.Value = 123
        Me.txt8AsientosNS93.Value = 143
        Me.txt7AsientosNS04.Value = 164
        Me.txt8AsientosNS04.Value = 188
        Me.txt9AsientosNS07.Value = 224
        Me.txt3AsientosAS02.Value = 138
        Me.txt6AsientosAS02.Value = 276
        ' Limpiamos el tren de reserva
        Me.txtTrenesReserva.Value = 0
    End Sub
#End Region

End Class