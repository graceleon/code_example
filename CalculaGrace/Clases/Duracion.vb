<Serializable()> _
Public Class Duracion
    Implements System.ICloneable
    Implements System.IComparable
#Region "Campos"
    Private _Segundos As Integer
#End Region

#Region "Constructores"
    Public Sub New()
        Me._Segundos = 0
    End Sub
    Public Sub New(ByVal nSegundos As Integer)
        Me._Segundos = nSegundos
    End Sub
#End Region

#Region "Propiedades"
    Public Property Segundos As Integer
        Get
            Return Me._Segundos
        End Get
        Set(ByVal value As Integer)
            If Me._Segundos <> value Then
                Me._Segundos = value
            End If
        End Set
    End Property
#End Region

#Region "Operadores"

#Region "Operadores Binarios"
    Public Shared Operator -(ByVal d1 As Duracion, ByVal d2 As Duracion) As Duracion
        Return New Duracion(d1.Segundos - d2.Segundos)
    End Operator
    Public Shared Operator -(ByVal d1 As Duracion, ByVal d2 As Integer) As Duracion
        Return New Duracion(d1.Segundos - d2)
    End Operator
    Public Shared Operator +(ByVal d1 As Duracion, ByVal d2 As Duracion) As Duracion
        Return New Duracion(d1.Segundos + d2.Segundos)
    End Operator
    Public Shared Operator +(ByVal d1 As Duracion, ByVal d2 As Integer) As Duracion
        Return New Duracion(d1.Segundos + d2)
    End Operator
    'Public Shared Operator =(ByVal d1 As Duracion, ByVal d2 As Duracion) As Boolean
    '    Return d1.Segundos = d2.Segundos
    'End Operator
    'Public Shared Operator <>(ByVal d1 As Duracion, ByVal d2 As Duracion) As Boolean
    '    Return d1.Segundos <> d2.Segundos
    'End Operator
    Public Shared Operator \(ByVal d1 As Duracion, ByVal d2 As Integer) As Duracion
        Return New Duracion(d1.Segundos \ d2)
    End Operator
    Public Shared Operator *(ByVal d1 As Duracion, ByVal d2 As Integer) As Duracion
        Return New Duracion(d1.Segundos * d2)
    End Operator
#End Region

#Region "Operadores de Comparación"
    Public Shared Operator <=(ByVal d1 As Duracion, ByVal d2 As Duracion) As Boolean
        Return d1.Segundos <= d2.Segundos
    End Operator

    Public Shared Operator >=(ByVal d1 As Duracion, ByVal d2 As Duracion) As Boolean
        Return d1.Segundos >= d2.Segundos
    End Operator


    Public Shared Operator <=(ByVal d1 As Duracion, ByVal d2 As Integer) As Boolean
        Return d1.Segundos <= d2
    End Operator

    Public Shared Operator >=(ByVal d1 As Duracion, ByVal d2 As Integer) As Boolean
        Return d1.Segundos >= d2
    End Operator

    Public Shared Operator >(ByVal d1 As Duracion, ByVal d2 As Integer) As Boolean
        Return d1.Segundos > d2
    End Operator
    Public Shared Operator <(ByVal d1 As Duracion, ByVal d2 As Integer) As Boolean
        Return d1.Segundos < d2
    End Operator

    Public Shared Operator >(ByVal d1 As Duracion, ByVal d2 As Duracion) As Boolean
        Return d1.Segundos > d2.Segundos
    End Operator
    Public Shared Operator <(ByVal d1 As Duracion, ByVal d2 As Duracion) As Boolean
        Return d1.Segundos < d2.Segundos
    End Operator
#End Region

#Region "Operadores de Conversión"
    'Public Shared Narrowing Operator CType(ByVal D As TimeSpan) As Duracion
    '    Return New Duracion(CInt(D.TotalSeconds))
    'End Operator
    'Public Shared Widening Operator CType(ByVal D As Duracion) As TimeSpan
    '    Return New TimeSpan(CLng(D.Segundos * TimeSpan.TicksPerSecond))
    'End Operator
#End Region

#End Region

#Region "Metodos"
    Public Shared Function FromTimespan(ByVal [TimeSpan] As TimeSpan) As Duracion
        Return New Duracion(CInt([TimeSpan].TotalSeconds))
    End Function

    Public Function TotalHoras() As Double
        Return Segundos / 3600
    End Function
    Public Overrides Function ToString() As String
        Return ToString("hh:mm:ss")
    End Function
    Public Overloads Function ToString(ByVal Formato As String) As String
        Dim t As Integer = _Segundos \ 60
        Dim s As Integer = _Segundos Mod 60
        Dim m As Integer = t Mod 60
        Dim h As Integer = t \ 60
        Select Case Formato.Trim.ToLower
            Case "hh:mm"
                Return h.ToString("00") & ":" & m.ToString("00")
            Case "h:mm"
                Return h.ToString() & ":" & m.ToString("00")
            Case "hh"
                Return h.ToString("00")
            Case "h"
                Return h.ToString()
            Case "s"
                Return _Segundos.ToString
            Case "ss"
                Return _Segundos.ToString("00")
            Case "hh:mm:ss"
                Return h.ToString("00") & ":" & m.ToString("00") & ":" & s.ToString("00") '  +/- hh:mm:ss
            Case Else
                Return h.ToString & ":" & m.ToString("00") & ":" & s.ToString("00") '  +/- hh:mm:ss
        End Select
    End Function
    Public Function ToDate() As Date
        Return Date.MinValue.AddSeconds(Me._Segundos)
    End Function
    Public Function Clone() As Object Implements System.ICloneable.Clone
        ' Se puede hacer una copia superficial del objeto al este no ser compuesto,
        ' es decir todos sus campos son tipos primitivos
        Return Me.MemberwiseClone
    End Function
    Public Function Copy() As Duracion
        Return DirectCast(Clone(), Duracion)
    End Function
#End Region

#Region "IComparable"
    Public Function CompareTo(ByVal Obj As Object) As Integer Implements IComparable.CompareTo
        Dim Comparando As Duracion = DirectCast(Obj, Duracion)
        If Comparando Is Nothing Then
            Return 1
        Else
            Return Me._Segundos - Comparando._Segundos
        End If
    End Function
#End Region

End Class

