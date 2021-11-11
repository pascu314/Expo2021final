<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NFORMACIÓNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUÉSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIFOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PORPRIORIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SJFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIPOSDEALGORITMOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIFOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PORPRIORIDADESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SJFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblIntegrantes = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblInstrucciones = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NFORMACIÓNToolStripMenuItem, Me.TIPOSDEALGORITMOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-2, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(252, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NFORMACIÓNToolStripMenuItem
        '
        Me.NFORMACIÓNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QUÉSONToolStripMenuItem, Me.FIFOToolStripMenuItem, Me.PORPRIORIDADESToolStripMenuItem, Me.SJFToolStripMenuItem})
        Me.NFORMACIÓNToolStripMenuItem.Name = "NFORMACIÓNToolStripMenuItem"
        Me.NFORMACIÓNToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.NFORMACIÓNToolStripMenuItem.Text = "INFORMACIÓN"
        '
        'QUÉSONToolStripMenuItem
        '
        Me.QUÉSONToolStripMenuItem.Name = "QUÉSONToolStripMenuItem"
        Me.QUÉSONToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.QUÉSONToolStripMenuItem.Text = "¿QUÉ SON?"
        '
        'FIFOToolStripMenuItem
        '
        Me.FIFOToolStripMenuItem.Name = "FIFOToolStripMenuItem"
        Me.FIFOToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.FIFOToolStripMenuItem.Text = "FIFO"
        '
        'PORPRIORIDADESToolStripMenuItem
        '
        Me.PORPRIORIDADESToolStripMenuItem.Name = "PORPRIORIDADESToolStripMenuItem"
        Me.PORPRIORIDADESToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PORPRIORIDADESToolStripMenuItem.Text = "POR PRIORIDADES"
        '
        'SJFToolStripMenuItem
        '
        Me.SJFToolStripMenuItem.Name = "SJFToolStripMenuItem"
        Me.SJFToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SJFToolStripMenuItem.Text = "SJF"
        '
        'TIPOSDEALGORITMOSToolStripMenuItem
        '
        Me.TIPOSDEALGORITMOSToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TIPOSDEALGORITMOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIFOToolStripMenuItem1, Me.PORPRIORIDADESToolStripMenuItem1, Me.SJFToolStripMenuItem1})
        Me.TIPOSDEALGORITMOSToolStripMenuItem.Name = "TIPOSDEALGORITMOSToolStripMenuItem"
        Me.TIPOSDEALGORITMOSToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.TIPOSDEALGORITMOSToolStripMenuItem.Text = "TIPOS DE ALGORITMOS"
        '
        'FIFOToolStripMenuItem1
        '
        Me.FIFOToolStripMenuItem1.Name = "FIFOToolStripMenuItem1"
        Me.FIFOToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.FIFOToolStripMenuItem1.Text = "FIFO"
        '
        'PORPRIORIDADESToolStripMenuItem1
        '
        Me.PORPRIORIDADESToolStripMenuItem1.Name = "PORPRIORIDADESToolStripMenuItem1"
        Me.PORPRIORIDADESToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.PORPRIORIDADESToolStripMenuItem1.Text = "POR PRIORIDADES"
        '
        'SJFToolStripMenuItem1
        '
        Me.SJFToolStripMenuItem1.Name = "SJFToolStripMenuItem1"
        Me.SJFToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.SJFToolStripMenuItem1.Text = "SJF"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo.Location = New System.Drawing.Point(81, 55)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(607, 25)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "BIENVENIDO AL SIMULADOR DE ALGORITMOS DE PLANIFICACIÓN"
        '
        'LblIntegrantes
        '
        Me.LblIntegrantes.AutoSize = True
        Me.LblIntegrantes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblIntegrantes.Location = New System.Drawing.Point(12, 355)
        Me.LblIntegrantes.Name = "LblIntegrantes"
        Me.LblIntegrantes.Size = New System.Drawing.Size(407, 63)
        Me.LblIntegrantes.TabIndex = 2
        Me.LblIntegrantes.Text = resources.GetString("LblIntegrantes.Text")
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo.Location = New System.Drawing.Point(37, 174)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(602, 20)
        Me.LblInfo.TabIndex = 3
        Me.LblInfo.Text = "- Para ingresar al contenido teórico seleccione una opción de la pestaña ""INFORMA" &
    "CIÓN"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(37, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "- Para ingresar a la simulación seleccione una opción de la pestaña ""TIPOS DE ALG" &
    "ORITMOS"""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(66, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 5)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(66, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 5)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(66, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 35)
        Me.Panel3.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(687, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 35)
        Me.Panel4.TabIndex = 8
        '
        'LblInstrucciones
        '
        Me.LblInstrucciones.AutoSize = True
        Me.LblInstrucciones.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblInstrucciones.Location = New System.Drawing.Point(22, 141)
        Me.LblInstrucciones.Name = "LblInstrucciones"
        Me.LblInstrucciones.Size = New System.Drawing.Size(132, 21)
        Me.LblInstrucciones.TabIndex = 9
        Me.LblInstrucciones.Text = "INSTRUCCIONES"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCerrar.Location = New System.Drawing.Point(655, 498)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(83, 29)
        Me.BtnCerrar.TabIndex = 10
        Me.BtnCerrar.Text = "CERRAR"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 539)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblInstrucciones)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.LblIntegrantes)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulador de algoritmos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NFORMACIÓNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QUÉSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIFOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PORPRIORIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SJFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TIPOSDEALGORITMOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIFOToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PORPRIORIDADESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SJFToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblIntegrantes As Label
    Friend WithEvents LblInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblInstrucciones As Label
    Friend WithEvents BtnCerrar As Button
End Class
