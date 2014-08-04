<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStripInicio = New System.Windows.Forms.MenuStrip()
        Me.FrecuenciaTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrecNormalTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrecFueraBucleTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervaloTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervaloNormalTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.InterFueraBucleTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfertaTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfertaNormalTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfertaFueraBucleTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DensidadTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DensidadNormalTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DensidadFueraBucleTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrenesTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosTrenesTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrenesLargosTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrenesBucleTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemandaTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DmdaRealTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DmdaProyectadaTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversoresTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversorUnidadesTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversorDecimalesTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStripInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStripInicio, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(640, 346)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MenuStripInicio
        '
        Me.MenuStripInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStripInicio.Font = New System.Drawing.Font("Taffy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripInicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrecuenciaTSMI, Me.IntervaloTSMI, Me.OfertaTSMI, Me.DensidadTSMI, Me.TrenesTSMI, Me.DemandaTSMI, Me.ConversoresTSMI})
        Me.MenuStripInicio.Location = New System.Drawing.Point(0, 55)
        Me.MenuStripInicio.Name = "MenuStripInicio"
        Me.MenuStripInicio.Size = New System.Drawing.Size(640, 31)
        Me.MenuStripInicio.TabIndex = 2
        Me.MenuStripInicio.Text = "MenuStrip1"
        '
        'FrecuenciaTSMI
        '
        Me.FrecuenciaTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrecNormalTSMI, Me.FrecFueraBucleTSMI})
        Me.FrecuenciaTSMI.Name = "FrecuenciaTSMI"
        Me.FrecuenciaTSMI.Size = New System.Drawing.Size(90, 27)
        Me.FrecuenciaTSMI.Text = "Frecuencia"
        '
        'FrecNormalTSMI
        '
        Me.FrecNormalTSMI.Name = "FrecNormalTSMI"
        Me.FrecNormalTSMI.Size = New System.Drawing.Size(194, 24)
        Me.FrecNormalTSMI.Text = "Frec Normal"
        '
        'FrecFueraBucleTSMI
        '
        Me.FrecFueraBucleTSMI.Name = "FrecFueraBucleTSMI"
        Me.FrecFueraBucleTSMI.Size = New System.Drawing.Size(194, 24)
        Me.FrecFueraBucleTSMI.Text = "Frec Fuera Bucle"
        '
        'IntervaloTSMI
        '
        Me.IntervaloTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntervaloNormalTSMI, Me.InterFueraBucleTSMI})
        Me.IntervaloTSMI.Name = "IntervaloTSMI"
        Me.IntervaloTSMI.Size = New System.Drawing.Size(78, 27)
        Me.IntervaloTSMI.Text = "Intervalo"
        '
        'IntervaloNormalTSMI
        '
        Me.IntervaloNormalTSMI.Name = "IntervaloNormalTSMI"
        Me.IntervaloNormalTSMI.Size = New System.Drawing.Size(201, 24)
        Me.IntervaloNormalTSMI.Text = "Intervalo Normal"
        '
        'InterFueraBucleTSMI
        '
        Me.InterFueraBucleTSMI.Name = "InterFueraBucleTSMI"
        Me.InterFueraBucleTSMI.Size = New System.Drawing.Size(201, 24)
        Me.InterFueraBucleTSMI.Text = "Inter. Fuera Bucle"
        '
        'OfertaTSMI
        '
        Me.OfertaTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OfertaNormalTSMI, Me.OfertaFueraBucleTSMI})
        Me.OfertaTSMI.Name = "OfertaTSMI"
        Me.OfertaTSMI.Size = New System.Drawing.Size(64, 27)
        Me.OfertaTSMI.Text = "Oferta"
        '
        'OfertaNormalTSMI
        '
        Me.OfertaNormalTSMI.Name = "OfertaNormalTSMI"
        Me.OfertaNormalTSMI.Size = New System.Drawing.Size(209, 24)
        Me.OfertaNormalTSMI.Text = "Oferta Normal"
        '
        'OfertaFueraBucleTSMI
        '
        Me.OfertaFueraBucleTSMI.Name = "OfertaFueraBucleTSMI"
        Me.OfertaFueraBucleTSMI.Size = New System.Drawing.Size(209, 24)
        Me.OfertaFueraBucleTSMI.Text = "Oferta Fuera Bucle"
        '
        'DensidadTSMI
        '
        Me.DensidadTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DensidadNormalTSMI, Me.DensidadFueraBucleTSMI})
        Me.DensidadTSMI.Name = "DensidadTSMI"
        Me.DensidadTSMI.Size = New System.Drawing.Size(81, 27)
        Me.DensidadTSMI.Text = "Densidad"
        '
        'DensidadNormalTSMI
        '
        Me.DensidadNormalTSMI.Name = "DensidadNormalTSMI"
        Me.DensidadNormalTSMI.Size = New System.Drawing.Size(226, 24)
        Me.DensidadNormalTSMI.Text = "Densidad Normal"
        '
        'DensidadFueraBucleTSMI
        '
        Me.DensidadFueraBucleTSMI.Name = "DensidadFueraBucleTSMI"
        Me.DensidadFueraBucleTSMI.Size = New System.Drawing.Size(226, 24)
        Me.DensidadFueraBucleTSMI.Text = "Densidad Fuera Bucle"
        '
        'TrenesTSMI
        '
        Me.TrenesTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosTrenesTSMI, Me.TrenesLargosTSMI, Me.TrenesBucleTSMI})
        Me.TrenesTSMI.Name = "TrenesTSMI"
        Me.TrenesTSMI.Size = New System.Drawing.Size(64, 27)
        Me.TrenesTSMI.Text = "Trenes"
        '
        'DatosTrenesTSMI
        '
        Me.DatosTrenesTSMI.Name = "DatosTrenesTSMI"
        Me.DatosTrenesTSMI.Size = New System.Drawing.Size(178, 24)
        Me.DatosTrenesTSMI.Text = "Datos Trenes"
        '
        'TrenesLargosTSMI
        '
        Me.TrenesLargosTSMI.Name = "TrenesLargosTSMI"
        Me.TrenesLargosTSMI.Size = New System.Drawing.Size(178, 24)
        Me.TrenesLargosTSMI.Text = "Trenes Largos"
        '
        'TrenesBucleTSMI
        '
        Me.TrenesBucleTSMI.Name = "TrenesBucleTSMI"
        Me.TrenesBucleTSMI.Size = New System.Drawing.Size(178, 24)
        Me.TrenesBucleTSMI.Text = "Trenes Bucle"
        '
        'DemandaTSMI
        '
        Me.DemandaTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DmdaRealTSMI, Me.DmdaProyectadaTSMI})
        Me.DemandaTSMI.Name = "DemandaTSMI"
        Me.DemandaTSMI.Size = New System.Drawing.Size(82, 27)
        Me.DemandaTSMI.Text = "Demanda"
        '
        'DmdaRealTSMI
        '
        Me.DmdaRealTSMI.Name = "DmdaRealTSMI"
        Me.DmdaRealTSMI.Size = New System.Drawing.Size(226, 24)
        Me.DmdaRealTSMI.Text = "Demanda Real"
        '
        'DmdaProyectadaTSMI
        '
        Me.DmdaProyectadaTSMI.Name = "DmdaProyectadaTSMI"
        Me.DmdaProyectadaTSMI.Size = New System.Drawing.Size(226, 24)
        Me.DmdaProyectadaTSMI.Text = "Demanda Proyectada"
        '
        'ConversoresTSMI
        '
        Me.ConversoresTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConversorUnidadesTSMI, Me.ConversorDecimalesTSMI})
        Me.ConversoresTSMI.Name = "ConversoresTSMI"
        Me.ConversoresTSMI.Size = New System.Drawing.Size(102, 27)
        Me.ConversoresTSMI.Text = "Conversores"
        '
        'ConversorUnidadesTSMI
        '
        Me.ConversorUnidadesTSMI.Name = "ConversorUnidadesTSMI"
        Me.ConversorUnidadesTSMI.Size = New System.Drawing.Size(170, 24)
        Me.ConversorUnidadesTSMI.Text = "de Unidades"
        '
        'ConversorDecimalesTSMI
        '
        Me.ConversorDecimalesTSMI.Name = "ConversorDecimalesTSMI"
        Me.ConversorDecimalesTSMI.Size = New System.Drawing.Size(170, 24)
        Me.ConversorDecimalesTSMI.Text = "de Decimales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.CalculaGrace.My.Resources.Resources.fondoAgua
        Me.PictureBox1.Location = New System.Drawing.Point(3, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(634, 254)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.CalculaGrace.My.Resources.Resources.logoMetroMask
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(634, 49)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 346)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStripInicio.ResumeLayout(False)
        Me.MenuStripInicio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStripInicio As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FrecuenciaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrecNormalTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrecFueraBucleTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntervaloTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntervaloNormalTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterFueraBucleTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OfertaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OfertaNormalTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OfertaFueraBucleTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DensidadTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DensidadNormalTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrenesTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrenesLargosTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrenesBucleTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DemandaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DmdaRealTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DmdaProyectadaTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversoresTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversorUnidadesTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversorDecimalesTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosTrenesTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DensidadFueraBucleTSMI As System.Windows.Forms.ToolStripMenuItem
End Class
