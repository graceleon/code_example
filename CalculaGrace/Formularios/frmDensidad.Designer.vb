<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDensidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDensidad))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gpbDensidadNormal = New System.Windows.Forms.GroupBox()
        Me.txtStandar = New System.Windows.Forms.TextBox()
        Me.lblStandar = New System.Windows.Forms.Label()
        Me.txtDensidadResultado = New System.Windows.Forms.TextBox()
        Me.btnDensidad = New System.Windows.Forms.Button()
        Me.btnCapacProm = New System.Windows.Forms.Button()
        Me.txtCapacidadProm = New System.Windows.Forms.TextBox()
        Me.lblCapacidadProm = New System.Windows.Forms.Label()
        Me.btnFrecProm = New System.Windows.Forms.Button()
        Me.txtFrecuenciaProm = New System.Windows.Forms.TextBox()
        Me.lblFrecuenciaPromedio = New System.Windows.Forms.Label()
        Me.btnAsientosProm = New System.Windows.Forms.Button()
        Me.txtAsientosProm = New System.Windows.Forms.TextBox()
        Me.lblAsientosPromedio = New System.Windows.Forms.Label()
        Me.txtDemanda = New System.Windows.Forms.TextBox()
        Me.lblDemanda = New System.Windows.Forms.Label()
        Me.gpbDensidadFueraBucle = New System.Windows.Forms.GroupBox()
        Me.txtStandarFB = New System.Windows.Forms.TextBox()
        Me.lblStandarFB = New System.Windows.Forms.Label()
        Me.txtDensidadResultadoFB = New System.Windows.Forms.TextBox()
        Me.btnDensidadFB = New System.Windows.Forms.Button()
        Me.btnCapacidadPromFB = New System.Windows.Forms.Button()
        Me.txtCapacidadPromFB = New System.Windows.Forms.TextBox()
        Me.lblCapacidadPromFB = New System.Windows.Forms.Label()
        Me.btnFrecuenciaFB = New System.Windows.Forms.Button()
        Me.txtFrecuenciaFB = New System.Windows.Forms.TextBox()
        Me.lblFrecuenciaFB = New System.Windows.Forms.Label()
        Me.btnAsientosPromFB = New System.Windows.Forms.Button()
        Me.txtAsientosPromFB = New System.Windows.Forms.TextBox()
        Me.lblAsientosPromFB = New System.Windows.Forms.Label()
        Me.txtDemandaFB = New System.Windows.Forms.TextBox()
        Me.lblDemandaFB = New System.Windows.Forms.Label()
        Me.lblDensidadDef = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gpbDensidadNormal.SuspendLayout()
        Me.gpbDensidadFueraBucle.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.8463!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.1537!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpiar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbDensidadNormal, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbDensidadFueraBucle, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDensidadDef, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95547!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.04453!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(553, 470)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(525, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(25, 24)
        Me.btnLimpiar.TabIndex = 0
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'gpbDensidadNormal
        '
        Me.gpbDensidadNormal.Controls.Add(Me.txtStandar)
        Me.gpbDensidadNormal.Controls.Add(Me.lblStandar)
        Me.gpbDensidadNormal.Controls.Add(Me.txtDensidadResultado)
        Me.gpbDensidadNormal.Controls.Add(Me.btnDensidad)
        Me.gpbDensidadNormal.Controls.Add(Me.btnCapacProm)
        Me.gpbDensidadNormal.Controls.Add(Me.txtCapacidadProm)
        Me.gpbDensidadNormal.Controls.Add(Me.lblCapacidadProm)
        Me.gpbDensidadNormal.Controls.Add(Me.btnFrecProm)
        Me.gpbDensidadNormal.Controls.Add(Me.txtFrecuenciaProm)
        Me.gpbDensidadNormal.Controls.Add(Me.lblFrecuenciaPromedio)
        Me.gpbDensidadNormal.Controls.Add(Me.btnAsientosProm)
        Me.gpbDensidadNormal.Controls.Add(Me.txtAsientosProm)
        Me.gpbDensidadNormal.Controls.Add(Me.lblAsientosPromedio)
        Me.gpbDensidadNormal.Controls.Add(Me.txtDemanda)
        Me.gpbDensidadNormal.Controls.Add(Me.lblDemanda)
        Me.gpbDensidadNormal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbDensidadNormal.Location = New System.Drawing.Point(17, 34)
        Me.gpbDensidadNormal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDensidadNormal.Name = "gpbDensidadNormal"
        Me.gpbDensidadNormal.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDensidadNormal.Size = New System.Drawing.Size(502, 198)
        Me.gpbDensidadNormal.TabIndex = 0
        Me.gpbDensidadNormal.TabStop = False
        Me.gpbDensidadNormal.Text = "Densidad Normal"
        '
        'txtStandar
        '
        Me.txtStandar.Location = New System.Drawing.Point(410, 35)
        Me.txtStandar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStandar.MaxLength = 10
        Me.txtStandar.Name = "txtStandar"
        Me.txtStandar.Size = New System.Drawing.Size(66, 24)
        Me.txtStandar.TabIndex = 42
        Me.txtStandar.Text = "6"
        Me.txtStandar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStandar
        '
        Me.lblStandar.AutoSize = True
        Me.lblStandar.Location = New System.Drawing.Point(301, 38)
        Me.lblStandar.Name = "lblStandar"
        Me.lblStandar.Size = New System.Drawing.Size(103, 16)
        Me.lblStandar.TabIndex = 43
        Me.lblStandar.Text = "Standar (pax/m2)"
        '
        'txtDensidadResultado
        '
        Me.txtDensidadResultado.BackColor = System.Drawing.Color.White
        Me.txtDensidadResultado.Location = New System.Drawing.Point(397, 156)
        Me.txtDensidadResultado.MaxLength = 15
        Me.txtDensidadResultado.Name = "txtDensidadResultado"
        Me.txtDensidadResultado.ReadOnly = True
        Me.txtDensidadResultado.Size = New System.Drawing.Size(95, 24)
        Me.txtDensidadResultado.TabIndex = 41
        Me.txtDensidadResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDensidad
        '
        Me.btnDensidad.BackColor = System.Drawing.Color.YellowGreen
        Me.btnDensidad.Location = New System.Drawing.Point(397, 114)
        Me.btnDensidad.Name = "btnDensidad"
        Me.btnDensidad.Size = New System.Drawing.Size(95, 29)
        Me.btnDensidad.TabIndex = 40
        Me.btnDensidad.Text = "Densidad"
        Me.btnDensidad.UseVisualStyleBackColor = False
        '
        'btnCapacProm
        '
        Me.btnCapacProm.Image = Global.CalculaGrace.My.Resources.Resources.flecha
        Me.btnCapacProm.Location = New System.Drawing.Point(254, 155)
        Me.btnCapacProm.Name = "btnCapacProm"
        Me.btnCapacProm.Size = New System.Drawing.Size(41, 33)
        Me.btnCapacProm.TabIndex = 39
        Me.btnCapacProm.UseVisualStyleBackColor = True
        '
        'txtCapacidadProm
        '
        Me.txtCapacidadProm.Location = New System.Drawing.Point(148, 160)
        Me.txtCapacidadProm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCapacidadProm.MaxLength = 10
        Me.txtCapacidadProm.Name = "txtCapacidadProm"
        Me.txtCapacidadProm.Size = New System.Drawing.Size(100, 24)
        Me.txtCapacidadProm.TabIndex = 37
        Me.txtCapacidadProm.Text = "0"
        '
        'lblCapacidadProm
        '
        Me.lblCapacidadProm.AutoSize = True
        Me.lblCapacidadProm.Location = New System.Drawing.Point(22, 163)
        Me.lblCapacidadProm.Name = "lblCapacidadProm"
        Me.lblCapacidadProm.Size = New System.Drawing.Size(117, 16)
        Me.lblCapacidadProm.TabIndex = 38
        Me.lblCapacidadProm.Text = "Capacidad Promedio"
        '
        'btnFrecProm
        '
        Me.btnFrecProm.Image = Global.CalculaGrace.My.Resources.Resources.flecha
        Me.btnFrecProm.Location = New System.Drawing.Point(254, 112)
        Me.btnFrecProm.Name = "btnFrecProm"
        Me.btnFrecProm.Size = New System.Drawing.Size(41, 33)
        Me.btnFrecProm.TabIndex = 36
        Me.btnFrecProm.UseVisualStyleBackColor = True
        '
        'txtFrecuenciaProm
        '
        Me.txtFrecuenciaProm.Location = New System.Drawing.Point(148, 117)
        Me.txtFrecuenciaProm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFrecuenciaProm.MaxLength = 10
        Me.txtFrecuenciaProm.Name = "txtFrecuenciaProm"
        Me.txtFrecuenciaProm.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecuenciaProm.TabIndex = 34
        Me.txtFrecuenciaProm.Text = "0"
        '
        'lblFrecuenciaPromedio
        '
        Me.lblFrecuenciaPromedio.AutoSize = True
        Me.lblFrecuenciaPromedio.Location = New System.Drawing.Point(22, 120)
        Me.lblFrecuenciaPromedio.Name = "lblFrecuenciaPromedio"
        Me.lblFrecuenciaPromedio.Size = New System.Drawing.Size(118, 16)
        Me.lblFrecuenciaPromedio.TabIndex = 35
        Me.lblFrecuenciaPromedio.Text = "Frecuencia Promedio"
        '
        'btnAsientosProm
        '
        Me.btnAsientosProm.Image = Global.CalculaGrace.My.Resources.Resources.flecha
        Me.btnAsientosProm.Location = New System.Drawing.Point(254, 71)
        Me.btnAsientosProm.Name = "btnAsientosProm"
        Me.btnAsientosProm.Size = New System.Drawing.Size(41, 33)
        Me.btnAsientosProm.TabIndex = 33
        Me.btnAsientosProm.UseVisualStyleBackColor = True
        '
        'txtAsientosProm
        '
        Me.txtAsientosProm.Location = New System.Drawing.Point(148, 76)
        Me.txtAsientosProm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAsientosProm.MaxLength = 10
        Me.txtAsientosProm.Name = "txtAsientosProm"
        Me.txtAsientosProm.Size = New System.Drawing.Size(100, 24)
        Me.txtAsientosProm.TabIndex = 31
        Me.txtAsientosProm.Text = "0"
        '
        'lblAsientosPromedio
        '
        Me.lblAsientosPromedio.AutoSize = True
        Me.lblAsientosPromedio.Location = New System.Drawing.Point(22, 79)
        Me.lblAsientosPromedio.Name = "lblAsientosPromedio"
        Me.lblAsientosPromedio.Size = New System.Drawing.Size(107, 16)
        Me.lblAsientosPromedio.TabIndex = 32
        Me.lblAsientosPromedio.Text = "Asientos Promedio"
        '
        'txtDemanda
        '
        Me.txtDemanda.Location = New System.Drawing.Point(148, 35)
        Me.txtDemanda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDemanda.MaxLength = 10
        Me.txtDemanda.Name = "txtDemanda"
        Me.txtDemanda.Size = New System.Drawing.Size(100, 24)
        Me.txtDemanda.TabIndex = 29
        Me.txtDemanda.Text = "0"
        '
        'lblDemanda
        '
        Me.lblDemanda.AutoSize = True
        Me.lblDemanda.Location = New System.Drawing.Point(22, 38)
        Me.lblDemanda.Name = "lblDemanda"
        Me.lblDemanda.Size = New System.Drawing.Size(102, 16)
        Me.lblDemanda.TabIndex = 30
        Me.lblDemanda.Text = "Demanda (pax/hr)"
        '
        'gpbDensidadFueraBucle
        '
        Me.gpbDensidadFueraBucle.Controls.Add(Me.txtStandarFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.lblStandarFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.txtDensidadResultadoFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.btnDensidadFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.btnCapacidadPromFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.txtCapacidadPromFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.lblCapacidadPromFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.btnFrecuenciaFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.txtFrecuenciaFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.lblFrecuenciaFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.btnAsientosPromFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.txtAsientosPromFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.lblAsientosPromFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.txtDemandaFB)
        Me.gpbDensidadFueraBucle.Controls.Add(Me.lblDemandaFB)
        Me.gpbDensidadFueraBucle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbDensidadFueraBucle.Location = New System.Drawing.Point(17, 249)
        Me.gpbDensidadFueraBucle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDensidadFueraBucle.Name = "gpbDensidadFueraBucle"
        Me.gpbDensidadFueraBucle.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDensidadFueraBucle.Size = New System.Drawing.Size(502, 203)
        Me.gpbDensidadFueraBucle.TabIndex = 1
        Me.gpbDensidadFueraBucle.TabStop = False
        Me.gpbDensidadFueraBucle.Text = "Densidad Fuera de Bucle"
        '
        'txtStandarFB
        '
        Me.txtStandarFB.Location = New System.Drawing.Point(410, 36)
        Me.txtStandarFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStandarFB.MaxLength = 10
        Me.txtStandarFB.Name = "txtStandarFB"
        Me.txtStandarFB.Size = New System.Drawing.Size(66, 24)
        Me.txtStandarFB.TabIndex = 57
        Me.txtStandarFB.Text = "6"
        Me.txtStandarFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStandarFB
        '
        Me.lblStandarFB.AutoSize = True
        Me.lblStandarFB.Location = New System.Drawing.Point(301, 39)
        Me.lblStandarFB.Name = "lblStandarFB"
        Me.lblStandarFB.Size = New System.Drawing.Size(103, 16)
        Me.lblStandarFB.TabIndex = 58
        Me.lblStandarFB.Text = "Standar (pax/m2)"
        '
        'txtDensidadResultadoFB
        '
        Me.txtDensidadResultadoFB.BackColor = System.Drawing.Color.White
        Me.txtDensidadResultadoFB.Location = New System.Drawing.Point(397, 157)
        Me.txtDensidadResultadoFB.MaxLength = 15
        Me.txtDensidadResultadoFB.Name = "txtDensidadResultadoFB"
        Me.txtDensidadResultadoFB.ReadOnly = True
        Me.txtDensidadResultadoFB.Size = New System.Drawing.Size(95, 24)
        Me.txtDensidadResultadoFB.TabIndex = 56
        Me.txtDensidadResultadoFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDensidadFB
        '
        Me.btnDensidadFB.BackColor = System.Drawing.Color.YellowGreen
        Me.btnDensidadFB.Location = New System.Drawing.Point(397, 115)
        Me.btnDensidadFB.Name = "btnDensidadFB"
        Me.btnDensidadFB.Size = New System.Drawing.Size(95, 29)
        Me.btnDensidadFB.TabIndex = 55
        Me.btnDensidadFB.Text = "Densidad"
        Me.btnDensidadFB.UseVisualStyleBackColor = False
        '
        'btnCapacidadPromFB
        '
        Me.btnCapacidadPromFB.Image = Global.CalculaGrace.My.Resources.Resources.flecha
        Me.btnCapacidadPromFB.Location = New System.Drawing.Point(301, 156)
        Me.btnCapacidadPromFB.Name = "btnCapacidadPromFB"
        Me.btnCapacidadPromFB.Size = New System.Drawing.Size(41, 33)
        Me.btnCapacidadPromFB.TabIndex = 54
        Me.btnCapacidadPromFB.UseVisualStyleBackColor = True
        '
        'txtCapacidadPromFB
        '
        Me.txtCapacidadPromFB.Location = New System.Drawing.Point(195, 161)
        Me.txtCapacidadPromFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCapacidadPromFB.MaxLength = 10
        Me.txtCapacidadPromFB.Name = "txtCapacidadPromFB"
        Me.txtCapacidadPromFB.Size = New System.Drawing.Size(100, 24)
        Me.txtCapacidadPromFB.TabIndex = 52
        Me.txtCapacidadPromFB.Text = "0"
        '
        'lblCapacidadPromFB
        '
        Me.lblCapacidadPromFB.AutoSize = True
        Me.lblCapacidadPromFB.Location = New System.Drawing.Point(22, 164)
        Me.lblCapacidadPromFB.Name = "lblCapacidadPromFB"
        Me.lblCapacidadPromFB.Size = New System.Drawing.Size(117, 16)
        Me.lblCapacidadPromFB.TabIndex = 53
        Me.lblCapacidadPromFB.Text = "Capacidad Promedio"
        '
        'btnFrecuenciaFB
        '
        Me.btnFrecuenciaFB.Image = Global.CalculaGrace.My.Resources.Resources.flecha
        Me.btnFrecuenciaFB.Location = New System.Drawing.Point(301, 113)
        Me.btnFrecuenciaFB.Name = "btnFrecuenciaFB"
        Me.btnFrecuenciaFB.Size = New System.Drawing.Size(41, 33)
        Me.btnFrecuenciaFB.TabIndex = 51
        Me.btnFrecuenciaFB.UseVisualStyleBackColor = True
        '
        'txtFrecuenciaFB
        '
        Me.txtFrecuenciaFB.Location = New System.Drawing.Point(195, 118)
        Me.txtFrecuenciaFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFrecuenciaFB.MaxLength = 10
        Me.txtFrecuenciaFB.Name = "txtFrecuenciaFB"
        Me.txtFrecuenciaFB.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecuenciaFB.TabIndex = 49
        Me.txtFrecuenciaFB.Text = "0"
        '
        'lblFrecuenciaFB
        '
        Me.lblFrecuenciaFB.AutoSize = True
        Me.lblFrecuenciaFB.Location = New System.Drawing.Point(22, 121)
        Me.lblFrecuenciaFB.Name = "lblFrecuenciaFB"
        Me.lblFrecuenciaFB.Size = New System.Drawing.Size(148, 16)
        Me.lblFrecuenciaFB.TabIndex = 50
        Me.lblFrecuenciaFB.Text = "Frecuencia Fuera de Bucle"
        '
        'btnAsientosPromFB
        '
        Me.btnAsientosPromFB.Image = Global.CalculaGrace.My.Resources.Resources.flecha
        Me.btnAsientosPromFB.Location = New System.Drawing.Point(301, 72)
        Me.btnAsientosPromFB.Name = "btnAsientosPromFB"
        Me.btnAsientosPromFB.Size = New System.Drawing.Size(41, 33)
        Me.btnAsientosPromFB.TabIndex = 48
        Me.btnAsientosPromFB.UseVisualStyleBackColor = True
        '
        'txtAsientosPromFB
        '
        Me.txtAsientosPromFB.Location = New System.Drawing.Point(195, 77)
        Me.txtAsientosPromFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAsientosPromFB.MaxLength = 10
        Me.txtAsientosPromFB.Name = "txtAsientosPromFB"
        Me.txtAsientosPromFB.Size = New System.Drawing.Size(100, 24)
        Me.txtAsientosPromFB.TabIndex = 46
        Me.txtAsientosPromFB.Text = "0"
        '
        'lblAsientosPromFB
        '
        Me.lblAsientosPromFB.AutoSize = True
        Me.lblAsientosPromFB.Location = New System.Drawing.Point(22, 80)
        Me.lblAsientosPromFB.Name = "lblAsientosPromFB"
        Me.lblAsientosPromFB.Size = New System.Drawing.Size(107, 16)
        Me.lblAsientosPromFB.TabIndex = 47
        Me.lblAsientosPromFB.Text = "Asientos Promedio"
        '
        'txtDemandaFB
        '
        Me.txtDemandaFB.Location = New System.Drawing.Point(195, 36)
        Me.txtDemandaFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDemandaFB.MaxLength = 10
        Me.txtDemandaFB.Name = "txtDemandaFB"
        Me.txtDemandaFB.Size = New System.Drawing.Size(100, 24)
        Me.txtDemandaFB.TabIndex = 44
        Me.txtDemandaFB.Text = "0"
        '
        'lblDemandaFB
        '
        Me.lblDemandaFB.AutoSize = True
        Me.lblDemandaFB.Location = New System.Drawing.Point(22, 39)
        Me.lblDemandaFB.Name = "lblDemandaFB"
        Me.lblDemandaFB.Size = New System.Drawing.Size(168, 16)
        Me.lblDemandaFB.TabIndex = 45
        Me.lblDemandaFB.Text = "Demanda Fuera Bucle (pax/hr)"
        '
        'lblDensidadDef
        '
        Me.lblDensidadDef.AutoSize = True
        Me.lblDensidadDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDensidadDef.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDensidadDef.Location = New System.Drawing.Point(17, 0)
        Me.lblDensidadDef.Name = "lblDensidadDef"
        Me.lblDensidadDef.Size = New System.Drawing.Size(502, 30)
        Me.lblDensidadDef.TabIndex = 9
        Me.lblDensidadDef.Text = "Densidad: pasajeros por metro cuadrado que viajan de pie en el tren"
        Me.lblDensidadDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDensidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 470)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDensidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Densidad"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gpbDensidadNormal.ResumeLayout(False)
        Me.gpbDensidadNormal.PerformLayout()
        Me.gpbDensidadFueraBucle.ResumeLayout(False)
        Me.gpbDensidadFueraBucle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gpbDensidadNormal As System.Windows.Forms.GroupBox
    Friend WithEvents gpbDensidadFueraBucle As System.Windows.Forms.GroupBox
    Friend WithEvents btnCapacProm As System.Windows.Forms.Button
    Friend WithEvents txtCapacidadProm As System.Windows.Forms.TextBox
    Friend WithEvents lblCapacidadProm As System.Windows.Forms.Label
    Friend WithEvents btnFrecProm As System.Windows.Forms.Button
    Friend WithEvents txtFrecuenciaProm As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecuenciaPromedio As System.Windows.Forms.Label
    Friend WithEvents btnAsientosProm As System.Windows.Forms.Button
    Friend WithEvents txtAsientosProm As System.Windows.Forms.TextBox
    Friend WithEvents lblAsientosPromedio As System.Windows.Forms.Label
    Friend WithEvents txtDemanda As System.Windows.Forms.TextBox
    Friend WithEvents lblDemanda As System.Windows.Forms.Label
    Friend WithEvents txtDensidadResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnDensidad As System.Windows.Forms.Button
    Friend WithEvents lblDensidadDef As System.Windows.Forms.Label
    Friend WithEvents txtStandar As System.Windows.Forms.TextBox
    Friend WithEvents lblStandar As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtStandarFB As System.Windows.Forms.TextBox
    Friend WithEvents lblStandarFB As System.Windows.Forms.Label
    Friend WithEvents txtDensidadResultadoFB As System.Windows.Forms.TextBox
    Friend WithEvents btnDensidadFB As System.Windows.Forms.Button
    Friend WithEvents btnCapacidadPromFB As System.Windows.Forms.Button
    Friend WithEvents txtCapacidadPromFB As System.Windows.Forms.TextBox
    Friend WithEvents lblCapacidadPromFB As System.Windows.Forms.Label
    Friend WithEvents btnFrecuenciaFB As System.Windows.Forms.Button
    Friend WithEvents txtFrecuenciaFB As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecuenciaFB As System.Windows.Forms.Label
    Friend WithEvents btnAsientosPromFB As System.Windows.Forms.Button
    Friend WithEvents txtAsientosPromFB As System.Windows.Forms.TextBox
    Friend WithEvents lblAsientosPromFB As System.Windows.Forms.Label
    Friend WithEvents txtDemandaFB As System.Windows.Forms.TextBox
    Friend WithEvents lblDemandaFB As System.Windows.Forms.Label
End Class
