Public Class Tools
    Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
    Public Shared Function Verificar_Tecla(ByVal Tecla_Presionada)
        Dim Teclas As String
        'Acepta todos los números, la tecla Backspace, la tecla Enter, la coma y el punto
        Teclas = "1234567890.," & Chr(Keys.Back)
        If InStr(1, Teclas, Chr(Tecla_Presionada)) Then
            Verificar_Tecla = Tecla_Presionada
        Else
            ' Si no es ninguna de las indicadas retorna 0
            Verificar_Tecla = 0
        End If
    End Function
    ' Recibe como argumento el formulario
    Public Shared Sub LimpiarTextBox(ByVal frm As Form)
        ' Recorre todos los controles que hay en el formulario
        For Each Control In frm.Controls
            ' Verifica si el control es de tipo TextBox
            If TypeOf Control Is TextBox Then
                ' Si es así, entonces lo limpia
                Control.Text = ""
            End If
        Next
    End Sub
    ' Recibe como argumento el formulario
    Public Shared Sub LimpiarNumericUpDown(ByVal frm As Form)
        ' Recorre todos los controles que hay en el formulario
        For Each Control In frm.Controls
            ' Verifica si el control es de tipo TextBox
            If TypeOf Control Is NumericUpDown Then
                ' Si es así, entonces lo limpia
                Control.value = 0
            End If
        Next
    End Sub
    Public Shared Function FrecuenciaNormal(ByVal intervalo As Double, _
                                            ByVal inyecciones As Integer) As Double
        Dim frecuencia As New Double
        If intervalo <> 0 Then
            frecuencia = (3600 / intervalo) + inyecciones
        End If
        Return frecuencia
    End Function
    Public Shared Function FrecuenciaFueraBucle(ByVal n As Integer, _
                                                ByVal intervalo As Double) As Double
        Dim frecuenciaFb As New Double
        frecuenciaFb = 1 / intervalo
        Return frecuenciaFb
    End Function
    Public Shared Function IntervaloNormalBucle(ByVal VueltaBucle As Integer, _
                                                ByVal VueltaLarga As Integer, _
                                                ByVal NumeroTrenes As Integer, _
                                                ByVal n As Integer) As Integer
        Dim intervaloConBucle As New Integer
        intervaloConBucle = CInt((VueltaBucle + (n * VueltaLarga)) / (NumeroTrenes * (1 + n)))
        Return intervaloConBucle
    End Function
    Public Shared Function IntervaloLargo(ByVal VueltaBucle As Integer, _
                                          ByVal VueltaLarga As Integer, _
                                          ByVal NumeroTrenes As Integer, _
                                          ByVal n As Integer) As Integer
        Dim InterLargo As New Integer
        InterLargo = CInt((VueltaBucle + (n * VueltaLarga)) / (NumeroTrenes * n))
        Return InterLargo
    End Function
    Public Shared Function IntervaloBucle(ByVal VueltaBucle As Integer, _
                                          ByVal VueltaLarga As Integer, _
                                          ByVal NumeroTrenes As Integer, _
                                          ByVal n As Integer) As Integer
        Dim InterBucle As New Integer
        InterBucle = CInt((VueltaBucle + (n * VueltaLarga)) / (NumeroTrenes))
        Return InterBucle
    End Function
    Public Shared Function IntervaloFueraBucle(ByVal n As Integer, _
                                               ByVal frecuencia As Double, _
                                              ByVal IntervaloLargo As Double)
        Dim intervaloFB As New Double
        If n > 0 Then
            intervaloFB = 3600 / frecuencia
        Else
            intervaloFB = IntervaloLargo
        End If
        Return intervaloFB
    End Function
    Public Shared Function IntervaloInyecciones(ByVal intervaloBucle As Double, _
                                                ByVal n As Integer) As Double
        Dim intervaloSinInyecciones As New Double
        intervaloSinInyecciones = intervaloBucle / (n + 1)
        Return intervaloSinInyecciones
    End Function
    Public Shared Function DensidadNormal(ByVal demanda As Double, _
                                          ByVal AsientosProm As Double, _
                                          ByVal FrecProm As Double, _
                                          ByVal CapacProm As Double, _
                                          ByVal Standar As Integer) As Double
        Dim densidad As New Double
        densidad = (demanda - (AsientosProm * FrecProm)) / (FrecProm * (CapacProm - AsientosProm))
        Return densidad * Standar
    End Function
    Public Shared Function DensidadFueraBucle(ByVal demandaFB As Double, _
                                              ByVal AsientosPromFB As Double, _
                                              ByVal FrecuenciaFB As Double, _
                                              ByVal CapacPromFB As Double, _
                                              ByVal StandarFB As Integer) As Double
        Dim densidadFB As New Double
        densidadFB = (demandaFB - (AsientosPromFB * FrecuenciaFB)) / (FrecuenciaFB * (CapacPromFB - AsientosPromFB))
        Return densidadFB * StandarFB
    End Function
End Class
