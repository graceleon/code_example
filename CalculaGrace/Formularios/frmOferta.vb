Public Class frmOferta
#Region "Campos"
    Private _estado As Integer
#End Region
#Region "Constructor"
    Sub New(ByVal estado As Integer)
        InitializeComponent()
        _estado = estado
    End Sub
#End Region
#Region "Métodos"
    Private Sub btnOferta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOferta.Click
        Dim oferta As New Double
        Try
            If txtFrecuencia.Text <> "" AndAlso txtCapacidadTrenes.Text <> "" Then
                oferta = CDbl(txtFrecuencia.Text * txtCapacidadTrenes.Text)
            Else
                oferta = Nothing
                MessageBox.Show("Ingrese los datos requeridos")
            End If
            Me.txtOfertaResultado.Text = oferta
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular la Oferta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnOfertaFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOfertaFB.Click
        Dim ofertaFB As New Double
        Try
            If txtFrecFB.Text <> "" AndAlso txtCapacidadTrenesFB.Text <> "" Then
                ofertaFB = CDbl(txtFrecFB.Text * txtCapacidadTrenesFB.Text)
            Else
                ofertaFB = Nothing
                MessageBox.Show("Ingrese los datos requeridos")
            End If
            Me.txtOfertaResultadoFB.Text = ofertaFB
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Calcular la Oferta Fuera de Bucle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpia.Click
        Me.txtFrecuencia.Text = 0
        Me.txtFrecFB.Text = 0
        Me.txtCapacidadTrenes.Text = 0
        Me.txtCapacidadTrenesFB.Text = 0
        Me.txtOfertaResultado.Text = ""
        Me.txtOfertaResultadoFB.Text = ""
    End Sub
    Private Sub btnCantidadTrenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCantidadTrenes.Click
        Dim estado As Integer = 1
        Dim frmTrenes As New frmTrenes(estado)
        frmTrenes.Show()
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmOferta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _estado = 1 Then
            ' Deshabilito el módulo de Oferta Fuera de bucle
            Me.gpbOfertaFueraBucle.Enabled = False
        ElseIf _estado = 2 Then
            ' Deshabilito el módulo de Oferta Normal
            Me.gpbOferta.Enabled = False
        End If
    End Sub
#End Region

End Class