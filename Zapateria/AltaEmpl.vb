﻿Public Class AltaEmpl

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltaEmpl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)
        Me.EmpleadosBindingSource.AddNew()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If CmbLocalidad.SelectedValue = Nothing Then
            MsgBox("Elija una localidad")
            Exit Sub
        End If
        If DNITextBox.Text = Nothing Then
            MsgBox("Ingrese el dni")
            Exit Sub
        End If
        Me.EmpleadosBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.EmpleadosBindingSource.Current("DNI") = Val(DNITextBox.Text)
        Me.EmpleadosBindingSource.Current("Nombre") = NombreTextBox.Text
        Me.EmpleadosBindingSource.Current("Apellido") = ApellidoTextBox.Text
        Me.EmpleadosBindingSource.Current("Fec_Nacimiento") = Fec_NacimientoDateTimePicker.Value
        Me.EmpleadosBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.EmpleadosBindingSource.Current("Nro") = Val(NroTextBox.Text)
        Me.EmpleadosBindingSource.Current("Fec_Contr") = Fec_ContrDateTimePicker.Value
        Me.EmpleadosBindingSource.Current("Cargo") = CargoTextBox.Text
        Me.EmpleadosBindingSource.Current("54") = Val(_54TextBox.Text)
        Me.EmpleadosBindingSource.Current("011") = Val(_011TextBox.Text)
        Me.EmpleadosBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados) 'actualizo en altas
        Empl.EmpleadosTableAdapter.Fill(Empl.ZapateriaDataSet.Empleados) 'actualizo en principal para que muestre el cod del art
        Me.EmpleadosBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de empleado es:" + Me.EmpleadosBindingSource.Current("ID_Emp").ToString)
        Me.EmpleadosBindingSource.AddNew()

    End Sub

    Private Sub AltaEmpl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BtnGuardar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AltaLoc.Show()

    End Sub
    Private Sub NroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NroTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If

    End Sub

    Private Sub DNITextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DNITextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub ApellidoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub CargoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CargoTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub _54TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _54TextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub _011TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _011TextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub TelefonoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub
End Class