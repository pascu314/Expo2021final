Public Class FrmPrioridades

    Private Sub BtnIngresarPrio_Click(sender As Object, e As EventArgs) Handles BtnIngresarPrio.Click
        If TxtPrioridad.Text > 9 Then
            TxtPrioridad.Text = ""
            MsgBox("INGRESE NÚMEROS DEL 1 AL 9")
        End If
        'ingreso de datos
        If TxtProcesosPrioridades.Text = "" Or TxtPrioridad.Text = "" Then
            MsgBox("COMPLETE LOS ESPACIOS VACIOS")
            TxtProcesosPrioridades.Text = ""
            TxtPrioridad.Text = ""
        Else
            If proceso1.Text = "" And prioridad1.Text = "" Then
                proceso1.Text = TxtProcesosPrioridades.Text
                prioridad1.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text = "" Then
                proceso2.Text = TxtProcesosPrioridades.Text
                prioridad2.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text = "" Then
                proceso3.Text = TxtProcesosPrioridades.Text
                prioridad3.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text = "" Then
                proceso4.Text = TxtProcesosPrioridades.Text
                prioridad4.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text = "" Then
                proceso5.Text = TxtProcesosPrioridades.Text
                prioridad5.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text = "" Then
                proceso6.Text = TxtProcesosPrioridades.Text
                prioridad6.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text = "" Then
                proceso7.Text = TxtProcesosPrioridades.Text
                prioridad7.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text = "" Then
                proceso8.Text = TxtProcesosPrioridades.Text
                prioridad8.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text IsNot "" And proceso9.Text = "" Then
                proceso9.Text = TxtProcesosPrioridades.Text
                prioridad9.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text IsNot "" And proceso9.Text IsNot "" And proceso10.Text = "" Then
                proceso10.Text = TxtProcesosPrioridades.Text
                prioridad10.Text = TxtPrioridad.Text
                TxtProcesosPrioridades.Text = ""
                TxtPrioridad.Text = ""
            End If
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If proceso1.Text IsNot "" And prioridad1.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad1.Text & " -- " & proceso1.Text)
        End If
        If proceso2.Text IsNot "" And prioridad2.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad2.Text & " -- " & proceso2.Text)
        End If
        If proceso3.Text IsNot "" And prioridad3.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad3.Text & " -- " & proceso3.Text)
        End If
        If proceso4.Text IsNot "" And prioridad4.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad4.Text & " -- " & proceso4.Text)
        End If
        If proceso5.Text IsNot "" And prioridad5.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad5.Text & " -- " & proceso5.Text)
        End If
        If proceso6.Text IsNot "" And prioridad6.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad6.Text & " -- " & proceso6.Text)
        End If
        If proceso7.Text IsNot "" And prioridad7.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad7.Text & " -- " & proceso7.Text)
        End If
        If proceso8.Text IsNot "" And prioridad8.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad8.Text & " -- " & proceso8.Text)
        End If
        If proceso9.Text IsNot "" And prioridad9.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad9.Text & " -- " & proceso9.Text)
        End If
        If proceso10.Text IsNot "" And prioridad10.Text IsNot "" Then
            ListaOrden.Items.Add(prioridad10.Text & " -- " & proceso10.Text)
        End If
    End Sub


    Private Sub TxtPrioridad_TextChanged(sender As Object, e As EventArgs) Handles TxtPrioridad.TextChanged
        Dim numero As Integer
        Dim Tiempo As String
        Tiempo = TxtPrioridad.Text
        numero = IsNumeric(Tiempo)
        If numero = False Then
            TxtPrioridad.Text = ""
            'no se pueden ingresar letras en el tiempo
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        proceso1.Text = ""
        proceso2.Text = ""
        proceso3.Text = ""
        proceso4.Text = ""
        proceso5.Text = ""
        proceso6.Text = ""
        proceso7.Text = ""
        proceso8.Text = ""
        proceso9.Text = ""
        proceso10.Text = ""
        prioridad1.Text = ""
        prioridad2.Text = ""
        prioridad3.Text = ""
        prioridad4.Text = ""
        prioridad5.Text = ""
        prioridad6.Text = ""
        prioridad7.Text = ""
        prioridad8.Text = ""
        prioridad9.Text = ""
        prioridad10.Text = ""
        ListaOrden.Items.Clear()
    End Sub

    Private Sub BtnVolverPrio_Click(sender As Object, e As EventArgs) Handles BtnVolverPrio.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class