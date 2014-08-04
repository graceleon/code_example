<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrenes))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gpbTrenes = New System.Windows.Forms.GroupBox()
        Me.lblAsientosPromedio = New System.Windows.Forms.Label()
        Me.lblTrenesCirculando = New System.Windows.Forms.Label()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.lblCapacidadPromedio = New System.Windows.Forms.Label()
        Me.txtTrenesInyeccion = New System.Windows.Forms.NumericUpDown()
        Me.lblTotalTrenes = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblPaxTotal = New System.Windows.Forms.Label()
        Me.txtTrenesReserva = New System.Windows.Forms.NumericUpDown()
        Me.txt6AsientosAS02 = New System.Windows.Forms.NumericUpDown()
        Me.txt3AsientosAS02 = New System.Windows.Forms.NumericUpDown()
        Me.txt6CapAS02 = New System.Windows.Forms.NumericUpDown()
        Me.txt8AsientosNS04 = New System.Windows.Forms.NumericUpDown()
        Me.txt7AsientosNS04 = New System.Windows.Forms.NumericUpDown()
        Me.txt8CapNS04 = New System.Windows.Forms.NumericUpDown()
        Me.txt7CapNS04 = New System.Windows.Forms.NumericUpDown()
        Me.txt8CochesNS04 = New System.Windows.Forms.NumericUpDown()
        Me.txt3CapAS02 = New System.Windows.Forms.NumericUpDown()
        Me.txt6CochesAS02 = New System.Windows.Forms.NumericUpDown()
        Me.txt3CochesAS02 = New System.Windows.Forms.NumericUpDown()
        Me.txt9AsientosNS07 = New System.Windows.Forms.NumericUpDown()
        Me.txt9CapNS07 = New System.Windows.Forms.NumericUpDown()
        Me.txt9CochesNS07 = New System.Windows.Forms.NumericUpDown()
        Me.txt7CochesNS04 = New System.Windows.Forms.NumericUpDown()
        Me.txt8AsientosNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt7AsientosNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt6AsientosNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt8CapNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt8CochesNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt7CapNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt7CochesNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt6CochesNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt7AsientosNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt6AsientosNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt6CapNS93 = New System.Windows.Forms.NumericUpDown()
        Me.txt5CochesNS74 = New System.Windows.Forms.NumericUpDown()
        Me.lblTrenesInyeccion = New System.Windows.Forms.Label()
        Me.btnCalcula = New System.Windows.Forms.Button()
        Me.txt5AsientosNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt7CapNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt6CapNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt5CapNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt7CochesNS74 = New System.Windows.Forms.NumericUpDown()
        Me.txt6CochesNS74 = New System.Windows.Forms.NumericUpDown()
        Me.lblTrenesReserva = New System.Windows.Forms.Label()
        Me.lblconfigCoches02 = New System.Windows.Forms.Label()
        Me.lblconfigCoches07 = New System.Windows.Forms.Label()
        Me.lblconfigCoches04 = New System.Windows.Forms.Label()
        Me.lblconfigCoches93 = New System.Windows.Forms.Label()
        Me.lblconfigCoches74 = New System.Windows.Forms.Label()
        Me.lblAsientos = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblCoches = New System.Windows.Forms.Label()
        Me.lblTipoTren = New System.Windows.Forms.Label()
        Me.txtAS02 = New System.Windows.Forms.TextBox()
        Me.lblAS02 = New System.Windows.Forms.Label()
        Me.txtNS07 = New System.Windows.Forms.TextBox()
        Me.lblNS07 = New System.Windows.Forms.Label()
        Me.txtNS04 = New System.Windows.Forms.TextBox()
        Me.lblNS04 = New System.Windows.Forms.Label()
        Me.txtNS93 = New System.Windows.Forms.TextBox()
        Me.lblNS93 = New System.Windows.Forms.Label()
        Me.txtNS74 = New System.Windows.Forms.TextBox()
        Me.lblNS74 = New System.Windows.Forms.Label()
        Me.gpbTrenesBucle = New System.Windows.Forms.GroupBox()
        Me.txtTrenesBucles = New System.Windows.Forms.TextBox()
        Me.btnTrenesBucle = New System.Windows.Forms.Button()
        Me.txtVueltaBucle = New System.Windows.Forms.TextBox()
        Me.txtNbucle = New System.Windows.Forms.TextBox()
        Me.txtVueltaLarga = New System.Windows.Forms.TextBox()
        Me.txtNumeroTrenes = New System.Windows.Forms.TextBox()
        Me.lblNbucle = New System.Windows.Forms.Label()
        Me.lblVueltaBucle = New System.Windows.Forms.Label()
        Me.lblVueltaLarga = New System.Windows.Forms.Label()
        Me.lblNumeroTrenes = New System.Windows.Forms.Label()
        Me.gpbTrenesLargos = New System.Windows.Forms.GroupBox()
        Me.txtNumeroTrenesBucle = New System.Windows.Forms.TextBox()
        Me.lblTrenesBucle = New System.Windows.Forms.Label()
        Me.txtNumeroTrenesL = New System.Windows.Forms.TextBox()
        Me.lblNumeroTrenesL = New System.Windows.Forms.Label()
        Me.txtTrenesLargos = New System.Windows.Forms.TextBox()
        Me.btnTrenesLargos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gpbTrenes.SuspendLayout()
        CType(Me.txtTrenesInyeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrenesReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6AsientosAS02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3AsientosAS02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6CapAS02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8AsientosNS04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7AsientosNS04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8CapNS04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7CapNS04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8CochesNS04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3CapAS02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6CochesAS02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3CochesAS02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt9AsientosNS07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt9CapNS07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt9CochesNS07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7CochesNS04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8AsientosNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7AsientosNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6AsientosNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8CapNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8CochesNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7CapNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7CochesNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6CochesNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7AsientosNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6AsientosNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6CapNS93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5CochesNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5AsientosNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7CapNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6CapNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5CapNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7CochesNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6CochesNS74, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbTrenesBucle.SuspendLayout()
        Me.gpbTrenesLargos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.655173!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.68965!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.655172!))
        Me.TableLayoutPanel1.Controls.Add(Me.gpbTrenes, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbTrenesBucle, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.gpbTrenesLargos, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.371951!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0685!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43836!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.26712!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(726, 637)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'gpbTrenes
        '
        Me.gpbTrenes.Controls.Add(Me.lblAsientosPromedio)
        Me.gpbTrenes.Controls.Add(Me.lblTrenesCirculando)
        Me.gpbTrenes.Controls.Add(Me.btnRestablecer)
        Me.gpbTrenes.Controls.Add(Me.lblCapacidadPromedio)
        Me.gpbTrenes.Controls.Add(Me.txtTrenesInyeccion)
        Me.gpbTrenes.Controls.Add(Me.lblTotalTrenes)
        Me.gpbTrenes.Controls.Add(Me.btnLimpiar)
        Me.gpbTrenes.Controls.Add(Me.lblPaxTotal)
        Me.gpbTrenes.Controls.Add(Me.txtTrenesReserva)
        Me.gpbTrenes.Controls.Add(Me.txt6AsientosAS02)
        Me.gpbTrenes.Controls.Add(Me.txt3AsientosAS02)
        Me.gpbTrenes.Controls.Add(Me.txt6CapAS02)
        Me.gpbTrenes.Controls.Add(Me.txt8AsientosNS04)
        Me.gpbTrenes.Controls.Add(Me.txt7AsientosNS04)
        Me.gpbTrenes.Controls.Add(Me.txt8CapNS04)
        Me.gpbTrenes.Controls.Add(Me.txt7CapNS04)
        Me.gpbTrenes.Controls.Add(Me.txt8CochesNS04)
        Me.gpbTrenes.Controls.Add(Me.txt3CapAS02)
        Me.gpbTrenes.Controls.Add(Me.txt6CochesAS02)
        Me.gpbTrenes.Controls.Add(Me.txt3CochesAS02)
        Me.gpbTrenes.Controls.Add(Me.txt9AsientosNS07)
        Me.gpbTrenes.Controls.Add(Me.txt9CapNS07)
        Me.gpbTrenes.Controls.Add(Me.txt9CochesNS07)
        Me.gpbTrenes.Controls.Add(Me.txt7CochesNS04)
        Me.gpbTrenes.Controls.Add(Me.txt8AsientosNS93)
        Me.gpbTrenes.Controls.Add(Me.txt7AsientosNS93)
        Me.gpbTrenes.Controls.Add(Me.txt6AsientosNS93)
        Me.gpbTrenes.Controls.Add(Me.txt8CapNS93)
        Me.gpbTrenes.Controls.Add(Me.txt8CochesNS93)
        Me.gpbTrenes.Controls.Add(Me.txt7CapNS93)
        Me.gpbTrenes.Controls.Add(Me.txt7CochesNS93)
        Me.gpbTrenes.Controls.Add(Me.txt6CochesNS93)
        Me.gpbTrenes.Controls.Add(Me.txt7AsientosNS74)
        Me.gpbTrenes.Controls.Add(Me.txt6AsientosNS74)
        Me.gpbTrenes.Controls.Add(Me.txt6CapNS93)
        Me.gpbTrenes.Controls.Add(Me.txt5CochesNS74)
        Me.gpbTrenes.Controls.Add(Me.lblTrenesInyeccion)
        Me.gpbTrenes.Controls.Add(Me.btnCalcula)
        Me.gpbTrenes.Controls.Add(Me.txt5AsientosNS74)
        Me.gpbTrenes.Controls.Add(Me.txt7CapNS74)
        Me.gpbTrenes.Controls.Add(Me.txt6CapNS74)
        Me.gpbTrenes.Controls.Add(Me.txt5CapNS74)
        Me.gpbTrenes.Controls.Add(Me.txt7CochesNS74)
        Me.gpbTrenes.Controls.Add(Me.txt6CochesNS74)
        Me.gpbTrenes.Controls.Add(Me.lblTrenesReserva)
        Me.gpbTrenes.Controls.Add(Me.lblconfigCoches02)
        Me.gpbTrenes.Controls.Add(Me.lblconfigCoches07)
        Me.gpbTrenes.Controls.Add(Me.lblconfigCoches04)
        Me.gpbTrenes.Controls.Add(Me.lblconfigCoches93)
        Me.gpbTrenes.Controls.Add(Me.lblconfigCoches74)
        Me.gpbTrenes.Controls.Add(Me.lblAsientos)
        Me.gpbTrenes.Controls.Add(Me.lblCapacidad)
        Me.gpbTrenes.Controls.Add(Me.lblCantidad)
        Me.gpbTrenes.Controls.Add(Me.lblCoches)
        Me.gpbTrenes.Controls.Add(Me.lblTipoTren)
        Me.gpbTrenes.Controls.Add(Me.txtAS02)
        Me.gpbTrenes.Controls.Add(Me.lblAS02)
        Me.gpbTrenes.Controls.Add(Me.txtNS07)
        Me.gpbTrenes.Controls.Add(Me.lblNS07)
        Me.gpbTrenes.Controls.Add(Me.txtNS04)
        Me.gpbTrenes.Controls.Add(Me.lblNS04)
        Me.gpbTrenes.Controls.Add(Me.txtNS93)
        Me.gpbTrenes.Controls.Add(Me.lblNS93)
        Me.gpbTrenes.Controls.Add(Me.txtNS74)
        Me.gpbTrenes.Controls.Add(Me.lblNS74)
        Me.gpbTrenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbTrenes.Location = New System.Drawing.Point(15, 11)
        Me.gpbTrenes.Name = "gpbTrenes"
        Me.gpbTrenes.Size = New System.Drawing.Size(695, 402)
        Me.gpbTrenes.TabIndex = 49
        Me.gpbTrenes.TabStop = False
        Me.gpbTrenes.Text = "Datos de los Trenes"
        '
        'lblAsientosPromedio
        '
        Me.lblAsientosPromedio.AutoSize = True
        Me.lblAsientosPromedio.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsientosPromedio.Location = New System.Drawing.Point(268, 349)
        Me.lblAsientosPromedio.Name = "lblAsientosPromedio"
        Me.lblAsientosPromedio.Size = New System.Drawing.Size(110, 16)
        Me.lblAsientosPromedio.TabIndex = 161
        Me.lblAsientosPromedio.Text = "Asientos Promedio:"
        '
        'lblTrenesCirculando
        '
        Me.lblTrenesCirculando.AutoSize = True
        Me.lblTrenesCirculando.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrenesCirculando.Location = New System.Drawing.Point(14, 374)
        Me.lblTrenesCirculando.Name = "lblTrenesCirculando"
        Me.lblTrenesCirculando.Size = New System.Drawing.Size(105, 16)
        Me.lblTrenesCirculando.TabIndex = 118
        Me.lblTrenesCirculando.Text = "Trenes Circulando:"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Location = New System.Drawing.Point(603, 371)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(86, 23)
        Me.btnRestablecer.TabIndex = 38
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'lblCapacidadPromedio
        '
        Me.lblCapacidadPromedio.AutoSize = True
        Me.lblCapacidadPromedio.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacidadPromedio.Location = New System.Drawing.Point(258, 324)
        Me.lblCapacidadPromedio.Name = "lblCapacidadPromedio"
        Me.lblCapacidadPromedio.Size = New System.Drawing.Size(120, 16)
        Me.lblCapacidadPromedio.TabIndex = 117
        Me.lblCapacidadPromedio.Text = "Capacidad Promedio:"
        '
        'txtTrenesInyeccion
        '
        Me.txtTrenesInyeccion.Location = New System.Drawing.Point(318, 286)
        Me.txtTrenesInyeccion.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtTrenesInyeccion.Name = "txtTrenesInyeccion"
        Me.txtTrenesInyeccion.Size = New System.Drawing.Size(58, 24)
        Me.txtTrenesInyeccion.TabIndex = 35
        '
        'lblTotalTrenes
        '
        Me.lblTotalTrenes.AutoSize = True
        Me.lblTotalTrenes.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTrenes.Location = New System.Drawing.Point(42, 349)
        Me.lblTotalTrenes.Name = "lblTotalTrenes"
        Me.lblTotalTrenes.Size = New System.Drawing.Size(77, 16)
        Me.lblTotalTrenes.TabIndex = 116
        Me.lblTotalTrenes.Text = "Total Trenes:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Window
        Me.btnLimpiar.Image = Global.CalculaGrace.My.Resources.Resources.Clear1
        Me.btnLimpiar.Location = New System.Drawing.Point(662, 13)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(27, 23)
        Me.btnLimpiar.TabIndex = 37
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lblPaxTotal
        '
        Me.lblPaxTotal.AutoSize = True
        Me.lblPaxTotal.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaxTotal.Location = New System.Drawing.Point(24, 324)
        Me.lblPaxTotal.Name = "lblPaxTotal"
        Me.lblPaxTotal.Size = New System.Drawing.Size(95, 16)
        Me.lblPaxTotal.TabIndex = 115
        Me.lblPaxTotal.Text = "Total Pasajeros:"
        '
        'txtTrenesReserva
        '
        Me.txtTrenesReserva.Location = New System.Drawing.Point(115, 285)
        Me.txtTrenesReserva.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtTrenesReserva.Name = "txtTrenesReserva"
        Me.txtTrenesReserva.Size = New System.Drawing.Size(57, 24)
        Me.txtTrenesReserva.TabIndex = 34
        '
        'txt6AsientosAS02
        '
        Me.txt6AsientosAS02.Location = New System.Drawing.Point(555, 241)
        Me.txt6AsientosAS02.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt6AsientosAS02.Name = "txt6AsientosAS02"
        Me.txt6AsientosAS02.Size = New System.Drawing.Size(45, 24)
        Me.txt6AsientosAS02.TabIndex = 33
        Me.txt6AsientosAS02.Value = New Decimal(New Integer() {276, 0, 0, 0})
        '
        'txt3AsientosAS02
        '
        Me.txt3AsientosAS02.Location = New System.Drawing.Point(504, 241)
        Me.txt3AsientosAS02.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt3AsientosAS02.Name = "txt3AsientosAS02"
        Me.txt3AsientosAS02.Size = New System.Drawing.Size(45, 24)
        Me.txt3AsientosAS02.TabIndex = 32
        Me.txt3AsientosAS02.Value = New Decimal(New Integer() {138, 0, 0, 0})
        '
        'txt6CapAS02
        '
        Me.txt6CapAS02.Location = New System.Drawing.Point(379, 240)
        Me.txt6CapAS02.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt6CapAS02.Name = "txt6CapAS02"
        Me.txt6CapAS02.Size = New System.Drawing.Size(49, 24)
        Me.txt6CapAS02.TabIndex = 22
        Me.txt6CapAS02.Value = New Decimal(New Integer() {1595, 0, 0, 0})
        '
        'txt8AsientosNS04
        '
        Me.txt8AsientosNS04.Location = New System.Drawing.Point(555, 149)
        Me.txt8AsientosNS04.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt8AsientosNS04.Name = "txt8AsientosNS04"
        Me.txt8AsientosNS04.Size = New System.Drawing.Size(45, 24)
        Me.txt8AsientosNS04.TabIndex = 30
        Me.txt8AsientosNS04.Value = New Decimal(New Integer() {188, 0, 0, 0})
        '
        'txt7AsientosNS04
        '
        Me.txt7AsientosNS04.Location = New System.Drawing.Point(504, 148)
        Me.txt7AsientosNS04.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt7AsientosNS04.Name = "txt7AsientosNS04"
        Me.txt7AsientosNS04.Size = New System.Drawing.Size(45, 24)
        Me.txt7AsientosNS04.TabIndex = 29
        Me.txt7AsientosNS04.Value = New Decimal(New Integer() {164, 0, 0, 0})
        '
        'txt8CapNS04
        '
        Me.txt8CapNS04.Location = New System.Drawing.Point(379, 148)
        Me.txt8CapNS04.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt8CapNS04.Name = "txt8CapNS04"
        Me.txt8CapNS04.Size = New System.Drawing.Size(45, 24)
        Me.txt8CapNS04.TabIndex = 19
        Me.txt8CapNS04.Value = New Decimal(New Integer() {1447, 0, 0, 0})
        '
        'txt7CapNS04
        '
        Me.txt7CapNS04.Location = New System.Drawing.Point(327, 148)
        Me.txt7CapNS04.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt7CapNS04.Name = "txt7CapNS04"
        Me.txt7CapNS04.Size = New System.Drawing.Size(46, 24)
        Me.txt7CapNS04.TabIndex = 18
        Me.txt7CapNS04.Value = New Decimal(New Integer() {1261, 0, 0, 0})
        '
        'txt8CochesNS04
        '
        Me.txt8CochesNS04.Location = New System.Drawing.Point(216, 148)
        Me.txt8CochesNS04.Name = "txt8CochesNS04"
        Me.txt8CochesNS04.Size = New System.Drawing.Size(39, 24)
        Me.txt8CochesNS04.TabIndex = 8
        Me.txt8CochesNS04.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'txt3CapAS02
        '
        Me.txt3CapAS02.Location = New System.Drawing.Point(327, 240)
        Me.txt3CapAS02.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt3CapAS02.Name = "txt3CapAS02"
        Me.txt3CapAS02.Size = New System.Drawing.Size(46, 24)
        Me.txt3CapAS02.TabIndex = 21
        Me.txt3CapAS02.Value = New Decimal(New Integer() {798, 0, 0, 0})
        '
        'txt6CochesAS02
        '
        Me.txt6CochesAS02.Location = New System.Drawing.Point(216, 240)
        Me.txt6CochesAS02.Name = "txt6CochesAS02"
        Me.txt6CochesAS02.Size = New System.Drawing.Size(39, 24)
        Me.txt6CochesAS02.TabIndex = 11
        Me.txt6CochesAS02.Value = New Decimal(New Integer() {33, 0, 0, 0})
        '
        'txt3CochesAS02
        '
        Me.txt3CochesAS02.Location = New System.Drawing.Point(171, 240)
        Me.txt3CochesAS02.Name = "txt3CochesAS02"
        Me.txt3CochesAS02.Size = New System.Drawing.Size(39, 24)
        Me.txt3CochesAS02.TabIndex = 10
        Me.txt3CochesAS02.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'txt9AsientosNS07
        '
        Me.txt9AsientosNS07.Location = New System.Drawing.Point(504, 192)
        Me.txt9AsientosNS07.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt9AsientosNS07.Name = "txt9AsientosNS07"
        Me.txt9AsientosNS07.Size = New System.Drawing.Size(45, 24)
        Me.txt9AsientosNS07.TabIndex = 31
        Me.txt9AsientosNS07.Value = New Decimal(New Integer() {224, 0, 0, 0})
        '
        'txt9CapNS07
        '
        Me.txt9CapNS07.Location = New System.Drawing.Point(327, 192)
        Me.txt9CapNS07.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt9CapNS07.Name = "txt9CapNS07"
        Me.txt9CapNS07.Size = New System.Drawing.Size(46, 24)
        Me.txt9CapNS07.TabIndex = 20
        Me.txt9CapNS07.Value = New Decimal(New Integer() {1534, 0, 0, 0})
        '
        'txt9CochesNS07
        '
        Me.txt9CochesNS07.Location = New System.Drawing.Point(171, 192)
        Me.txt9CochesNS07.Name = "txt9CochesNS07"
        Me.txt9CochesNS07.Size = New System.Drawing.Size(39, 24)
        Me.txt9CochesNS07.TabIndex = 9
        Me.txt9CochesNS07.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'txt7CochesNS04
        '
        Me.txt7CochesNS04.Location = New System.Drawing.Point(171, 148)
        Me.txt7CochesNS04.Name = "txt7CochesNS04"
        Me.txt7CochesNS04.Size = New System.Drawing.Size(39, 24)
        Me.txt7CochesNS04.TabIndex = 7
        Me.txt7CochesNS04.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'txt8AsientosNS93
        '
        Me.txt8AsientosNS93.Location = New System.Drawing.Point(606, 103)
        Me.txt8AsientosNS93.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt8AsientosNS93.Name = "txt8AsientosNS93"
        Me.txt8AsientosNS93.Size = New System.Drawing.Size(45, 24)
        Me.txt8AsientosNS93.TabIndex = 28
        Me.txt8AsientosNS93.Value = New Decimal(New Integer() {143, 0, 0, 0})
        '
        'txt7AsientosNS93
        '
        Me.txt7AsientosNS93.Location = New System.Drawing.Point(555, 103)
        Me.txt7AsientosNS93.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt7AsientosNS93.Name = "txt7AsientosNS93"
        Me.txt7AsientosNS93.Size = New System.Drawing.Size(45, 24)
        Me.txt7AsientosNS93.TabIndex = 27
        Me.txt7AsientosNS93.Value = New Decimal(New Integer() {123, 0, 0, 0})
        '
        'txt6AsientosNS93
        '
        Me.txt6AsientosNS93.Location = New System.Drawing.Point(504, 103)
        Me.txt6AsientosNS93.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt6AsientosNS93.Name = "txt6AsientosNS93"
        Me.txt6AsientosNS93.Size = New System.Drawing.Size(45, 24)
        Me.txt6AsientosNS93.TabIndex = 26
        Me.txt6AsientosNS93.Value = New Decimal(New Integer() {111, 0, 0, 0})
        '
        'txt8CapNS93
        '
        Me.txt8CapNS93.Location = New System.Drawing.Point(430, 101)
        Me.txt8CapNS93.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt8CapNS93.Name = "txt8CapNS93"
        Me.txt8CapNS93.Size = New System.Drawing.Size(54, 24)
        Me.txt8CapNS93.TabIndex = 17
        Me.txt8CapNS93.Value = New Decimal(New Integer() {1272, 0, 0, 0})
        '
        'txt8CochesNS93
        '
        Me.txt8CochesNS93.Location = New System.Drawing.Point(261, 100)
        Me.txt8CochesNS93.Name = "txt8CochesNS93"
        Me.txt8CochesNS93.Size = New System.Drawing.Size(39, 24)
        Me.txt8CochesNS93.TabIndex = 6
        Me.txt8CochesNS93.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'txt7CapNS93
        '
        Me.txt7CapNS93.Location = New System.Drawing.Point(379, 101)
        Me.txt7CapNS93.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt7CapNS93.Name = "txt7CapNS93"
        Me.txt7CapNS93.Size = New System.Drawing.Size(45, 24)
        Me.txt7CapNS93.TabIndex = 16
        Me.txt7CapNS93.Value = New Decimal(New Integer() {1112, 0, 0, 0})
        '
        'txt7CochesNS93
        '
        Me.txt7CochesNS93.Location = New System.Drawing.Point(216, 100)
        Me.txt7CochesNS93.Name = "txt7CochesNS93"
        Me.txt7CochesNS93.Size = New System.Drawing.Size(39, 24)
        Me.txt7CochesNS93.TabIndex = 5
        Me.txt7CochesNS93.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'txt6CochesNS93
        '
        Me.txt6CochesNS93.Location = New System.Drawing.Point(171, 100)
        Me.txt6CochesNS93.Name = "txt6CochesNS93"
        Me.txt6CochesNS93.Size = New System.Drawing.Size(39, 24)
        Me.txt6CochesNS93.TabIndex = 4
        Me.txt6CochesNS93.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'txt7AsientosNS74
        '
        Me.txt7AsientosNS74.Location = New System.Drawing.Point(606, 57)
        Me.txt7AsientosNS74.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt7AsientosNS74.Name = "txt7AsientosNS74"
        Me.txt7AsientosNS74.Size = New System.Drawing.Size(45, 24)
        Me.txt7AsientosNS74.TabIndex = 25
        Me.txt7AsientosNS74.Value = New Decimal(New Integer() {199, 0, 0, 0})
        '
        'txt6AsientosNS74
        '
        Me.txt6AsientosNS74.Location = New System.Drawing.Point(555, 57)
        Me.txt6AsientosNS74.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt6AsientosNS74.Name = "txt6AsientosNS74"
        Me.txt6AsientosNS74.Size = New System.Drawing.Size(45, 24)
        Me.txt6AsientosNS74.TabIndex = 24
        Me.txt6AsientosNS74.Value = New Decimal(New Integer() {179, 0, 0, 0})
        '
        'txt6CapNS93
        '
        Me.txt6CapNS93.Location = New System.Drawing.Point(327, 101)
        Me.txt6CapNS93.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt6CapNS93.Name = "txt6CapNS93"
        Me.txt6CapNS93.Size = New System.Drawing.Size(46, 24)
        Me.txt6CapNS93.TabIndex = 15
        Me.txt6CapNS93.Value = New Decimal(New Integer() {943, 0, 0, 0})
        '
        'txt5CochesNS74
        '
        Me.txt5CochesNS74.Location = New System.Drawing.Point(171, 57)
        Me.txt5CochesNS74.Name = "txt5CochesNS74"
        Me.txt5CochesNS74.Size = New System.Drawing.Size(39, 24)
        Me.txt5CochesNS74.TabIndex = 1
        Me.txt5CochesNS74.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblTrenesInyeccion
        '
        Me.lblTrenesInyeccion.AutoSize = True
        Me.lblTrenesInyeccion.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrenesInyeccion.Location = New System.Drawing.Point(190, 289)
        Me.lblTrenesInyeccion.Name = "lblTrenesInyeccion"
        Me.lblTrenesInyeccion.Size = New System.Drawing.Size(110, 16)
        Me.lblTrenesInyeccion.TabIndex = 137
        Me.lblTrenesInyeccion.Text = "Trenes Inyección"
        '
        'btnCalcula
        '
        Me.btnCalcula.BackColor = System.Drawing.Color.Yellow
        Me.btnCalcula.Location = New System.Drawing.Point(532, 287)
        Me.btnCalcula.Name = "btnCalcula"
        Me.btnCalcula.Size = New System.Drawing.Size(157, 23)
        Me.btnCalcula.TabIndex = 36
        Me.btnCalcula.Text = "Calcular Valores"
        Me.btnCalcula.UseVisualStyleBackColor = False
        '
        'txt5AsientosNS74
        '
        Me.txt5AsientosNS74.Location = New System.Drawing.Point(504, 57)
        Me.txt5AsientosNS74.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt5AsientosNS74.Name = "txt5AsientosNS74"
        Me.txt5AsientosNS74.Size = New System.Drawing.Size(45, 24)
        Me.txt5AsientosNS74.TabIndex = 23
        Me.txt5AsientosNS74.Value = New Decimal(New Integer() {124, 0, 0, 0})
        '
        'txt7CapNS74
        '
        Me.txt7CapNS74.Location = New System.Drawing.Point(430, 57)
        Me.txt7CapNS74.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt7CapNS74.Name = "txt7CapNS74"
        Me.txt7CapNS74.Size = New System.Drawing.Size(54, 24)
        Me.txt7CapNS74.TabIndex = 14
        Me.txt7CapNS74.Value = New Decimal(New Integer() {1302, 0, 0, 0})
        '
        'txt6CapNS74
        '
        Me.txt6CapNS74.Location = New System.Drawing.Point(379, 57)
        Me.txt6CapNS74.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt6CapNS74.Name = "txt6CapNS74"
        Me.txt6CapNS74.Size = New System.Drawing.Size(45, 24)
        Me.txt6CapNS74.TabIndex = 13
        Me.txt6CapNS74.Value = New Decimal(New Integer() {1132, 0, 0, 0})
        '
        'txt5CapNS74
        '
        Me.txt5CapNS74.Location = New System.Drawing.Point(327, 57)
        Me.txt5CapNS74.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt5CapNS74.Name = "txt5CapNS74"
        Me.txt5CapNS74.Size = New System.Drawing.Size(45, 24)
        Me.txt5CapNS74.TabIndex = 12
        Me.txt5CapNS74.Value = New Decimal(New Integer() {932, 0, 0, 0})
        '
        'txt7CochesNS74
        '
        Me.txt7CochesNS74.Location = New System.Drawing.Point(261, 57)
        Me.txt7CochesNS74.Name = "txt7CochesNS74"
        Me.txt7CochesNS74.Size = New System.Drawing.Size(39, 24)
        Me.txt7CochesNS74.TabIndex = 3
        '
        'txt6CochesNS74
        '
        Me.txt6CochesNS74.Location = New System.Drawing.Point(216, 57)
        Me.txt6CochesNS74.Name = "txt6CochesNS74"
        Me.txt6CochesNS74.Size = New System.Drawing.Size(39, 24)
        Me.txt6CochesNS74.TabIndex = 2
        '
        'lblTrenesReserva
        '
        Me.lblTrenesReserva.AutoSize = True
        Me.lblTrenesReserva.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrenesReserva.Location = New System.Drawing.Point(6, 289)
        Me.lblTrenesReserva.Name = "lblTrenesReserva"
        Me.lblTrenesReserva.Size = New System.Drawing.Size(103, 16)
        Me.lblTrenesReserva.TabIndex = 134
        Me.lblTrenesReserva.Text = "Trenes Reserva"
        '
        'lblconfigCoches02
        '
        Me.lblconfigCoches02.AutoSize = True
        Me.lblconfigCoches02.Font = New System.Drawing.Font("Taffy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfigCoches02.Location = New System.Drawing.Point(187, 222)
        Me.lblconfigCoches02.Name = "lblconfigCoches02"
        Me.lblconfigCoches02.Size = New System.Drawing.Size(84, 13)
        Me.lblconfigCoches02.TabIndex = 133
        Me.lblconfigCoches02.Text = "3          6          -"
        '
        'lblconfigCoches07
        '
        Me.lblconfigCoches07.AutoSize = True
        Me.lblconfigCoches07.Font = New System.Drawing.Font("Taffy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfigCoches07.Location = New System.Drawing.Point(187, 175)
        Me.lblconfigCoches07.Name = "lblconfigCoches07"
        Me.lblconfigCoches07.Size = New System.Drawing.Size(85, 13)
        Me.lblconfigCoches07.TabIndex = 132
        Me.lblconfigCoches07.Text = "9          -           -"
        '
        'lblconfigCoches04
        '
        Me.lblconfigCoches04.AutoSize = True
        Me.lblconfigCoches04.Font = New System.Drawing.Font("Taffy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfigCoches04.Location = New System.Drawing.Point(187, 132)
        Me.lblconfigCoches04.Name = "lblconfigCoches04"
        Me.lblconfigCoches04.Size = New System.Drawing.Size(83, 13)
        Me.lblconfigCoches04.TabIndex = 131
        Me.lblconfigCoches04.Text = "7          8          -"
        '
        'lblconfigCoches93
        '
        Me.lblconfigCoches93.AutoSize = True
        Me.lblconfigCoches93.Font = New System.Drawing.Font("Taffy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfigCoches93.Location = New System.Drawing.Point(187, 84)
        Me.lblconfigCoches93.Name = "lblconfigCoches93"
        Me.lblconfigCoches93.Size = New System.Drawing.Size(83, 13)
        Me.lblconfigCoches93.TabIndex = 128
        Me.lblconfigCoches93.Text = "6          7         8"
        '
        'lblconfigCoches74
        '
        Me.lblconfigCoches74.AutoSize = True
        Me.lblconfigCoches74.Font = New System.Drawing.Font("Taffy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfigCoches74.Location = New System.Drawing.Point(187, 36)
        Me.lblconfigCoches74.Name = "lblconfigCoches74"
        Me.lblconfigCoches74.Size = New System.Drawing.Size(82, 13)
        Me.lblconfigCoches74.TabIndex = 125
        Me.lblconfigCoches74.Text = "5          6         7"
        '
        'lblAsientos
        '
        Me.lblAsientos.AutoSize = True
        Me.lblAsientos.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsientos.Location = New System.Drawing.Point(552, 28)
        Me.lblAsientos.Name = "lblAsientos"
        Me.lblAsientos.Size = New System.Drawing.Size(63, 16)
        Me.lblAsientos.TabIndex = 120
        Me.lblAsientos.Text = "Asientos"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.AutoSize = True
        Me.lblCapacidad.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacidad.Location = New System.Drawing.Point(354, 28)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(74, 16)
        Me.lblCapacidad.TabIndex = 119
        Me.lblCapacidad.Text = "Capacidad"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(83, 28)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 16)
        Me.lblCantidad.TabIndex = 118
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblCoches
        '
        Me.lblCoches.AutoSize = True
        Me.lblCoches.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoches.Location = New System.Drawing.Point(187, 20)
        Me.lblCoches.Name = "lblCoches"
        Me.lblCoches.Size = New System.Drawing.Size(106, 16)
        Me.lblCoches.TabIndex = 117
        Me.lblCoches.Text = "Trenes x Coches"
        '
        'lblTipoTren
        '
        Me.lblTipoTren.AutoSize = True
        Me.lblTipoTren.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTren.Location = New System.Drawing.Point(6, 28)
        Me.lblTipoTren.Name = "lblTipoTren"
        Me.lblTipoTren.Size = New System.Drawing.Size(64, 16)
        Me.lblTipoTren.TabIndex = 116
        Me.lblTipoTren.Text = "Tipo Tren"
        '
        'txtAS02
        '
        Me.txtAS02.Location = New System.Drawing.Point(86, 240)
        Me.txtAS02.MaxLength = 3
        Me.txtAS02.Name = "txtAS02"
        Me.txtAS02.ReadOnly = True
        Me.txtAS02.Size = New System.Drawing.Size(55, 24)
        Me.txtAS02.TabIndex = 5
        Me.txtAS02.Text = "0"
        Me.txtAS02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAS02
        '
        Me.lblAS02.AutoSize = True
        Me.lblAS02.Location = New System.Drawing.Point(6, 243)
        Me.lblAS02.Name = "lblAS02"
        Me.lblAS02.Size = New System.Drawing.Size(60, 16)
        Me.lblAS02.TabIndex = 83
        Me.lblAS02.Text = "Nº AS-02"
        '
        'txtNS07
        '
        Me.txtNS07.Location = New System.Drawing.Point(86, 191)
        Me.txtNS07.MaxLength = 3
        Me.txtNS07.Name = "txtNS07"
        Me.txtNS07.ReadOnly = True
        Me.txtNS07.Size = New System.Drawing.Size(55, 24)
        Me.txtNS07.TabIndex = 4
        Me.txtNS07.Text = "0"
        Me.txtNS07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNS07
        '
        Me.lblNS07.AutoSize = True
        Me.lblNS07.Location = New System.Drawing.Point(6, 194)
        Me.lblNS07.Name = "lblNS07"
        Me.lblNS07.Size = New System.Drawing.Size(59, 16)
        Me.lblNS07.TabIndex = 81
        Me.lblNS07.Text = "Nº NS-07"
        '
        'txtNS04
        '
        Me.txtNS04.Location = New System.Drawing.Point(86, 148)
        Me.txtNS04.MaxLength = 3
        Me.txtNS04.Name = "txtNS04"
        Me.txtNS04.ReadOnly = True
        Me.txtNS04.Size = New System.Drawing.Size(55, 24)
        Me.txtNS04.TabIndex = 3
        Me.txtNS04.Text = "0"
        Me.txtNS04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNS04
        '
        Me.lblNS04.AutoSize = True
        Me.lblNS04.Location = New System.Drawing.Point(6, 151)
        Me.lblNS04.Name = "lblNS04"
        Me.lblNS04.Size = New System.Drawing.Size(60, 16)
        Me.lblNS04.TabIndex = 79
        Me.lblNS04.Text = "Nº NS-04"
        '
        'txtNS93
        '
        Me.txtNS93.Location = New System.Drawing.Point(86, 100)
        Me.txtNS93.MaxLength = 3
        Me.txtNS93.Name = "txtNS93"
        Me.txtNS93.ReadOnly = True
        Me.txtNS93.Size = New System.Drawing.Size(55, 24)
        Me.txtNS93.TabIndex = 2
        Me.txtNS93.Text = "0"
        Me.txtNS93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNS93
        '
        Me.lblNS93.AutoSize = True
        Me.lblNS93.Location = New System.Drawing.Point(5, 105)
        Me.lblNS93.Name = "lblNS93"
        Me.lblNS93.Size = New System.Drawing.Size(61, 16)
        Me.lblNS93.TabIndex = 77
        Me.lblNS93.Text = "Nº NS-93"
        '
        'txtNS74
        '
        Me.txtNS74.Location = New System.Drawing.Point(86, 57)
        Me.txtNS74.MaxLength = 3
        Me.txtNS74.Name = "txtNS74"
        Me.txtNS74.ReadOnly = True
        Me.txtNS74.Size = New System.Drawing.Size(55, 24)
        Me.txtNS74.TabIndex = 1
        Me.txtNS74.Text = "0"
        Me.txtNS74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNS74
        '
        Me.lblNS74.AutoSize = True
        Me.lblNS74.Location = New System.Drawing.Point(6, 60)
        Me.lblNS74.Name = "lblNS74"
        Me.lblNS74.Size = New System.Drawing.Size(58, 16)
        Me.lblNS74.TabIndex = 75
        Me.lblNS74.Text = "Nº NS-74"
        '
        'gpbTrenesBucle
        '
        Me.gpbTrenesBucle.Controls.Add(Me.txtTrenesBucles)
        Me.gpbTrenesBucle.Controls.Add(Me.btnTrenesBucle)
        Me.gpbTrenesBucle.Controls.Add(Me.txtVueltaBucle)
        Me.gpbTrenesBucle.Controls.Add(Me.txtNbucle)
        Me.gpbTrenesBucle.Controls.Add(Me.txtVueltaLarga)
        Me.gpbTrenesBucle.Controls.Add(Me.txtNumeroTrenes)
        Me.gpbTrenesBucle.Controls.Add(Me.lblNbucle)
        Me.gpbTrenesBucle.Controls.Add(Me.lblVueltaBucle)
        Me.gpbTrenesBucle.Controls.Add(Me.lblVueltaLarga)
        Me.gpbTrenesBucle.Controls.Add(Me.lblNumeroTrenes)
        Me.gpbTrenesBucle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbTrenesBucle.Location = New System.Drawing.Point(15, 425)
        Me.gpbTrenesBucle.Name = "gpbTrenesBucle"
        Me.gpbTrenesBucle.Size = New System.Drawing.Size(695, 97)
        Me.gpbTrenesBucle.TabIndex = 50
        Me.gpbTrenesBucle.TabStop = False
        Me.gpbTrenesBucle.Text = "Nº de Trenes Bucle"
        '
        'txtTrenesBucles
        '
        Me.txtTrenesBucles.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrenesBucles.Location = New System.Drawing.Point(555, 53)
        Me.txtTrenesBucles.MaxLength = 15
        Me.txtTrenesBucles.Name = "txtTrenesBucles"
        Me.txtTrenesBucles.ReadOnly = True
        Me.txtTrenesBucles.Size = New System.Drawing.Size(95, 24)
        Me.txtTrenesBucles.TabIndex = 48
        Me.txtTrenesBucles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTrenesBucle
        '
        Me.btnTrenesBucle.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnTrenesBucle.ForeColor = System.Drawing.Color.White
        Me.btnTrenesBucle.Location = New System.Drawing.Point(555, 20)
        Me.btnTrenesBucle.Name = "btnTrenesBucle"
        Me.btnTrenesBucle.Size = New System.Drawing.Size(95, 29)
        Me.btnTrenesBucle.TabIndex = 43
        Me.btnTrenesBucle.Text = "Trenes Bucle"
        Me.btnTrenesBucle.UseVisualStyleBackColor = False
        '
        'txtVueltaBucle
        '
        Me.txtVueltaBucle.Location = New System.Drawing.Point(118, 53)
        Me.txtVueltaBucle.MaxLength = 10
        Me.txtVueltaBucle.Name = "txtVueltaBucle"
        Me.txtVueltaBucle.Size = New System.Drawing.Size(100, 24)
        Me.txtVueltaBucle.TabIndex = 40
        Me.txtVueltaBucle.Text = "0"
        '
        'txtNbucle
        '
        Me.txtNbucle.Location = New System.Drawing.Point(379, 23)
        Me.txtNbucle.MaxLength = 10
        Me.txtNbucle.Name = "txtNbucle"
        Me.txtNbucle.Size = New System.Drawing.Size(100, 24)
        Me.txtNbucle.TabIndex = 41
        Me.txtNbucle.Text = "0"
        '
        'txtVueltaLarga
        '
        Me.txtVueltaLarga.Location = New System.Drawing.Point(379, 56)
        Me.txtVueltaLarga.MaxLength = 10
        Me.txtVueltaLarga.Name = "txtVueltaLarga"
        Me.txtVueltaLarga.Size = New System.Drawing.Size(100, 24)
        Me.txtVueltaLarga.TabIndex = 42
        Me.txtVueltaLarga.Text = "0"
        '
        'txtNumeroTrenes
        '
        Me.txtNumeroTrenes.Location = New System.Drawing.Point(118, 23)
        Me.txtNumeroTrenes.MaxLength = 10
        Me.txtNumeroTrenes.Name = "txtNumeroTrenes"
        Me.txtNumeroTrenes.Size = New System.Drawing.Size(100, 24)
        Me.txtNumeroTrenes.TabIndex = 39
        Me.txtNumeroTrenes.Text = "0"
        '
        'lblNbucle
        '
        Me.lblNbucle.AutoSize = True
        Me.lblNbucle.Location = New System.Drawing.Point(275, 26)
        Me.lblNbucle.Name = "lblNbucle"
        Me.lblNbucle.Size = New System.Drawing.Size(54, 16)
        Me.lblNbucle.TabIndex = 47
        Me.lblNbucle.Text = "N (bucle)"
        '
        'lblVueltaBucle
        '
        Me.lblVueltaBucle.AutoSize = True
        Me.lblVueltaBucle.Location = New System.Drawing.Point(14, 56)
        Me.lblVueltaBucle.Name = "lblVueltaBucle"
        Me.lblVueltaBucle.Size = New System.Drawing.Size(96, 16)
        Me.lblVueltaBucle.TabIndex = 46
        Me.lblVueltaBucle.Text = "Vuelta Bucle (hr)"
        '
        'lblVueltaLarga
        '
        Me.lblVueltaLarga.AutoSize = True
        Me.lblVueltaLarga.Location = New System.Drawing.Point(275, 59)
        Me.lblVueltaLarga.Name = "lblVueltaLarga"
        Me.lblVueltaLarga.Size = New System.Drawing.Size(98, 16)
        Me.lblVueltaLarga.TabIndex = 45
        Me.lblVueltaLarga.Text = "Vuelta Larga (hr)"
        '
        'lblNumeroTrenes
        '
        Me.lblNumeroTrenes.AutoSize = True
        Me.lblNumeroTrenes.Location = New System.Drawing.Point(14, 26)
        Me.lblNumeroTrenes.Name = "lblNumeroTrenes"
        Me.lblNumeroTrenes.Size = New System.Drawing.Size(59, 16)
        Me.lblNumeroTrenes.TabIndex = 44
        Me.lblNumeroTrenes.Text = "Nº Trenes"
        '
        'gpbTrenesLargos
        '
        Me.gpbTrenesLargos.Controls.Add(Me.txtNumeroTrenesBucle)
        Me.gpbTrenesLargos.Controls.Add(Me.lblTrenesBucle)
        Me.gpbTrenesLargos.Controls.Add(Me.txtNumeroTrenesL)
        Me.gpbTrenesLargos.Controls.Add(Me.lblNumeroTrenesL)
        Me.gpbTrenesLargos.Controls.Add(Me.txtTrenesLargos)
        Me.gpbTrenesLargos.Controls.Add(Me.btnTrenesLargos)
        Me.gpbTrenesLargos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbTrenesLargos.Location = New System.Drawing.Point(15, 528)
        Me.gpbTrenesLargos.Name = "gpbTrenesLargos"
        Me.gpbTrenesLargos.Size = New System.Drawing.Size(695, 96)
        Me.gpbTrenesLargos.TabIndex = 51
        Me.gpbTrenesLargos.TabStop = False
        Me.gpbTrenesLargos.Text = "Nº de Trenes Largos"
        '
        'txtNumeroTrenesBucle
        '
        Me.txtNumeroTrenesBucle.Location = New System.Drawing.Point(381, 40)
        Me.txtNumeroTrenesBucle.MaxLength = 10
        Me.txtNumeroTrenesBucle.Name = "txtNumeroTrenesBucle"
        Me.txtNumeroTrenesBucle.Size = New System.Drawing.Size(100, 24)
        Me.txtNumeroTrenesBucle.TabIndex = 45
        Me.txtNumeroTrenesBucle.Text = "0"
        '
        'lblTrenesBucle
        '
        Me.lblTrenesBucle.AutoSize = True
        Me.lblTrenesBucle.Location = New System.Drawing.Point(277, 43)
        Me.lblTrenesBucle.Name = "lblTrenesBucle"
        Me.lblTrenesBucle.Size = New System.Drawing.Size(91, 16)
        Me.lblTrenesBucle.TabIndex = 54
        Me.lblTrenesBucle.Text = "Nº Trenes Bucle"
        '
        'txtNumeroTrenesL
        '
        Me.txtNumeroTrenesL.Location = New System.Drawing.Point(115, 40)
        Me.txtNumeroTrenesL.MaxLength = 10
        Me.txtNumeroTrenesL.Name = "txtNumeroTrenesL"
        Me.txtNumeroTrenesL.Size = New System.Drawing.Size(100, 24)
        Me.txtNumeroTrenesL.TabIndex = 44
        Me.txtNumeroTrenesL.Text = "0"
        '
        'lblNumeroTrenesL
        '
        Me.lblNumeroTrenesL.AutoSize = True
        Me.lblNumeroTrenesL.Location = New System.Drawing.Point(11, 43)
        Me.lblNumeroTrenesL.Name = "lblNumeroTrenesL"
        Me.lblNumeroTrenesL.Size = New System.Drawing.Size(59, 16)
        Me.lblNumeroTrenesL.TabIndex = 52
        Me.lblNumeroTrenesL.Text = "Nº Trenes"
        '
        'txtTrenesLargos
        '
        Me.txtTrenesLargos.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrenesLargos.Location = New System.Drawing.Point(555, 58)
        Me.txtTrenesLargos.MaxLength = 15
        Me.txtTrenesLargos.Name = "txtTrenesLargos"
        Me.txtTrenesLargos.ReadOnly = True
        Me.txtTrenesLargos.Size = New System.Drawing.Size(100, 24)
        Me.txtTrenesLargos.TabIndex = 50
        Me.txtTrenesLargos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTrenesLargos
        '
        Me.btnTrenesLargos.BackColor = System.Drawing.Color.DarkCyan
        Me.btnTrenesLargos.ForeColor = System.Drawing.Color.White
        Me.btnTrenesLargos.Location = New System.Drawing.Point(555, 23)
        Me.btnTrenesLargos.Name = "btnTrenesLargos"
        Me.btnTrenesLargos.Size = New System.Drawing.Size(95, 29)
        Me.btnTrenesLargos.TabIndex = 46
        Me.btnTrenesLargos.Text = "Trenes Largos"
        Me.btnTrenesLargos.UseVisualStyleBackColor = False
        '
        'frmTrenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 637)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Taffy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trenes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gpbTrenes.ResumeLayout(False)
        Me.gpbTrenes.PerformLayout()
        CType(Me.txtTrenesInyeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrenesReserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6AsientosAS02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3AsientosAS02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6CapAS02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8AsientosNS04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7AsientosNS04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8CapNS04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7CapNS04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8CochesNS04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3CapAS02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6CochesAS02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3CochesAS02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt9AsientosNS07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt9CapNS07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt9CochesNS07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7CochesNS04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8AsientosNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7AsientosNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6AsientosNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8CapNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8CochesNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7CapNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7CochesNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6CochesNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7AsientosNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6AsientosNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6CapNS93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5CochesNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5AsientosNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7CapNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6CapNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5CapNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7CochesNS74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6CochesNS74, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbTrenesBucle.ResumeLayout(False)
        Me.gpbTrenesBucle.PerformLayout()
        Me.gpbTrenesLargos.ResumeLayout(False)
        Me.gpbTrenesLargos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents gpbTrenes As System.Windows.Forms.GroupBox
    Friend WithEvents lblAsientos As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblCoches As System.Windows.Forms.Label
    Friend WithEvents lblTipoTren As System.Windows.Forms.Label
    Friend WithEvents lblPaxTotal As System.Windows.Forms.Label
    Friend WithEvents txtAS02 As System.Windows.Forms.TextBox
    Friend WithEvents lblAS02 As System.Windows.Forms.Label
    Friend WithEvents txtNS07 As System.Windows.Forms.TextBox
    Friend WithEvents lblNS07 As System.Windows.Forms.Label
    Friend WithEvents txtNS04 As System.Windows.Forms.TextBox
    Friend WithEvents lblNS04 As System.Windows.Forms.Label
    Friend WithEvents txtNS93 As System.Windows.Forms.TextBox
    Friend WithEvents lblNS93 As System.Windows.Forms.Label
    Friend WithEvents txtNS74 As System.Windows.Forms.TextBox
    Friend WithEvents lblNS74 As System.Windows.Forms.Label
    Friend WithEvents lblconfigCoches74 As System.Windows.Forms.Label
    Friend WithEvents gpbTrenesBucle As System.Windows.Forms.GroupBox
    Friend WithEvents lblconfigCoches93 As System.Windows.Forms.Label
    Friend WithEvents lblconfigCoches02 As System.Windows.Forms.Label
    Friend WithEvents lblconfigCoches07 As System.Windows.Forms.Label
    Friend WithEvents lblconfigCoches04 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTrenes As System.Windows.Forms.Label
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents lblTrenesReserva As System.Windows.Forms.Label
    Friend WithEvents lblCapacidadPromedio As System.Windows.Forms.Label
    Friend WithEvents btnCalcula As System.Windows.Forms.Button
    Friend WithEvents lblTrenesCirculando As System.Windows.Forms.Label
    Friend WithEvents lblTrenesInyeccion As System.Windows.Forms.Label
    Friend WithEvents txtTrenesInyeccion As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTrenesReserva As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6AsientosAS02 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt3AsientosAS02 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6CapAS02 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt8AsientosNS04 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7AsientosNS04 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt8CapNS04 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7CapNS04 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt8CochesNS04 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt3CapAS02 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6CochesAS02 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt3CochesAS02 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt9AsientosNS07 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt9CapNS07 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt9CochesNS07 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7CochesNS04 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt8AsientosNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7AsientosNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6AsientosNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt8CapNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt8CochesNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7CapNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7CochesNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6CochesNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7AsientosNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6AsientosNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6CapNS93 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt5CochesNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt5AsientosNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7CapNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6CapNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt5CapNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt7CochesNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt6CochesNS74 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTrenesBucles As System.Windows.Forms.TextBox
    Friend WithEvents btnTrenesBucle As System.Windows.Forms.Button
    Friend WithEvents txtVueltaBucle As System.Windows.Forms.TextBox
    Friend WithEvents txtNbucle As System.Windows.Forms.TextBox
    Friend WithEvents txtVueltaLarga As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroTrenes As System.Windows.Forms.TextBox
    Friend WithEvents lblNbucle As System.Windows.Forms.Label
    Friend WithEvents lblVueltaBucle As System.Windows.Forms.Label
    Friend WithEvents lblVueltaLarga As System.Windows.Forms.Label
    Friend WithEvents lblNumeroTrenes As System.Windows.Forms.Label
    Friend WithEvents txtTrenesLargos As System.Windows.Forms.TextBox
    Friend WithEvents btnTrenesLargos As System.Windows.Forms.Button
    Friend WithEvents gpbTrenesLargos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroTrenesBucle As System.Windows.Forms.TextBox
    Friend WithEvents lblTrenesBucle As System.Windows.Forms.Label
    Friend WithEvents txtNumeroTrenesL As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroTrenesL As System.Windows.Forms.Label
    Friend WithEvents lblAsientosPromedio As System.Windows.Forms.Label
End Class
