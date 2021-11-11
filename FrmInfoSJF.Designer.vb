<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfoSJF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfoSJF))
        Me.BtnVolverSJF = New System.Windows.Forms.Button()
        Me.LblTitulo1 = New System.Windows.Forms.Label()
        Me.LblInfo1 = New System.Windows.Forms.Label()
        Me.LblTitulo2 = New System.Windows.Forms.Label()
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.lblTitulo3 = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnVolverSJF
        '
        Me.BtnVolverSJF.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolverSJF.Location = New System.Drawing.Point(663, 504)
        Me.BtnVolverSJF.Name = "BtnVolverSJF"
        Me.BtnVolverSJF.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolverSJF.TabIndex = 7
        Me.BtnVolverSJF.Text = "VOLVER"
        Me.BtnVolverSJF.UseVisualStyleBackColor = False
        '
        'LblTitulo1
        '
        Me.LblTitulo1.AutoSize = True
        Me.LblTitulo1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo1.Location = New System.Drawing.Point(12, 32)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(197, 30)
        Me.LblTitulo1.TabIndex = 10
        Me.LblTitulo1.Text = "¿Qué significa SJF?"
        '
        'LblInfo1
        '
        Me.LblInfo1.AutoSize = True
        Me.LblInfo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo1.Location = New System.Drawing.Point(24, 84)
        Me.LblInfo1.Name = "LblInfo1"
        Me.LblInfo1.Size = New System.Drawing.Size(588, 21)
        Me.LblInfo1.TabIndex = 11
        Me.LblInfo1.Text = "SJF significa ""Shortest Job First"" lo que traducido es ""Primero El Trabajo Más Co" &
    "rto""."
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo2.Location = New System.Drawing.Point(12, 139)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(182, 30)
        Me.LblTitulo2.TabIndex = 12
        Me.LblTitulo2.Text = "¿Cómo funciona?"
        '
        'LblInfo2
        '
        Me.LblInfo2.AutoSize = True
        Me.LblInfo2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo2.Location = New System.Drawing.Point(24, 192)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(649, 63)
        Me.LblInfo2.TabIndex = 13
        Me.LblInfo2.Text = resources.GetString("LblInfo2.Text")
        '
        'lblTitulo3
        '
        Me.lblTitulo3.AutoSize = True
        Me.lblTitulo3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo3.Location = New System.Drawing.Point(12, 308)
        Me.lblTitulo3.Name = "lblTitulo3"
        Me.lblTitulo3.Size = New System.Drawing.Size(413, 30)
        Me.lblTitulo3.TabIndex = 14
        Me.lblTitulo3.Text = "¿Cúal es el problema con este algoritmo?"
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfo3.Location = New System.Drawing.Point(24, 364)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(686, 63)
        Me.lblInfo3.TabIndex = 15
        Me.lblInfo3.Text = "Este sistema tiene el riesgo de poner siempre al final de la cola los procesos má" &
    "s largos por lo que" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nunca se ejecutarán, esto se conoce como inanición." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmInfoSJF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 539)
        Me.Controls.Add(Me.lblInfo3)
        Me.Controls.Add(Me.lblTitulo3)
        Me.Controls.Add(Me.LblInfo2)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblInfo1)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Controls.Add(Me.BtnVolverSJF)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInfoSJF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMACIÓN ""SJF"""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolverSJF As Button
    Friend WithEvents LblTitulo1 As Label
    Friend WithEvents LblInfo1 As Label
    Friend WithEvents LblTitulo2 As Label
    Friend WithEvents LblInfo2 As Label
    Friend WithEvents lblTitulo3 As Label
    Friend WithEvents lblInfo3 As Label
End Class
