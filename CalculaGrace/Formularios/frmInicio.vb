Public Class frmInicio
    Private Sub FrecNormalTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrecNormalTSMI.Click
        Dim estado As Integer = 1
        Dim frecNormal As New frmFrecuencia(estado)
        frecNormal.Show()
    End Sub
    Private Sub FrecFueraBucleTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrecFueraBucleTSMI.Click
        Dim estado As Integer = 2
        Dim frecFueraBucle As New frmFrecuencia(estado)
        frecFueraBucle.Show()
    End Sub
    Private Sub ConversorUnidadesTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversorUnidadesTSMI.Click
        Dim frmConvUnidades As New frmConversorUnidades
        frmConvUnidades.Show()
    End Sub
    Private Sub ConversorDecimalesTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversorDecimalesTSMI.Click
        Dim frmConvHoras As New frmConversorDecimal
        frmConvHoras.Show()
    End Sub
    Private Sub IntervaloNormalTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntervaloNormalTSMI.Click
        Dim estado As Integer = 1
        Dim frmIntervaloNormal As New frmIntervalo(estado)
        frmIntervaloNormal.Show()
    End Sub
    Private Sub InterFueraBucleTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterFueraBucleTSMI.Click
        Dim estado As Integer = 2
        Dim frmIntervaloFueraBucle As New frmIntervalo(estado)
        frmIntervaloFueraBucle.Show()
    End Sub
    Private Sub OfertaNormalTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfertaNormalTSMI.Click
        Dim estado As Integer = 1
        Dim frmOfertaNormal As New frmOferta(estado)
        frmOfertaNormal.Show()
    End Sub
    Private Sub OfertaFueraBucleTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfertaFueraBucleTSMI.Click
        Dim estado As Integer = 2
        Dim frmOfertaFueraBucle As New frmOferta(estado)
        frmOfertaFueraBucle.Show()
    End Sub
    Private Sub DatosTrenesTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosTrenesTSMI.Click
        Dim estado As Integer = 1
        Dim frmDatosTrenes As New frmTrenes(estado)
        frmDatosTrenes.Show()
    End Sub
    Private Sub TrenesLargosTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrenesLargosTSMI.Click
        Dim estado As Integer = 2
        Dim frmTrenesLargos As New frmTrenes(estado)
        frmTrenesLargos.Show()
    End Sub
    Private Sub TrenesBucleTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrenesBucleTSMI.Click
        Dim estado As Integer = 3
        Dim frmTrenesBucle As New frmTrenes(estado)
        frmTrenesBucle.Show()
    End Sub
    Private Sub DensidadNormalTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DensidadNormalTSMI.Click
        Dim estado As Integer = 1
        Dim frmDensidadNormal As New frmDensidad(estado)
        frmDensidadNormal.Show()
    End Sub

    Private Sub DensidadFueraBucleTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DensidadFueraBucleTSMI.Click
        Dim estado As Integer = 2
        Dim frmDensidadFueraBucle As New frmDensidad(estado)
        frmDensidadFueraBucle.Show()
    End Sub
    Private Sub DmdaProyectadaTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DmdaProyectadaTSMI.Click
        Dim frmDemandaProyectada As New frmDemanda
        frmDemandaProyectada.Show()
    End Sub
End Class