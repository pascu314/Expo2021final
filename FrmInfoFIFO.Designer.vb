<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfoFIFO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfoFIFO))
        Me.BtnVolverFIFO = New System.Windows.Forms.Button()
        Me.LblTitulo1 = New System.Windows.Forms.Label()
        Me.LblInfo3 = New System.Windows.Forms.Label()
        Me.LblTitulo3 = New System.Windows.Forms.Label()
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.LblTitulo2 = New System.Windows.Forms.Label()
        Me.LblInfo1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnVolverFIFO
        '
        Me.BtnVolverFIFO.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolverFIFO.Location = New System.Drawing.Point(663, 504)
        Me.BtnVolverFIFO.Name = "BtnVolverFIFO"
        Me.BtnVolverFIFO.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolverFIFO.TabIndex = 7
        Me.BtnVolverFIFO.Text = "VOLVER"
        Me.BtnVolverFIFO.UseVisualStyleBackColor = False
        '
        'LblTitulo1
        '
        Me.LblTitulo1.AutoSize = True
        Me.LblTitulo1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo1.Location = New System.Drawing.Point(12, 33)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(230, 30)
        Me.LblTitulo1.TabIndex = 10
        Me.LblTitulo1.Text = "¿Qué significa ""FIFO""?"
        '
        'LblInfo3
        '
        Me.LblInfo3.AutoSize = True
        Me.LblInfo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo3.Location = New System.Drawing.Point(29, 343)
        Me.LblInfo3.Name = "LblInfo3"
        Me.LblInfo3.Size = New System.Drawing.Size(679, 42)
        Me.LblInfo3.TabIndex = 19
        Me.LblInfo3.Text = "Uno de los problemas que puede presentar esta planificación es que si hay un proc" &
    "eso de mucho" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cálculo de CPU hace aumentar el tiempo de espera de los demás proc" &
    "esos."
        '
        'LblTitulo3
        '
        Me.LblTitulo3.AutoSize = True
        Me.LblTitulo3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo3.Location = New System.Drawing.Point(16, 292)
        Me.LblTitulo3.Name = "LblTitulo3"
        Me.LblTitulo3.Size = New System.Drawing.Size(413, 30)
        Me.LblTitulo3.TabIndex = 18
        Me.LblTitulo3.Text = "¿Cúal es el problema con este algoritmo?"
        '
        'LblInfo2
        '
        Me.LblInfo2.AutoSize = True
        Me.LblInfo2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo2.Location = New System.Drawing.Point(29, 186)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(636, 63)
        Me.LblInfo2.TabIndex = 17
        Me.LblInfo2.Text = resources.GetString("LblInfo2.Text")
        '
        'LblTitulo2
        '
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitulo2.Location = New System.Drawing.Point(16, 138)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(182, 30)
        Me.LblTitulo2.TabIndex = 16
        Me.LblTitulo2.Text = "¿Cómo funciona?"
        '
        'LblInfo1
        '
        Me.LblInfo1.AutoSize = True
        Me.LblInfo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInfo1.Location = New System.Drawing.Point(29, 81)
        Me.LblInfo1.Name = "LblInfo1"
        Me.LblInfo1.Size = New System.Drawing.Size(623, 21)
        Me.LblInfo1.TabIndex = 15
        Me.LblInfo1.Text = "FIFO significa ""First In, First Out"" lo que traducido es  primero en llegar y pri" &
    "mero en salir"
        '
        'FrmInfoFIFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 539)
        Me.Controls.Add(Me.LblInfo3)
        Me.Controls.Add(Me.LblTitulo3)
        Me.Controls.Add(Me.LblInfo2)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblInfo1)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Controls.Add(Me.BtnVolverFIFO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInfoFIFO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMACIÓN ""FIFO"""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolverFIFO As Button
    Friend WithEvents LblTitulo1 As Label
    Friend WithEvents LblInfo3 As Label
    Friend WithEvents LblTitulo3 As Label
    Friend WithEvents LblInfo2 As Label
    Friend WithEvents LblTitulo2 As Label
    Friend WithEvents LblInfo1 As Label
End Class
