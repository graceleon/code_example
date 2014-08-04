<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntervalo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntervalo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpia = New System.Windows.Forms.Button()
        Me.lblIntervaloDef = New System.Windows.Forms.Label()
        Me.gpbIntervaloFB = New System.Windows.Forms.GroupBox()
        Me.txtFrecuenciaFB = New System.Windows.Forms.TextBox()
        Me.lblFrecuenciaFB = New System.Windows.Forms.Label()
        Me.btnIntervaloFB = New System.Windows.Forms.Button()
        Me.txtIntervaloResultadoFB = New System.Windows.Forms.TextBox()
        Me.txtIntervaloFB = New System.Windows.Forms.TextBox()
        Me.lblIntervaloLargoFB = New System.Windows.Forms.Label()
        Me.txtNbucleFB = New System.Windows.Forms.TextBox()
        Me.lblNbucleFB = New System.Windows.Forms.Label()
        Me.gpbIntervaloNormal = New System.Windows.Forms.GroupBox()
        Me.lblCalculaIntervaloBucle = New System.Windows.Forms.Label()
        Me.lblCalculaIntervaloLargo = New System.Windows.Forms.Label()
        Me.txtIntervaloLargo = New System.Windows.Forms.TextBox()
        Me.lblIntervaloLargo = New System.Windows.Forms.Label()
        Me.txtIntervaloBucle = New System.Windows.Forms.TextBox()
        Me.lblIntervaloBucle = New System.Windows.Forms.Label()
        Me.rbtnNoBucle = New System.Windows.Forms.RadioButton()
        Me.txtNumTrenes = New System.Windows.Forms.TextBox()
        Me.lblNumTrenes = New System.Windows.Forms.Label()
        Me.txtVueltaBucle = New System.Windows.Forms.TextBox()
        Me.txtVueltaLarga = New System.Windows.Forms.TextBox()
        Me.txtNbucle = New System.Windows.Forms.TextBox()
        Me.lblNbucle = New System.Windows.Forms.Label()
        Me.lblVueltaCortaI = New System.Windows.Forms.Label()
        Me.lblVueltaLargaI = New System.Windows.Forms.Label()
        Me.rbtnBucle = New System.Windows.Forms.RadioButton()
        Me.btnCalculaIntervalo = New System.Windows.Forms.Button()
        Me.txtIntervaloResultado = New System.Windows.Forms.TextBox()
        Me.txtFrecIntervalo = New System.Windows.Forms.TextBox()
        Me.lblFrecIntervalo = New System.Windows.Forms.Label()
        Me.btnIntervaloNormal = New System.Windows.Forms.Button()
        Me.txtIntervaloResultadoNormal = New System.Windows.Forms.TextBox()
        Me.lblLineas = New System.Windows.Forms.Label()
        Me.txtInyecciones = New System.Windows.Forms.TextBox()
        Me.lblInyecciones = New System.Windows.Forms.Label()
        Me.txtFrecuenciaIny = New System.Windows.Forms.TextBox()
        Me.lblFrecuencia = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gpbIntervaloFB.SuspendLayout()
        Me.gpbIntervaloNormal.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.488372!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.69435!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.651163!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpia, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblIntervaloDef, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbIntervaloFB, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbIntervaloNormal, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.079665!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.1195!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.157895!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.89474!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.421053!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(602, 477)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'btnLimpia
        '
        Me.btnLimpia.BackColor = System.Drawing.SystemColors.Window
        Me.btnLimpia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpia.Image = Global.CalculaGrace.My.Resources.Resources.Clear1
        Me.btnLimpia.Location = New System.Drawing.Point(576, 3)
        Me.btnLimpia.Name = "btnLimpia"
        Me.btnLimpia.Size = New System.Drawing.Size(23, 23)
        Me.btnLimpia.TabIndex = 69
        Me.btnLimpia.UseVisualStyleBackColor = False
        '
        'lblIntervaloDef
        '
        Me.lblIntervaloDef.AutoSize = True
        Me.lblIntervaloDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIntervaloDef.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntervaloDef.Location = New System.Drawing.Point(24, 0)
        Me.lblIntervaloDef.Name = "lblIntervaloDef"
        Me.lblIntervaloDef.Size = New System.Drawing.Size(546, 29)
        Me.lblIntervaloDef.TabIndex = 48
        Me.lblIntervaloDef.Text = "Intervalo: distancia en tiempo entre trenes consecutivos"
        Me.lblIntervaloDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpbIntervaloFB
        '
        Me.gpbIntervaloFB.Controls.Add(Me.txtFrecuenciaFB)
        Me.gpbIntervaloFB.Controls.Add(Me.lblFrecuenciaFB)
        Me.gpbIntervaloFB.Controls.Add(Me.btnIntervaloFB)
        Me.gpbIntervaloFB.Controls.Add(Me.txtIntervaloResultadoFB)
        Me.gpbIntervaloFB.Controls.Add(Me.txtIntervaloFB)
        Me.gpbIntervaloFB.Controls.Add(Me.lblIntervaloLargoFB)
        Me.gpbIntervaloFB.Controls.Add(Me.txtNbucleFB)
        Me.gpbIntervaloFB.Controls.Add(Me.lblNbucleFB)
        Me.gpbIntervaloFB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbIntervaloFB.Location = New System.Drawing.Point(23, 331)
        Me.gpbIntervaloFB.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.gpbIntervaloFB.Name = "gpbIntervaloFB"
        Me.gpbIntervaloFB.Padding = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.gpbIntervaloFB.Size = New System.Drawing.Size(548, 123)
        Me.gpbIntervaloFB.TabIndex = 1
        Me.gpbIntervaloFB.TabStop = False
        Me.gpbIntervaloFB.Text = "Intervalo Fuera de Bucle"
        '
        'txtFrecuenciaFB
        '
        Me.txtFrecuenciaFB.Location = New System.Drawing.Point(320, 39)
        Me.txtFrecuenciaFB.MaxLength = 10
        Me.txtFrecuenciaFB.Name = "txtFrecuenciaFB"
        Me.txtFrecuenciaFB.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecuenciaFB.TabIndex = 14
        Me.txtFrecuenciaFB.Text = "0"
        '
        'lblFrecuenciaFB
        '
        Me.lblFrecuenciaFB.AutoSize = True
        Me.lblFrecuenciaFB.Location = New System.Drawing.Point(243, 42)
        Me.lblFrecuenciaFB.Name = "lblFrecuenciaFB"
        Me.lblFrecuenciaFB.Size = New System.Drawing.Size(66, 16)
        Me.lblFrecuenciaFB.TabIndex = 50
        Me.lblFrecuenciaFB.Text = "Frecuencia"
        '
        'btnIntervaloFB
        '
        Me.btnIntervaloFB.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnIntervaloFB.Location = New System.Drawing.Point(451, 38)
        Me.btnIntervaloFB.Name = "btnIntervaloFB"
        Me.btnIntervaloFB.Size = New System.Drawing.Size(95, 35)
        Me.btnIntervaloFB.TabIndex = 15
        Me.btnIntervaloFB.Text = "Intervalo"
        Me.btnIntervaloFB.UseVisualStyleBackColor = False
        '
        'txtIntervaloResultadoFB
        '
        Me.txtIntervaloResultadoFB.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtIntervaloResultadoFB.Location = New System.Drawing.Point(451, 81)
        Me.txtIntervaloResultadoFB.MaxLength = 15
        Me.txtIntervaloResultadoFB.Name = "txtIntervaloResultadoFB"
        Me.txtIntervaloResultadoFB.ReadOnly = True
        Me.txtIntervaloResultadoFB.Size = New System.Drawing.Size(95, 24)
        Me.txtIntervaloResultadoFB.TabIndex = 48
        Me.txtIntervaloResultadoFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIntervaloFB
        '
        Me.txtIntervaloFB.Location = New System.Drawing.Point(108, 81)
        Me.txtIntervaloFB.MaxLength = 10
        Me.txtIntervaloFB.Name = "txtIntervaloFB"
        Me.txtIntervaloFB.Size = New System.Drawing.Size(100, 24)
        Me.txtIntervaloFB.TabIndex = 13
        Me.txtIntervaloFB.Text = "0"
        '
        'lblIntervaloLargoFB
        '
        Me.lblIntervaloLargoFB.AutoSize = True
        Me.lblIntervaloLargoFB.Location = New System.Drawing.Point(14, 85)
        Me.lblIntervaloLargoFB.Name = "lblIntervaloLargoFB"
        Me.lblIntervaloLargoFB.Size = New System.Drawing.Size(88, 16)
        Me.lblIntervaloLargoFB.TabIndex = 42
        Me.lblIntervaloLargoFB.Text = "Intervalo Largo"
        '
        'txtNbucleFB
        '
        Me.txtNbucleFB.Location = New System.Drawing.Point(108, 38)
        Me.txtNbucleFB.MaxLength = 10
        Me.txtNbucleFB.Name = "txtNbucleFB"
        Me.txtNbucleFB.Size = New System.Drawing.Size(100, 24)
        Me.txtNbucleFB.TabIndex = 12
        Me.txtNbucleFB.Text = "0"
        '
        'lblNbucleFB
        '
        Me.lblNbucleFB.AutoSize = True
        Me.lblNbucleFB.Location = New System.Drawing.Point(15, 42)
        Me.lblNbucleFB.Name = "lblNbucleFB"
        Me.lblNbucleFB.Size = New System.Drawing.Size(54, 16)
        Me.lblNbucleFB.TabIndex = 36
        Me.lblNbucleFB.Text = "N (bucle)"
        '
        'gpbIntervaloNormal
        '
        Me.gpbIntervaloNormal.Controls.Add(Me.lblCalculaIntervaloBucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblCalculaIntervaloLargo)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtIntervaloLargo)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblIntervaloLargo)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtIntervaloBucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblIntervaloBucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.rbtnNoBucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtNumTrenes)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblNumTrenes)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtVueltaBucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtVueltaLarga)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtNbucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblNbucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblVueltaCortaI)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblVueltaLargaI)
        Me.gpbIntervaloNormal.Controls.Add(Me.rbtnBucle)
        Me.gpbIntervaloNormal.Controls.Add(Me.btnCalculaIntervalo)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtIntervaloResultado)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtFrecIntervalo)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblFrecIntervalo)
        Me.gpbIntervaloNormal.Controls.Add(Me.btnIntervaloNormal)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtIntervaloResultadoNormal)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblLineas)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtInyecciones)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblInyecciones)
        Me.gpbIntervaloNormal.Controls.Add(Me.txtFrecuenciaIny)
        Me.gpbIntervaloNormal.Controls.Add(Me.lblFrecuencia)
        Me.gpbIntervaloNormal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbIntervaloNormal.Location = New System.Drawing.Point(23, 34)
        Me.gpbIntervaloNormal.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.gpbIntervaloNormal.Name = "gpbIntervaloNormal"
        Me.gpbIntervaloNormal.Padding = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.gpbIntervaloNormal.Size = New System.Drawing.Size(548, 272)
        Me.gpbIntervaloNormal.TabIndex = 0
        Me.gpbIntervaloNormal.TabStop = False
        Me.gpbIntervaloNormal.Text = "Intervalo Normal"
        '
        'lblCalculaIntervaloBucle
        '
        Me.lblCalculaIntervaloBucle.AutoSize = True
        Me.lblCalculaIntervaloBucle.Location = New System.Drawing.Point(406, 142)
        Me.lblCalculaIntervaloBucle.Name = "lblCalculaIntervaloBucle"
        Me.lblCalculaIntervaloBucle.Size = New System.Drawing.Size(77, 16)
        Me.lblCalculaIntervaloBucle.TabIndex = 68
        Me.lblCalculaIntervaloBucle.Text = "Interv. Bucle:"
        '
        'lblCalculaIntervaloLargo
        '
        Me.lblCalculaIntervaloLargo.AutoSize = True
        Me.lblCalculaIntervaloLargo.Location = New System.Drawing.Point(235, 142)
        Me.lblCalculaIntervaloLargo.Name = "lblCalculaIntervaloLargo"
        Me.lblCalculaIntervaloLargo.Size = New System.Drawing.Size(81, 16)
        Me.lblCalculaIntervaloLargo.TabIndex = 67
        Me.lblCalculaIntervaloLargo.Text = "Interv. Largo: "
        '
        'txtIntervaloLargo
        '
        Me.txtIntervaloLargo.Location = New System.Drawing.Point(320, 242)
        Me.txtIntervaloLargo.MaxLength = 10
        Me.txtIntervaloLargo.Name = "txtIntervaloLargo"
        Me.txtIntervaloLargo.Size = New System.Drawing.Size(100, 24)
        Me.txtIntervaloLargo.TabIndex = 10
        Me.txtIntervaloLargo.Text = "0"
        '
        'lblIntervaloLargo
        '
        Me.lblIntervaloLargo.AutoSize = True
        Me.lblIntervaloLargo.Location = New System.Drawing.Point(228, 245)
        Me.lblIntervaloLargo.Name = "lblIntervaloLargo"
        Me.lblIntervaloLargo.Size = New System.Drawing.Size(88, 16)
        Me.lblIntervaloLargo.TabIndex = 65
        Me.lblIntervaloLargo.Text = "Intervalo Largo"
        '
        'txtIntervaloBucle
        '
        Me.txtIntervaloBucle.Location = New System.Drawing.Point(320, 198)
        Me.txtIntervaloBucle.MaxLength = 10
        Me.txtIntervaloBucle.Name = "txtIntervaloBucle"
        Me.txtIntervaloBucle.Size = New System.Drawing.Size(100, 24)
        Me.txtIntervaloBucle.TabIndex = 9
        Me.txtIntervaloBucle.Text = "0"
        '
        'lblIntervaloBucle
        '
        Me.lblIntervaloBucle.AutoSize = True
        Me.lblIntervaloBucle.Location = New System.Drawing.Point(228, 201)
        Me.lblIntervaloBucle.Name = "lblIntervaloBucle"
        Me.lblIntervaloBucle.Size = New System.Drawing.Size(87, 16)
        Me.lblIntervaloBucle.TabIndex = 63
        Me.lblIntervaloBucle.Text = "Intervalo Bucle"
        '
        'rbtnNoBucle
        '
        Me.rbtnNoBucle.AutoSize = True
        Me.rbtnNoBucle.Location = New System.Drawing.Point(150, 25)
        Me.rbtnNoBucle.Name = "rbtnNoBucle"
        Me.rbtnNoBucle.Size = New System.Drawing.Size(102, 20)
        Me.rbtnNoBucle.TabIndex = 62
        Me.rbtnNoBucle.Text = "No tiene Bucle"
        Me.rbtnNoBucle.UseVisualStyleBackColor = True
        '
        'txtNumTrenes
        '
        Me.txtNumTrenes.Location = New System.Drawing.Point(320, 51)
        Me.txtNumTrenes.MaxLength = 10
        Me.txtNumTrenes.Name = "txtNumTrenes"
        Me.txtNumTrenes.Size = New System.Drawing.Size(100, 24)
        Me.txtNumTrenes.TabIndex = 2
        Me.txtNumTrenes.Text = "0"
        '
        'lblNumTrenes
        '
        Me.lblNumTrenes.AutoSize = True
        Me.lblNumTrenes.Location = New System.Drawing.Point(255, 54)
        Me.lblNumTrenes.Name = "lblNumTrenes"
        Me.lblNumTrenes.Size = New System.Drawing.Size(59, 16)
        Me.lblNumTrenes.TabIndex = 60
        Me.lblNumTrenes.Text = "Nº Trenes"
        '
        'txtVueltaBucle
        '
        Me.txtVueltaBucle.Location = New System.Drawing.Point(122, 139)
        Me.txtVueltaBucle.MaxLength = 10
        Me.txtVueltaBucle.Name = "txtVueltaBucle"
        Me.txtVueltaBucle.Size = New System.Drawing.Size(100, 24)
        Me.txtVueltaBucle.TabIndex = 4
        Me.txtVueltaBucle.Text = "0"
        '
        'txtVueltaLarga
        '
        Me.txtVueltaLarga.Location = New System.Drawing.Point(122, 99)
        Me.txtVueltaLarga.MaxLength = 10
        Me.txtVueltaLarga.Name = "txtVueltaLarga"
        Me.txtVueltaLarga.Size = New System.Drawing.Size(100, 24)
        Me.txtVueltaLarga.TabIndex = 3
        Me.txtVueltaLarga.Text = "0"
        '
        'txtNbucle
        '
        Me.txtNbucle.Location = New System.Drawing.Point(320, 99)
        Me.txtNbucle.MaxLength = 10
        Me.txtNbucle.Name = "txtNbucle"
        Me.txtNbucle.Size = New System.Drawing.Size(100, 24)
        Me.txtNbucle.TabIndex = 5
        Me.txtNbucle.Text = "0"
        '
        'lblNbucle
        '
        Me.lblNbucle.AutoSize = True
        Me.lblNbucle.Location = New System.Drawing.Point(255, 102)
        Me.lblNbucle.Name = "lblNbucle"
        Me.lblNbucle.Size = New System.Drawing.Size(54, 16)
        Me.lblNbucle.TabIndex = 56
        Me.lblNbucle.Text = "N (bucle)"
        '
        'lblVueltaCortaI
        '
        Me.lblVueltaCortaI.AutoSize = True
        Me.lblVueltaCortaI.Location = New System.Drawing.Point(17, 142)
        Me.lblVueltaCortaI.Name = "lblVueltaCortaI"
        Me.lblVueltaCortaI.Size = New System.Drawing.Size(103, 16)
        Me.lblVueltaCortaI.TabIndex = 55
        Me.lblVueltaCortaI.Text = "Vuelta Bucle (seg)"
        '
        'lblVueltaLargaI
        '
        Me.lblVueltaLargaI.AutoSize = True
        Me.lblVueltaLargaI.Location = New System.Drawing.Point(17, 102)
        Me.lblVueltaLargaI.Name = "lblVueltaLargaI"
        Me.lblVueltaLargaI.Size = New System.Drawing.Size(105, 16)
        Me.lblVueltaLargaI.TabIndex = 54
        Me.lblVueltaLargaI.Text = "Vuelta Larga (seg)"
        '
        'rbtnBucle
        '
        Me.rbtnBucle.AutoSize = True
        Me.rbtnBucle.Checked = True
        Me.rbtnBucle.Location = New System.Drawing.Point(21, 25)
        Me.rbtnBucle.Name = "rbtnBucle"
        Me.rbtnBucle.Size = New System.Drawing.Size(85, 20)
        Me.rbtnBucle.TabIndex = 53
        Me.rbtnBucle.TabStop = True
        Me.rbtnBucle.Text = "Tiene Bucle"
        Me.rbtnBucle.UseVisualStyleBackColor = True
        '
        'btnCalculaIntervalo
        '
        Me.btnCalculaIntervalo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCalculaIntervalo.Location = New System.Drawing.Point(446, 51)
        Me.btnCalculaIntervalo.Name = "btnCalculaIntervalo"
        Me.btnCalculaIntervalo.Size = New System.Drawing.Size(95, 35)
        Me.btnCalculaIntervalo.TabIndex = 6
        Me.btnCalculaIntervalo.Text = "Intervalo"
        Me.btnCalculaIntervalo.UseVisualStyleBackColor = False
        '
        'txtIntervaloResultado
        '
        Me.txtIntervaloResultado.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtIntervaloResultado.Location = New System.Drawing.Point(446, 99)
        Me.txtIntervaloResultado.MaxLength = 15
        Me.txtIntervaloResultado.Name = "txtIntervaloResultado"
        Me.txtIntervaloResultado.ReadOnly = True
        Me.txtIntervaloResultado.Size = New System.Drawing.Size(95, 24)
        Me.txtIntervaloResultado.TabIndex = 52
        Me.txtIntervaloResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFrecIntervalo
        '
        Me.txtFrecIntervalo.Location = New System.Drawing.Point(122, 56)
        Me.txtFrecIntervalo.MaxLength = 10
        Me.txtFrecIntervalo.Name = "txtFrecIntervalo"
        Me.txtFrecIntervalo.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecIntervalo.TabIndex = 1
        Me.txtFrecIntervalo.Text = "0"
        '
        'lblFrecIntervalo
        '
        Me.lblFrecIntervalo.AutoSize = True
        Me.lblFrecIntervalo.Location = New System.Drawing.Point(17, 59)
        Me.lblFrecIntervalo.Name = "lblFrecIntervalo"
        Me.lblFrecIntervalo.Size = New System.Drawing.Size(66, 16)
        Me.lblFrecIntervalo.TabIndex = 48
        Me.lblFrecIntervalo.Text = "Frecuencia"
        '
        'btnIntervaloNormal
        '
        Me.btnIntervaloNormal.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnIntervaloNormal.Location = New System.Drawing.Point(446, 192)
        Me.btnIntervaloNormal.Name = "btnIntervaloNormal"
        Me.btnIntervaloNormal.Size = New System.Drawing.Size(95, 35)
        Me.btnIntervaloNormal.TabIndex = 11
        Me.btnIntervaloNormal.Text = "Intervalo"
        Me.btnIntervaloNormal.UseVisualStyleBackColor = False
        '
        'txtIntervaloResultadoNormal
        '
        Me.txtIntervaloResultadoNormal.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtIntervaloResultadoNormal.Location = New System.Drawing.Point(446, 242)
        Me.txtIntervaloResultadoNormal.MaxLength = 15
        Me.txtIntervaloResultadoNormal.Name = "txtIntervaloResultadoNormal"
        Me.txtIntervaloResultadoNormal.ReadOnly = True
        Me.txtIntervaloResultadoNormal.Size = New System.Drawing.Size(95, 24)
        Me.txtIntervaloResultadoNormal.TabIndex = 46
        Me.txtIntervaloResultadoNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLineas
        '
        Me.lblLineas.AutoSize = True
        Me.lblLineas.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineas.ForeColor = System.Drawing.Color.Blue
        Me.lblLineas.Location = New System.Drawing.Point(8, 173)
        Me.lblLineas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineas.Name = "lblLineas"
        Me.lblLineas.Size = New System.Drawing.Size(533, 16)
        Me.lblLineas.TabIndex = 44
        Me.lblLineas.Text = "---------------------------------------------------------------------------------" & _
            "------------------------"
        Me.lblLineas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInyecciones
        '
        Me.txtInyecciones.Location = New System.Drawing.Point(122, 198)
        Me.txtInyecciones.MaxLength = 10
        Me.txtInyecciones.Name = "txtInyecciones"
        Me.txtInyecciones.Size = New System.Drawing.Size(100, 24)
        Me.txtInyecciones.TabIndex = 7
        Me.txtInyecciones.Text = "0"
        '
        'lblInyecciones
        '
        Me.lblInyecciones.AutoSize = True
        Me.lblInyecciones.Location = New System.Drawing.Point(18, 201)
        Me.lblInyecciones.Name = "lblInyecciones"
        Me.lblInyecciones.Size = New System.Drawing.Size(68, 16)
        Me.lblInyecciones.TabIndex = 42
        Me.lblInyecciones.Text = "Inyecciones"
        '
        'txtFrecuenciaIny
        '
        Me.txtFrecuenciaIny.Location = New System.Drawing.Point(122, 242)
        Me.txtFrecuenciaIny.MaxLength = 10
        Me.txtFrecuenciaIny.Name = "txtFrecuenciaIny"
        Me.txtFrecuenciaIny.Size = New System.Drawing.Size(100, 24)
        Me.txtFrecuenciaIny.TabIndex = 8
        Me.txtFrecuenciaIny.Text = "0"
        '
        'lblFrecuencia
        '
        Me.lblFrecuencia.AutoSize = True
        Me.lblFrecuencia.Location = New System.Drawing.Point(17, 245)
        Me.lblFrecuencia.Name = "lblFrecuencia"
        Me.lblFrecuencia.Size = New System.Drawing.Size(66, 16)
        Me.lblFrecuencia.TabIndex = 40
        Me.lblFrecuencia.Text = "Frecuencia"
        '
        'frmIntervalo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 477)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIntervalo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intervalo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gpbIntervaloFB.ResumeLayout(False)
        Me.gpbIntervaloFB.PerformLayout()
        Me.gpbIntervaloNormal.ResumeLayout(False)
        Me.gpbIntervaloNormal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gpbIntervaloFB As System.Windows.Forms.GroupBox
    Friend WithEvents btnIntervaloFB As System.Windows.Forms.Button
    Friend WithEvents txtIntervaloResultadoFB As System.Windows.Forms.TextBox
    Friend WithEvents txtIntervaloFB As System.Windows.Forms.TextBox
    Friend WithEvents lblIntervaloLargoFB As System.Windows.Forms.Label
    Friend WithEvents txtNbucleFB As System.Windows.Forms.TextBox
    Friend WithEvents lblNbucleFB As System.Windows.Forms.Label
    Friend WithEvents gpbIntervaloNormal As System.Windows.Forms.GroupBox
    Friend WithEvents btnIntervaloNormal As System.Windows.Forms.Button
    Friend WithEvents txtIntervaloResultadoNormal As System.Windows.Forms.TextBox
    Friend WithEvents lblLineas As System.Windows.Forms.Label
    Friend WithEvents txtInyecciones As System.Windows.Forms.TextBox
    Friend WithEvents lblInyecciones As System.Windows.Forms.Label
    Friend WithEvents txtFrecuenciaIny As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecuencia As System.Windows.Forms.Label
    Friend WithEvents lblIntervaloDef As System.Windows.Forms.Label
    Friend WithEvents rbtnNoBucle As System.Windows.Forms.RadioButton
    Friend WithEvents txtNumTrenes As System.Windows.Forms.TextBox
    Friend WithEvents lblNumTrenes As System.Windows.Forms.Label
    Friend WithEvents txtVueltaBucle As System.Windows.Forms.TextBox
    Friend WithEvents txtVueltaLarga As System.Windows.Forms.TextBox
    Friend WithEvents txtNbucle As System.Windows.Forms.TextBox
    Friend WithEvents lblNbucle As System.Windows.Forms.Label
    Friend WithEvents lblVueltaCortaI As System.Windows.Forms.Label
    Friend WithEvents lblVueltaLargaI As System.Windows.Forms.Label
    Friend WithEvents rbtnBucle As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculaIntervalo As System.Windows.Forms.Button
    Friend WithEvents txtIntervaloResultado As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecIntervalo As System.Windows.Forms.Label
    Friend WithEvents txtIntervaloBucle As System.Windows.Forms.TextBox
    Friend WithEvents lblIntervaloBucle As System.Windows.Forms.Label
    Friend WithEvents txtIntervaloLargo As System.Windows.Forms.TextBox
    Friend WithEvents lblIntervaloLargo As System.Windows.Forms.Label
    Friend WithEvents lblCalculaIntervaloBucle As System.Windows.Forms.Label
    Friend WithEvents lblCalculaIntervaloLargo As System.Windows.Forms.Label
    Friend WithEvents btnLimpia As System.Windows.Forms.Button
    Friend WithEvents txtFrecuenciaFB As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecuenciaFB As System.Windows.Forms.Label
End Class
