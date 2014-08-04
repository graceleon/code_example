Public Class frmFrecuencia
#Region "Campos"
    Private _Estado As New Integer
#End Region
#Region "Constructor"
    Sub New(ByVal Estado As Integer)
        InitializeComponent()
        _Estado = Estado
    End Sub
#End Region
#Region "Métodos"
    Private Sub btnFrecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrecuencia.Click
        Dim dividendo As New Double
        Dim divisor As New Double
        Dim frecuencia As New Double
        Try
            If Me.rbtnBucleFrec.Checked Then
                dividendo = CDbl(Me.txtNumeroTrenes.Text * (1 + Me.txtNbucleF.Text))
                divisor = CDbl(Me.txtVueltaBucle.Text + Me.txtNbucleF.Text * Me.txtVueltaLargaF.Text)
                frecuencia = CDbl(dividendo / divisor)
            Else
                frecuencia = CDbl(Me.txtNumeroTrenes.Text / Me.txtVueltaLargaF.Text)
            End If

            Me.txtFrecuenciaResultado.Text = Format(frecuencia * 3600, "0.000")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular la Frecuencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnFrecuenciaNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrecuenciaNormal.Click
        Dim frecNormal As New Double
        Try
            frecNormal = Tools.FrecuenciaNormal(Me.txtIntervalo.Text, _
                                                Me.txtInyecciones.Text)
            Me.txtFrecuenciaResultadoNormal.Text = Format(frecNormal, "0.000")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular la Frecuencia Normal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnFrecuenciaFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrecuenciaFB.Click
        Dim frecFB As New Double
        Try
            If Me.txtIntervaloFB.Text <> 0 Then
                frecFB = Tools.FrecuenciaFueraBucle(Me.txtNbucleFB.Text, _
                                                    Me.txtIntervaloFB.Text)
            Else
                MessageBox.Show("El Intervalo no puede ser cero")
                frecFB = 0
            End If
            Me.txtFrecuenciaResultadoFB.Text = Format(frecFB * 3600, "0.000")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular la Frecuencia fuera de bucle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtNumeroTrenes.Text = 0
        Me.txtNbucleF.Text = 0
        Me.txtVueltaBucle.Text = 0
        Me.txtVueltaLargaF.Text = 0
        Me.txtFrecuenciaResultado.Text = ""
        Me.txtIntervalo.Text = 0
        Me.txtInyecciones.Text = 0
        Me.txtFrecuenciaResultadoNormal.Text = ""
        Me.txtNbucleF.Text = 0
        Me.txtNbucleFB.Text = 0
        Me.txtIntervaloFB.Text = 0
        Me.txtFrecuenciaResultadoFB.Text = ""
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmFrecuencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Estado = 1 Then
            ' Deshabilito los textbox del item Frecuencia que sin bucle no se necesitan para los cálculos
            Me.lblVueltaBucle.ForeColor = Color.Gray
            Me.txtVueltaBucle.Enabled = False
            Me.lblNbucleF.ForeColor = Color.Gray
            Me.txtNbucleF.Enabled = False

            ' Deshabilito el módulo de Frecuencia Fuera de bucle
            Me.gpbFrecFB.ForeColor = Color.Gray
            Me.gpbFrecFB.Enabled = False
        ElseIf _Estado = 2 Then
            ' Deshabilito el módulo de Frecuencia Normal
            Me.gpbFrecNormal.ForeColor = Color.Gray
            Me.gpbFrecNormal.Enabled = False
        End If
    End Sub
    Private Sub rbtnBucleFrec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnBucleFrec.CheckedChanged
        If rbtnBucleFrec.Checked Then
            Me.lblVueltaBucle.ForeColor = Color.Black
            Me.txtVueltaBucle.Enabled = True
            Me.lblNbucleF.ForeColor = Color.Black
            Me.txtNbucleF.Enabled = True
        ElseIf rbtnNoBucleF.Checked Then
            Me.lblVueltaBucle.ForeColor = Color.Gray
            Me.txtVueltaBucle.Enabled = False
            Me.lblNbucleF.ForeColor = Color.Gray
            Me.txtNbucleF.Enabled = False
        End If
    End Sub
    Private Sub txtNumeroTrenes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroTrenes.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNbucleF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNbucleF.KeyPress
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
    Private Sub txtNbucleFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNbucleFB.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVueltaLargaF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVueltaLargaF.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVueltaBucle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVueltaBucle.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtIntervalo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervalo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtIntervaloFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervaloFB.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Tools.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class