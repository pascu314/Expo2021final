Public Class FrmSjf
    Private Sub BtnVolverSJF_Click(sender As Object, e As EventArgs) Handles BtnVolverSJF.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresarSJf_Click(sender As Object, e As EventArgs) Handles BtnIngresarSJf.Click
        If TxtTiempo.Text > 9 Then
            TxtTiempo.Text = ""
            MsgBox("INGRESE NÚMEROS DEL 1 AL 9")
        End If
        'ingreso de datos


        If TxtProcesosSJF.Text = "" Or TxtTiempo.Text = "" Then
            MsgBox("COMPLETE LOS ESPACIOS VACIOS")
            TxtProcesosSJF.Text = ""
            TxtTiempo.Text = ""
        Else
            If proceso1.Text = "" And tiempo1.Text = "" Then
                proceso1.Text = TxtProcesosSJF.Text
                tiempo1.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text = "" Then
                proceso2.Text = TxtProcesosSJF.Text
                tiempo2.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text = "" Then
                proceso3.Text = TxtProcesosSJF.Text
                tiempo3.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text = "" Then
                proceso4.Text = TxtProcesosSJF.Text
                tiempo4.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text = "" Then
                proceso5.Text = TxtProcesosSJF.Text
                tiempo5.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text = "" Then
                proceso6.Text = TxtProcesosSJF.Text
                tiempo6.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text = "" Then
                proceso7.Text = TxtProcesosSJF.Text
                tiempo7.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text = "" Then
                proceso8.Text = TxtProcesosSJF.Text
                tiempo8.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text IsNot "" And proceso9.Text = "" Then
                proceso9.Text = TxtProcesosSJF.Text
                tiempo9.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text IsNot "" And proceso9.Text IsNot "" And proceso10.Text = "" Then
                proceso10.Text = TxtProcesosSJF.Text
                tiempo10.Text = TxtTiempo.Text
                TxtProcesosSJF.Text = ""
                TxtTiempo.Text = ""
            End If
        End If
    End Sub
    Private Sub TxtTiempo_TextChanged(sender As Object, e As EventArgs) Handles TxtTiempo.TextChanged
        Dim numero As Integer
        Dim Tiempo As String
        Tiempo = TxtTiempo.Text
        numero = IsNumeric(Tiempo)
        If numero = False Then
            TxtTiempo.Text = ""
            'no se pueden ingresar letras en el tiempo
        End If
    End Sub
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If proceso1.Text IsNot "" And tiempo1.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo1.Text & " -- " & proceso1.Text)
        End If
        If proceso2.Text IsNot "" And tiempo2.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo2.Text & " -- " & proceso2.Text)
        End If
        If proceso3.Text IsNot "" And tiempo3.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo3.Text & " -- " & proceso3.Text)
        End If
        If proceso4.Text IsNot "" And tiempo4.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo4.Text & " -- " & proceso4.Text)
        End If
        If proceso5.Text IsNot "" And tiempo5.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo5.Text & " -- " & proceso5.Text)
        End If
        If proceso6.Text IsNot "" And tiempo6.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo6.Text & " -- " & proceso6.Text)
        End If
        If proceso7.Text IsNot "" And tiempo7.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo7.Text & " -- " & proceso7.Text)
        End If
        If proceso8.Text IsNot "" And tiempo8.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo8.Text & " -- " & proceso8.Text)
        End If
        If proceso9.Text IsNot "" And tiempo9.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo9.Text & " -- " & proceso9.Text)
        End If
        If proceso10.Text IsNot "" And tiempo10.Text IsNot "" Then
            ListaOrden.Items.Add(tiempo10.Text & " -- " & proceso10.Text)
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
        tiempo1.Text = ""
        tiempo2.Text = ""
        tiempo3.Text = ""
        tiempo4.Text = ""
        tiempo5.Text = ""
        tiempo6.Text = ""
        tiempo7.Text = ""
        tiempo8.Text = ""
        tiempo9.Text = ""
        tiempo10.Text = ""
        ListaOrden.Items.Clear()
    End Sub

End Class