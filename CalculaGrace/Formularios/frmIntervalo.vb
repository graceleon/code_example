Public Class frmIntervalo
#Region "Campos"
    Private _Estado As Integer
    Private KeyAscii As Short
#End Region
#Region "Constructor"
    Sub New(ByVal estado As Integer)
        InitializeComponent()
        _Estado = estado
    End Sub
#End Region
#Region "Métodos"
    Private Sub btnCalculaIntervalo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculaIntervalo.Click
        Dim intervalo As New Integer
        Try
            If Me.rbtnBucle.Checked Then
                If Me.txtNbucle.Text = 0 Then
                    intervalo = CInt(Me.txtVueltaBucle.Text / Me.txtNbucle.Text)
                Else
                    intervalo = Tools.IntervaloNormalBucle(Me.txtVueltaBucle.Text, _
                                                     Me.txtVueltaLarga.Text, _
                                                     Me.txtNumTrenes.Text, _
                                                     Me.txtNbucle.Text)
                    Me.lblCalculaIntervaloBucle.Text = "Interv. Bucle: " & _
                                Tools.IntervaloBucle(Me.txtVueltaBucle.Text, _
                                                     Me.txtVueltaLarga.Text, _
                                                     Me.txtNumTrenes.Text, _
                                                     Me.txtNbucle.Text)
                    Me.lblCalculaIntervaloLargo.Text = "Interv. Largo: " & _
                                Tools.IntervaloLargo(Me.txtVueltaBucle.Text, _
                                                     Me.txtVueltaLarga.Text, _
                                                     Me.txtNumTrenes.Text, _
                                                     Me.txtNbucle.Text)
                End If
            ElseIf Me.rbtnNoBucle.Checked Then
                intervalo = 3600 / Me.txtFrecIntervalo.Text

            End If

            Me.txtIntervaloResultado.Text = Format(intervalo, "0.00")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular el Intervalo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnIntervaloNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervaloNormal.Click
        Dim intervInyecciones As New Double
        Try
            If txtNbucle.Text <> 0 Then
                If Me.txtInyecciones.Text = 0 Then
                    intervInyecciones = Tools.IntervaloInyecciones(Me.txtIntervaloBucle.Text, _
                                                                 Me.txtNbucle.Text)
                Else
                    intervInyecciones = Tools.IntervaloFueraBucle(Me.txtNbucle.Text, _
                                                                Me.txtFrecuenciaIny.Text, _
                                                                Me.txtIntervaloLargo.Text)
                End If
            Else
                MessageBox.Show("Ingrese un numero para N (bucle)")
                Me.txtIntervaloResultadoNormal.Text = 0
            End If
            Me.txtIntervaloResultadoNormal.Text = Format(intervInyecciones, "0.000")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular el Intervalo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnIntervaloFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervaloFB.Click
        Dim intervFB As New Integer
        Try
            Me.txtIntervaloResultadoFB.Text = Format(Tools.IntervaloFueraBucle(Me.txtNbucleFB.Text, _
                                               Me.txtFrecuenciaFB.Text, _
                                               Me.txtIntervaloFB.Text), "0")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular el Intervalo Fuera de Bucle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpia.Click
        Me.txtFrecIntervalo.Text = 0
        Me.txtNumTrenes.Text = 0
        Me.txtVueltaLarga.Text = 0
        Me.txtVueltaBucle.Text = 0
        Me.txtNbucle.Text = 0
        Me.txtIntervaloResultado.Text = ""
        Me.txtInyecciones.Text = 0
        Me.txtFrecuenciaIny.Text = 0
        Me.txtIntervaloBucle.Text = 0
        Me.txtIntervaloLargo.Text = 0
        Me.txtIntervaloResultadoNormal.Text = ""
        Me.txtNbucleFB.Text = 0
        Me.txtIntervaloFB.Text = 0
        Me.txtIntervaloResultadoFB.Text = ""
        Me.lblCalculaIntervaloBucle.Text = ""
        Me.lblCalculaIntervaloLargo.Text = ""
        Me.txtFrecuenciaFB.Text = 0
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmIntervalo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Estado = 1 Then
            ' Deshabilito el módulo de Intervalo Fuera de Bucle
            Me.gpbIntervaloFB.Enabled = False
        ElseIf _Estado = 2 Then
            ' Deshabilito el módulo de Intervalo Normal
            Me.gpbIntervaloNormal.Enabled = False
        End If
    End Sub
    Private Sub rbtnBucle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnBucle.CheckedChanged
        If rbtnBucle.Checked Then
            Me.lblVueltaLargaI.ForeColor = Color.Black
            Me.txtVueltaLarga.Enabled = True
            Me.lblVueltaCortaI.ForeColor = Color.Black
            Me.txtVueltaBucle.Enabled = True
            Me.lblNbucle.ForeColor = Color.Black
            Me.txtNbucle.Enabled = True
            Me.lblNumTrenes.ForeColor = Color.Black
            Me.txtNumTrenes.Enabled = True
            Me.txtFrecIntervalo.Enabled = False
            Me.lblFrecIntervalo.ForeColor = Color.Gray
        ElseIf rbtnNoBucle.Checked Then
            Me.lblVueltaLargaI.ForeColor = Color.Gray
            Me.txtVueltaLarga.Enabled = False
            Me.lblVueltaCortaI.ForeColor = Color.Gray
            Me.txtVueltaBucle.Enabled = False
            Me.lblNbucle.ForeColor = Color.Gray
            Me.txtNbucle.Enabled = False
            Me.lblNumTrenes.ForeColor = Color.Gray
            Me.txtNumTrenes.Enabled = False
            Me.txtFrecIntervalo.Enabled = True
            Me.lblFrecIntervalo.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtNumTrenes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumTrenes.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNbucleI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNbucle.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtInyecciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInyecciones.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtFrecIntervalo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrecIntervalo.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtVueltaLarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVueltaLarga.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtVueltaBucle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVueltaBucle.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtFrecuenciaIny_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrecuenciaIny.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtIntervaloLargo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervaloLargo.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtIntervaloBucle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervaloBucle.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtNbucleFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNbucleFB.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtIntervaloFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervaloFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtFrecuenciaFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrecuenciaFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
#End Region
End Class