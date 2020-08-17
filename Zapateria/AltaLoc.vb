﻿Public Class AltaLoc

    Private Sub LocalidadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LocalidadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub


    Private Sub LocalidadBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LocalidadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltaLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        Me.LocalidadBindingSource.AddNew()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If LocalidadTextBox.Text = Nothing Then
            MsgBox("Ingrese la localidad")
            Exit Sub
        End If
        If CPTextBox.Text = Nothing Then
            MsgBox("Ingrese el CP")
            Exit Sub
        End If
        Me.Validate()
            Me.LocalidadBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
            Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        MostrarLoc.LocalidadTableAdapter.Fill(MostrarLoc.ZapateriaDataSet.Localidad)
        AltasProv.LocalidadTableAdapter.Fill(AltasProv.ZapateriaDataSet.Localidad)
        AltaCli.LocalidadTableAdapter.Fill(AltaCli.ZapateriaDataSet.Localidad)
        AltaEmpl.LocalidadTableAdapter.Fill(AltaEmpl.ZapateriaDataSet.Localidad)
            Me.LocalidadBindingSource.MoveLast()
            MsgBox("El codigo de la localidad es:" + Me.LocalidadBindingSource.Current("ID_Localidad").ToString)
            Me.LocalidadBindingSource.AddNew()
        
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()
    End Sub

    Private Sub AltaLoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BtnGuardar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub ZonaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ZonaTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub CPTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CPTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub
End Class