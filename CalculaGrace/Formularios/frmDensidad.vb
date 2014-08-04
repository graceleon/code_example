Public Class frmDensidad
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
    Private Sub btnDensidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDensidad.Click
        Dim densidad As New Double
        Try
            densidad = Tools.DensidadNormal(txtDemanda.Text, _
                                            txtAsientosProm.Text, _
                                            txtFrecuenciaProm.Text, _
                                            txtCapacidadProm.Text, _
                                            txtStandar.Text)
            Me.txtDensidadResultado.Text = Format(densidad, "0.000")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al calcular la densidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnDensidadFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDensidadFB.Click
        Dim densidadFB As New Double
        Try
            densidadFB = Tools.DensidadFueraBucle(txtDemandaFB.Text, _
                                                txtAsientosPromFB.Text, _
                                                txtFrecuenciaFB.Text, _
                                                txtCapacidadPromFB.Text, _
                                                txtStandarFB.Text)
            Me.txtDensidadResultadoFB.Text = Format(densidadFB, "0.000")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al calcular la densidad fuera de bucle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmDensidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Estado = 1 Then
            Me.gpbDensidadFueraBucle.Enabled = False
        ElseIf _Estado = 2 Then
            Me.gpbDensidadNormal.Enabled = False
        End If
    End Sub
    Private Sub btnAsientosProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsientosProm.Click
        Dim estado As Integer = 1
        Dim frmTrenAsientosProm As New frmTrenes(estado)
        frmTrenAsientosProm.Show()
    End Sub
    Private Sub btnFrecProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrecProm.Click
        Dim estado As Integer = 1
        Dim frmFrecPromedio As New frmFrecuencia(estado)
        frmFrecPromedio.Show()
    End Sub
    Private Sub btnCapacProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapacProm.Click
        Dim estado As Integer = 1
        Dim frmTrenCapacProm As New frmTrenes(estado)
        frmTrenCapacProm.Show()
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtDemanda.Text = 0
        Me.txtAsientosProm.Text = 0
        Me.txtFrecuenciaProm.Text = 0
        Me.txtCapacidadProm.Text = 0
        Me.txtDensidadResultado.Text = ""

        Me.txtDemandaFB.Text = 0
        Me.txtAsientosPromFB.Text = 0
        Me.txtFrecuenciaFB.Text = 0
        Me.txtCapacidadPromFB.Text = 0
        Me.txtDensidadResultadoFB.Text = ""
    End Sub
    Private Sub txtDemanda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDemanda.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtAsientosProm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAsientosProm.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtFrecuenciaProm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrecuenciaProm.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtCapacidadProm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidadProm.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtStandar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStandar.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub btnAsientosPromFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsientosPromFB.Click
        Dim estado As Integer = 1
        Dim frmTrenAsientosPromFB As New frmTrenes(estado)
        frmTrenAsientosPromFB.Show()
    End Sub
    Private Sub btnCapacidadPromFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapacidadPromFB.Click
        Dim estado As Integer = 1
        Dim frmTrenCapacPromFB As New frmTrenes(estado)
        frmTrenCapacPromFB.Show()
    End Sub
    Private Sub btnFrecuenciaFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrecuenciaFB.Click
        Dim estado As Integer = 2
        Dim frmFrecuenciaFB As New frmFrecuencia(estado)
        frmFrecuenciaFB.Show()
    End Sub
    Private Sub txtDemandaFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDemandaFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtAsientosPromFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAsientosPromFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtFrecuenciaFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrecuenciaFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtCapacidadPromFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidadPromFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
    Private Sub txtStandarFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStandarFB.KeyPress
        KeyAscii = Tools.Verificar_Tecla(KeyAscii)
    End Sub
#End Region
End Class